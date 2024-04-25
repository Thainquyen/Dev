using chat;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Security.Policy;
using VietChat.Model;
using VietChat.Services;
using static System.Collections.Specialized.BitVector32;

namespace VietChat
{
    public partial class VietChat : Form
    {
        public Bitmap b_image;



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
            if (!Directory.Exists(Common.URL_IMAGE))
            {
                Directory.CreateDirectory(Common.URL_IMAGE);
            }
            pnl_add.Visible = false;
            pnl_bb.Visible = false;
        }

        private void lbl_ketban_Click(object sender, EventArgs e)
        {
            pnl_add.Visible = true;
            btn_yes.Visible = false;
            btn_no.Visible = false;
            lbl_photosearch.Visible = false;
            lbl_searchuser.Visible = false;
            txt_input.Focus();
            pnl_details.Visible = false;
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            btn_yes.Visible = false;
            btn_no.Visible = false;
            btn_huy.Visible = true;
            btn_gui.Visible = true;
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            pnl_add.Visible = false;
        }

        private void lbl_bb_Click(object sender, EventArgs e)
        {

            int start_pic_photo_X = 3;
            int start_pic_photo_Y = 3;

            int startX = 66;
            int startY = 3;

            foreach (var section in Common.job_friend)
            {
                var zone = section.Key;

                JObject obj = (JObject)Common.job_friend[zone];

                Common.name_friend = obj["name"].ToString();
                Common.user_id_friend = obj["user_id"].ToString();
                Common.photo = obj["photo"].ToString();

                if (!string.IsNullOrEmpty(Common.name_friend))
                {

                    PictureBox pic_photo = new PictureBox();
                    pic_photo.Location = new Point(start_pic_photo_X, start_pic_photo_Y);
                    pic_photo.Size = new Size(57, 38);
                    pic_photo.TabIndex = 7;
                    pic_photo.TabStop = false;

                    if (!string.IsNullOrEmpty(Common.photo))
                    {
                        string file_name = Path.GetFileName(Common.GET_PHOTO_API + Common.photo);

                        SaveImage(Common.GET_PHOTO_API + Common.photo, Common.user_id_friend + Common.user_id_friend + file_name);

                        b_image = (Bitmap)Bitmap.FromFile(Common.URL_IMAGE + Common.user_id_friend + file_name);

                        b_image = new Bitmap(b_image, new Size(pic_photo.Width, pic_photo.Height));
                        pic_photo.Image = b_image;
                        Common.b_image_user = (Bitmap)Bitmap.FromFile(Common.URL_IMAGE + Common.user_id_friend + file_name);
                        Common.b_image_user = new Bitmap(Common.b_image_user, new Size(pic_photo.Width, pic_photo.Height));
                    }


                    start_pic_photo_Y = start_pic_photo_Y + pic_photo.Width;

                    Label lbl_name = new Label();
                    lbl_name.BackColor = Color.White;
                    lbl_name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
                    lbl_name.Location = new Point(startX, startY);
                    lbl_name.Size = new Size(139, 38);
                    lbl_name.TabIndex = 5;
                    lbl_name.Text = Common.name_friend;
                    lbl_name.TextAlign = ContentAlignment.MiddleCenter;
                    lbl_name.Click += lbl_name_Click;
                    startY = startY + 12 + lbl_name.Height;

                    pnl_bb.Controls.Add(pic_photo);
                    pnl_bb.Controls.Add(lbl_name);
                    pnl_bb.Visible = true;
                }
            }

            Form1 form = new Form1();
            form.ShowDialog();
        }

        public void SaveImage(string imageUrl, string filename)
        {
            WebClient client = new WebClient();
            Stream stream = client.OpenRead(imageUrl);
            Bitmap bitmap;
            bitmap = new Bitmap(stream);

            if (!File.Exists(Common.URL_IMAGE + filename))
            {
                if (bitmap != null)
                {
                    bitmap.Save(Common.URL_IMAGE + filename);
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

                if (!string.IsNullOrEmpty(Common.image))
                {
                    string file_name = Path.GetFileName(Common.GET_PHOTO_API + Common.image);

                    SaveImage(Common.GET_PHOTO_API + Common.image, Common.uId + file_name);

                    b_image = (Bitmap)Bitmap.FromFile(Common.URL_IMAGE + Common.uId + file_name);

                    b_image = new Bitmap(b_image, new Size(lbl_photo_me.Width, lbl_photo_me.Height));
                    lbl_photo_me.Image = b_image;
                }
                timer1.Stop();
            }
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();

        }

        private async void txt_input_TextChanged(object sender, EventArgs e)
        {
            string val = txt_input.Text.Trim();
            if (!string.IsNullOrEmpty(val))
            {
                SearchUser searchUser = new SearchUser();
                var data = await searchUser.searchUser(val);

                if (data != null)
                {
                    foreach (var item in data.data.data)
                    {
                        Common.user_id_search = item.id;
                        lbl_searchuser.Text = item.nickname;
                        SaveImage(Common.GET_PHOTO_API + item.photo, item.id.ToString() + Path.GetFileName(item.photo));
                        b_image = (Bitmap)Bitmap.FromFile(Common.URL_IMAGE + item.id.ToString() + Path.GetFileName(item.photo));
                        b_image = new Bitmap(b_image, new Size(lbl_photosearch.Width, lbl_photosearch.Height));
                        lbl_photosearch.Image = b_image;
                        searchUser.getDetails(Common.user_id_search.ToString());
                    }
                }

                if (!string.IsNullOrEmpty(lbl_searchuser.Text))
                {
                    lbl_photosearch.Visible = true;
                    lbl_searchuser.Visible = true;
                }

            }
        }

        private async void lbl_searchuser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbl_searchuser.Text))
            {
                lbl_name.Text = Common.details_friend["nickname"].ToString();
                lbl_nickname.Text = Common.details_friend["nickname"].ToString();
                lbl_username.Text = Common.details_friend["username"].ToString();
                b_image = new Bitmap(b_image, new Size(lbl_photo_detail.Width, lbl_photo_detail.Height));
                lbl_photo_detail.Image = b_image;

                pnl_details.Location = new Point(22, 30);
                pnl_details.BringToFront();
                pnl_details.Visible = true;
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            lbl_text.Visible = false;
            txt_text.Visible = false;
            btn_gui.Visible = false;
            btn_huy.Visible = false;
        }
    }
}