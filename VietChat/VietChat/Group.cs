using System.Net;
using chat;
using VietChat.Model;
using VietChat.Services;

namespace VietChat
{
    public partial class Group : Form
    {
        FVietChat _vietChat;
        public Group()
        {
            InitializeComponent();
        }

        public Group(FVietChat vietChat)
        {
            _vietChat = vietChat;
            InitializeComponent();
        }

        private void btnCancelAddGroup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Group_Load(object sender, EventArgs e)
        {
            try
            {
                FriendList friendList = new FriendList();
                FriendListData data = await friendList.GetFriendList();
                tbUserlist.AutoSize = true;


                if (data != null)
                {
                    tbUserlist.RowCount = data.data.Count;
                    int row = 0;
                    foreach (var item in data.data)
                    {
                        UserGroup group = new UserGroup();
                        group.Username = item.data.name;
                        group.UserID = item.data.user_id.ToString();

                        SaveImage(Common.GET_PHOTO_API + item.data.photo, item.data.user_id + Path.GetFileName(item.data.photo));
                        group.UserImage = (Bitmap)Bitmap.FromFile(Common.URL_IMAGE + item.data.user_id + Path.GetFileName(item.data.photo));

                        tbUserlist.Controls.Add(group, 0, row);
                        row++;
                    }
                }
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

        private async void btnAddGroup_Click(object sender, EventArgs e)
        {
            try
            {
                if (Common.selectedUserID.Count == 0)
                {
                    MessageBox.Show("Chọn ít nhất 1 bạn để tạo nhóm!!!");
                    return;
                }

                AddGroup addGroup = new AddGroup();
                var res = await addGroup.AddUserGroup();

                if (res.err != 0)
                {
                    MessageBox.Show("Tạo nhóm KHÔNG thành công!!!");
                }
                MessageBox.Show("Tạo nhóm thành công!!!");
                ChatList chatList = new ChatList();
                await chatList.getChatList();
                _vietChat.LoadChat();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(Common.msg_error);
            }
        }
    }
}
