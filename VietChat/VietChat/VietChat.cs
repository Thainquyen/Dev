using chat;
using System.Net;
using VietChat.Services;

namespace VietChat
{
    public partial class VietChat : Form
    {
        public Bitmap b_image;

        public string URL_IMAGE = Application.StartupPath + @"\PHOTO\";

        public VietChat()
        {
            InitializeComponent();
        }

        private void lbl_out_Click(object sender, EventArgs e)
        {
            Form form = new Login();
            form.Show();
            this.Hide();
        }

        private void VietChat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VietChat_Load(object sender, EventArgs e)
        {
            ChatList chatlist = new ChatList();
            chatlist.getChatList();
            chatlist.getListFriend();
            // ファイルが存在するか
            if (!Directory.Exists(URL_IMAGE))
            {
                Directory.CreateDirectory(URL_IMAGE);
            }
            pnl_add.Visible = false;
            pnl_group.Visible = false;
            pnl_bb.Visible = false;
        }

        private void lbl_ketban_Click(object sender, EventArgs e)
        {
            pnl_add.Visible = true;
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {

        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            pnl_add.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            pnl_group.BringToFront();
            pnl_group.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pnl_group.SendToBack();
            pnl_group.Visible = false;
        }

        private void lbl_bb_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Common.photo))
            {
                string file_name = Path.GetFileName(Common.GET_PHOTO_API + Common.photo);

                SaveImage(Common.GET_PHOTO_API + Common.photo, file_name);

                b_image = (Bitmap)Bitmap.FromFile(URL_IMAGE + file_name);

                b_image = new Bitmap(b_image, new Size(pic_photo.Width, pic_photo.Height));

                Common.b_image_user = (Bitmap)Bitmap.FromFile(URL_IMAGE + file_name);

                Common.b_image_user = new Bitmap(Common.b_image_user, new Size(pic_photo.Width, pic_photo.Height));

                pic_photo.Image = b_image;
                pnl_bb.Visible = true;
                lbl_name.Text = Common.name_friend;
            }

            ChatList chatlist = new ChatList();
            chatlist.getChatData();

            Form1 form = new Form1();
            form.ShowDialog();
        }

        public void SaveImage(string imageUrl, string filename)
        {
            WebClient client = new WebClient();
            Stream stream = client.OpenRead(imageUrl);
            Bitmap bitmap;
            bitmap = new Bitmap(stream);

            if (!File.Exists(URL_IMAGE + filename))
            {
                if (bitmap != null)
                {
                    bitmap.Save(URL_IMAGE + filename);
                }
            }

            stream.Flush();
            stream.Close();
            client.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Common.token))
            {
                ChatList chatlist = new ChatList();
                chatlist.getChatList();
                chatlist.getListFriend();              
                timer1.Stop();
            }
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }
    }
}