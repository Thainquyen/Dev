using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VietChat.Services;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace VietChat
{
    public partial class UpdateProfile : Form
    {
        private OpenFileDialog openFileDialog1;
        string file_path = string.Empty;
        public UpdateProfile()
        {
            InitializeComponent();
        }

        private void lbl_open_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Open Image";
            openFileDialog1.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = openFileDialog1.FileName;
                    file_path = path;
                    if (!string.IsNullOrEmpty(path))
                    {
                        string file_name = Path.GetFileName(path);

                        SaveImage(path, file_name);

                        var b_image = (Bitmap)Bitmap.FromFile(Common.URL_IMAGE + file_name);

                        b_image = new Bitmap(b_image, new Size(lbl_avatar.Width, lbl_avatar.Height));
                        lbl_avatar.Image = b_image;
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
                }
            }
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

        private void UpdateProfile_Load(object sender, EventArgs e)
        {

        }

        private async void btn_yes_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_input.Text.Trim()) && lbl_avatar.Image is not null )
            {
                Register register = new Register();
                await register.uploadPhoto(file_path);
                await register.setProfile(file_path, txt_input.Text.Trim());

                MessageBox.Show("Cập nhật thành công");

                Form form = new FVietChat();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin");
            }
        }
    }
}
