using System.Net;
using VietChat.Model;
using VietChat.Services;

namespace VietChat
{
    public partial class FriendApplyDialog : Form
    {
        private FriendApplyInfo _friendApplyInfo;
        private FVietChat _vietChat;
        public FriendApplyDialog()
        {
            InitializeComponent();
        }

        public FriendApplyDialog(FVietChat vietChat, FriendApplyInfo friendApplyInfo)
        {
            _friendApplyInfo = friendApplyInfo;
            _vietChat = vietChat;
            InitializeComponent();
        }

        private void FriendApplyDialog_Load(object sender, EventArgs e)
        {
            try
            {
                lbl_username.Text = _friendApplyInfo.nickname;
                lbl_nickname.Text = _friendApplyInfo.nickname;
                lbl_name.Text = _friendApplyInfo.nickname;

                string file_name = Path.GetFileName(Common.GET_PHOTO_API + _friendApplyInfo.photo);
                SaveImage(Common.GET_PHOTO_API + _friendApplyInfo.photo, Common.uId + file_name);
                var b = (Bitmap)Bitmap.FromFile(Common.URL_IMAGE + _friendApplyInfo.user_id + file_name);
                b = new Bitmap(b, new Size(lbl_photo_me.Width, lbl_photo_me.Height));
                Common.b_image_me = b;
                lbl_photo_me.Image = b;
            }
            catch (Exception)
            {
                MessageBox.Show(Common.msg_error);
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

        private async void btnAddFriend_Click(object sender, EventArgs e)
        {
            try
            {
                if (_friendApplyInfo.text == "Xem")
                {
                    AddFriend addFriend = new AddFriend();
                    await addFriend.FriendAddAction(_friendApplyInfo);
                    _vietChat.LoadFriend();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đã là bạn bè!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Common.msg_error);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
