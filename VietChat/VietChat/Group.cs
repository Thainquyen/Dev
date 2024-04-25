using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using chat;
using VietChat.Model;
using VietChat.Services;
using static System.Net.Mime.MediaTypeNames;

namespace VietChat
{
    public partial class Group : Form
    {
        VietChat _vietChat;
        public Group()
        {
            InitializeComponent();
        }

        public Group(VietChat vietChat)
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
            _vietChat.LoadGroup();
            this.Close();
        }
    }
}
