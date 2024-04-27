using chat;
using Newtonsoft.Json;
using System.Net;
using VietChat.Model;
using VietChat.Services;
using WebSocket4Net;

namespace VietChat
{
    public partial class FVietChat : Form
    {
        public Bitmap b_image;
        private WebSocket4Net.WebSocket websocket;
        const string host = "wss://ws.vietvozchat.online";
        delegate void SetMessageCallback(SocketMesssageNewFriendRespone res);

        private void SetMessage(SocketMesssageNewFriendRespone res)
        {
            if (lbFriendNum.InvokeRequired)
            {
                SetMessageCallback d = new SetMessageCallback(SetMessage);
                this.Invoke(d, new object[] { res });
            }
            else
            {
                if (res.data != null && res.data.num > 0)
                {
                    lbFriendNum.Text = res.data.num.ToString();
                    lbFriendNum.Visible = true;

                    var path = new System.Drawing.Drawing2D.GraphicsPath();
                    path.AddEllipse(0, 0, lbFriendNum.Width, lbFriendNum.Height);

                    lbFriendNum.Region = new Region(path);
                }
            }
        }

        public FVietChat()
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

        private async void VietChat_Load(object sender, EventArgs e)
        {
            // websocket connecting
            websocket = new WebSocket4Net.WebSocket(host);

            websocket.Opened += WebSocket_Opened;
            websocket.MessageReceived += WebSocket_MessageReceived;
            websocket.Error += WebSocket_Error;
            websocket.Closed += WebSocket_Closed;
            websocket.DataReceived += WebSocket_DataReceived;
            websocket.OpenAsync();

            ChatList chatlist = new ChatList();
            await chatlist.getChatList();
            await chatlist.getListFriend();

            if (!Directory.Exists(Common.URL_IMAGE))
            {
                Directory.CreateDirectory(Common.URL_IMAGE);
            }
            pnl_add.Visible = false;
            pnl_bb.Visible = false;
            pnl_thongtin.Visible = false;
            pnl_thongtin.SendToBack();
        }

        private void WebSocket_DataReceived(object sender, DataReceivedEventArgs e)
        {
            //MessageBox.Show("Received message from server: " + e.Data);
        }

        private void WebSocket_Opened(object sender, EventArgs e)
        {
            //MessageBox.Show("WebSocket connection opened.");

            string data = "{\"action\": \"checkToken\", \"data\": \"@data@\" }";
            data = data.Replace("@data@", Common.token);
            websocket.Send(data);
        }

        private void WebSocket_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            //MessageBox.Show("Received message from server: " + e.Message);
            //string data = "{\"action\": \"ping\", \"data\": \"@data@\", \"msg\": \"hiiii\" \"}";
            //data = data.Replace("@data@", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VyX2lkIjozOCwiaXNzIjoiaW1faHR0cCIsImlhdCI6MTcxMzMyMzIxOSwiZXhwIjo3NzEzMzIzMjE5LCJuYmYiOjE3MTMzMjMyMTksInN1YiI6IiIsImp0aSI6ImU3MjkxNGU1YzA5YTY3OWFhZDI2YzI2NzBhMWU3NzlkIn0.oGzFKOSgcnU5qCqJb9hFQn3HoBY8K0m7_9vvGBhfVVs");
            //websocket.Send(data);
            try
            {
                if (!string.IsNullOrEmpty(e.Message))
                {
                    SocketMesssageRespone res = new SocketMesssageRespone();
                    res = JsonConvert.DeserializeObject<SocketMesssageRespone>(e.Message);

                    if (res != null && res.action == "newFriend")
                    {
                        var data = JsonConvert.DeserializeObject<SocketMesssageNewFriendRespone>(e.Message);
                        SetMessage(data);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void WebSocket_Error(object sender, SuperSocket.ClientEngine.ErrorEventArgs e)
        {
            //MessageBox.Show("WebSocket error: " + e.Exception.Message);
        }

        private void WebSocket_Closed(object sender, EventArgs e)
        {
            //MessageBox.Show("WebSocket connection closed.");
            websocket.Close();
        }

        private void lbl_ketban_Click(object sender, EventArgs e)
        {
            pnl_thongtin.Visible = false;
            txt_input.Text = "";
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
            lbl_text.Visible = true;
            txt_text.Visible = true;
            txt_text.Focus();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            pnl_add.Visible = false;
        }

        private async void lbl_bb_Click(object sender, EventArgs e)
        {
            pnl_add.Visible = false;
            pnl_thongtin.Visible = false;
            LoadFriend();
        }

        public async void LoadFriend()
        {
            pnl_bb.Controls.Clear();
            int start_pic_photo_X = 3;
            int start_pic_photo_Y = 3;

            int startX = 66;
            int startY = 3;

            FriendList friendList = new FriendList();
            FriendListData friends = await friendList.GetFriendList();

            foreach (var item in friends.data)
            {
                if (!string.IsNullOrEmpty(item.data.name))
                {

                    PictureBox pic_photo = new PictureBox();
                    pic_photo.Location = new Point(start_pic_photo_X, start_pic_photo_Y);
                    pic_photo.Size = new Size(57, 38);
                    pic_photo.TabIndex = 7;
                    pic_photo.TabStop = false;

                    if (!string.IsNullOrEmpty(item.data.photo))
                    {
                        string file_name = Path.GetFileName(Common.GET_PHOTO_API + item.data.photo);

                        SaveImage(Common.GET_PHOTO_API + item.data.photo, item.data.user_id + file_name);

                        b_image = (Bitmap)Bitmap.FromFile(Common.URL_IMAGE + item.data.user_id + file_name);

                        b_image = new Bitmap(b_image, new Size(pic_photo.Width, pic_photo.Height));
                        pic_photo.Image = b_image;

                    }


                    start_pic_photo_Y = start_pic_photo_Y + pic_photo.Width;

                    Label lbl_name = new Label();
                    lbl_name.BackColor = Color.White;
                    lbl_name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
                    lbl_name.Location = new Point(startX, startY);
                    lbl_name.Size = new Size(139, 38);
                    lbl_name.TabIndex = 5;
                    lbl_name.Text = item.data.name;
                    lbl_name.TextAlign = ContentAlignment.MiddleCenter;
                    //lbl_name.Click += lbl_name_Click;
                    lbl_name.Click += delegate (object sender, EventArgs e) { lbl_name_Click(sender, e, item); };
                    startY = startY + 20 + lbl_name.Height;

                    pnl_bb.Controls.Add(pic_photo);
                    pnl_bb.Controls.Add(lbl_name);
                    pnl_bb.Visible = true;
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

        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Common.token))
            {
                ChatList chatlist = new ChatList();
                await chatlist.getChatList();
                await chatlist.getListFriend();

                if (!string.IsNullOrEmpty(Common.image))
                {
                    string file_name = Path.GetFileName(Common.GET_PHOTO_API + Common.image);

                    SaveImage(Common.GET_PHOTO_API + Common.image, Common.uId + file_name);

                    b_image = (Bitmap)Bitmap.FromFile(Common.URL_IMAGE + Common.uId + file_name);

                    b_image = new Bitmap(b_image, new Size(lbl_photo_me.Width, lbl_photo_me.Height));
                    Common.b_image_me = b_image;
                    lbl_photo_me.Image = b_image;
                }
                timer1.Stop();
            }
        }

        private async void lbl_name_Click(object sender, EventArgs e, Friend item)
        {
            string file_name = Path.GetFileName(item.data.photo);
            Common.chat_friend = true;
            Common.name_friend = item.data.name;
            Common.user_id_friend = item.data.user_id.ToString();
            Common.b_image_user = (Bitmap)Bitmap.FromFile(Common.URL_IMAGE + item.data.user_id + file_name);
            SearchUser searchUser = new SearchUser();
            await searchUser.getDetails(Common.user_id_friend);

            if (Common.details_friend is not null && Common.details_friend.Count > 0)
            {
                label_Name.Text = Common.details_friend["nickname"].ToString();
                label_NickName.Text = Common.details_friend["nickname"].ToString();
                label_UserName.Text = Common.details_friend["username"].ToString();
                Common.b_image_user = new Bitmap(Common.b_image_user, new Size(label_Photo.Width, label_Photo.Height));
                label_Photo.Image = Common.b_image_user;
                pnl_thongtin.Visible = true;
                pnl_thongtin.BringToFront();
            }
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
                        await searchUser.getDetails(Common.user_id_search.ToString());
                    }
                }

                if (!string.IsNullOrEmpty(lbl_searchuser.Text))
                {
                    lbl_photosearch.Visible = true;
                    lbl_searchuser.Visible = true;
                }
                else
                {

                    lbl_photosearch.Visible = false;
                    lbl_searchuser.Visible = false;
                }
            }
        }

        private async void lbl_searchuser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbl_searchuser.Text))
            {
                if (Common.details_friend is not null && Common.details_friend.Count > 0)
                {
                    lbl_name.Text = Common.details_friend["nickname"].ToString();
                    lbl_nickname.Text = Common.details_friend["nickname"].ToString();
                    lbl_username.Text = Common.details_friend["username"].ToString();
                }

                b_image = new Bitmap(b_image, new Size(lbl_photo_detail.Width, lbl_photo_detail.Height));
                lbl_photo_detail.Image = b_image;

                pnl_details.Location = new Point(22, 30);
                pnl_details.BringToFront();
                pnl_details.Visible = true;
                lbl_text.Visible = false;
                txt_text.Visible = false;
                btn_gui.Visible = false;
                btn_huy.Visible = false;
                btn_yes.Visible = true;
                btn_no.Visible = true;
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            pnl_details.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            pnl_add.Visible = false;
            pnl_thongtin.Visible = false;
            LoadChat();
        }

        public void LoadChat(bool isGroup = true)
        {
            pnl_bb.Controls.Clear();

            if (Common.chatList.data.Count > 0)
            {
                int start_pic_photo_X = 3;
                int start_pic_photo_Y = 3;

                int startX = 66;
                int startY = 3;
                foreach (var item in Common.chatList.data)
                {
                    if (item.type == 1 && isGroup)
                    {
                        AddChatToPanel(start_pic_photo_X, ref start_pic_photo_Y, startX, ref startY, item);
                    }

                    if (item.type == 0 && !isGroup)
                    {
                        AddChatToPanel(start_pic_photo_X, ref start_pic_photo_Y, startX, ref startY, item);
                    }
                }
            }
        }

        private void AddChatToPanel(int start_pic_photo_X, ref int start_pic_photo_Y, int startX, ref int startY, ChatDetail item)
        {
            PictureBox pic_photo = new PictureBox();
            pic_photo.Location = new Point(start_pic_photo_X, start_pic_photo_Y);
            pic_photo.Size = new Size(57, 38);
            pic_photo.TabIndex = 7;
            pic_photo.TabStop = false;

            if (!string.IsNullOrEmpty(item.photo_path))
            {
                string file_name = Path.GetFileName(Common.GET_PHOTO_API + item.photo_path);

                SaveImage(Common.GET_PHOTO_API + item.photo_path, item.list_id + file_name);

                b_image = (Bitmap)Bitmap.FromFile(Common.URL_IMAGE + item.list_id + file_name);

                b_image = new Bitmap(b_image, new Size(pic_photo.Width, pic_photo.Height));
                pic_photo.Image = b_image;
            }


            start_pic_photo_Y = start_pic_photo_Y + pic_photo.Width;

            Label lbl_name = new Label();
            lbl_name.BackColor = Color.White;
            lbl_name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_name.Location = new Point(startX, startY);
            lbl_name.Size = new Size(139, 38);
            lbl_name.TabIndex = 5;
            lbl_name.Text = item.show_name;
            lbl_name.TextAlign = ContentAlignment.MiddleCenter;
            //lbl_name.Click += lbl_name_Click;
            lbl_name.Click += delegate (object sender, EventArgs e) { label_Click(sender, e, item); };
            startY = startY + 20 + lbl_name.Height;

            pnl_bb.Controls.Add(pic_photo);
            pnl_bb.Controls.Add(lbl_name);
            pnl_bb.Visible = true;
        }

        void label_Click(object sender, EventArgs e, ChatDetail chat)
        {
            Common.list_id = chat.list_id;
            Common.chat_friend = false;
            Common.group_name = chat.show_name;
            string? path = chat.list_id + Path.GetFileName(chat.photo_path);
            Common.photo_group = (Bitmap)Bitmap.FromFile(Common.URL_IMAGE + path);

            Form1 form = new Form1(this);
            form.ShowDialog();
        }

        private void lbCreateGroup_Click(object sender, EventArgs e)
        {
            pnl_thongtin.Visible = false;
            pnl_add.Visible = false;
            Group group = new Group(this);
            group.ShowDialog();
        }

        private async void btn_gui_Click(object sender, EventArgs e)
        {
            FriendList friend_add = new FriendList();
            bool error_flg = await friend_add.AddFriend(txt_text.Text.Trim(), Common.details_friend["user_id"].ToString());

            if (!error_flg)
            {
                MessageBox.Show("Gửi lời kết bạn KHÔNG thành công !!!");
            }
            MessageBox.Show("Gửi lời kết bạn thành công !!!");

            lbl_name.Text = "";
            lbl_nickname.Text = "";
            lbl_username.Text = "";
            lbl_photo_detail.Image = null;
            pnl_details.Visible = false;
            lbl_text.Visible = false;
            txt_text.Visible = false;
            btn_gui.Visible = false;
            btn_huy.Visible = false;
            btn_yes.Visible = false;
            btn_no.Visible = false;
            txt_text.Text = "";
            pnl_add.Visible = false;
        }

        private async void lblNewFriend_Click(object sender, EventArgs e)
        {
            pnl_thongtin.Visible = false;
            pnl_add.Visible = false;
            ApplyFriend applyFriend = new ApplyFriend();
            var res = await applyFriend.GetListApplyFriend();

            int start_pic_photo_X = 3;
            int start_pic_photo_Y = 3;

            int startX = 66;
            int startY = 3;

            if (res.data.Count > 0)
            {
                pnl_bb.Controls.Clear();
                foreach (var item in res.data)
                {
                    PictureBox pic_photo = new PictureBox();
                    pic_photo.Location = new Point(start_pic_photo_X, start_pic_photo_Y);
                    pic_photo.Size = new Size(57, 38);
                    pic_photo.TabIndex = 7;
                    pic_photo.TabStop = false;

                    if (!string.IsNullOrEmpty(item.photo))
                    {
                        string file_name = Path.GetFileName(Common.GET_PHOTO_API + item.photo);

                        SaveImage(Common.GET_PHOTO_API + item.photo, item.user_id + file_name);

                        b_image = (Bitmap)Bitmap.FromFile(Common.URL_IMAGE + item.user_id + file_name);

                        b_image = new Bitmap(b_image, new Size(pic_photo.Width, pic_photo.Height));
                        pic_photo.Image = b_image;
                    }


                    start_pic_photo_Y = start_pic_photo_Y + pic_photo.Width;

                    Label lbl_name = new Label();
                    lbl_name.BackColor = Color.White;
                    lbl_name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
                    lbl_name.Location = new Point(startX, startY);
                    lbl_name.Size = new Size(100, 38);
                    lbl_name.TabIndex = 5;
                    lbl_name.Text = item.nickname;
                    lbl_name.TextAlign = ContentAlignment.MiddleCenter;

                    // label for apply friend
                    Label lb_appText = new Label();
                    lb_appText.BackColor = Color.Aqua;
                    lb_appText.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
                    lb_appText.Location = new Point(startX + lbl_name.Width, startY);
                    lb_appText.Size = new Size(39, 38);
                    lb_appText.TabIndex = 6;
                    lb_appText.Text = item.text;
                    lb_appText.Click += delegate (object sender, EventArgs e) { label_Apply_Click(sender, e, item); };
                    lb_appText.TextAlign = ContentAlignment.MiddleCenter;

                    startY = startY + 20 + lbl_name.Height;

                    pnl_bb.Controls.Add(pic_photo);
                    pnl_bb.Controls.Add(lbl_name);
                    pnl_bb.Controls.Add(lb_appText);
                    pnl_bb.Visible = true;
                }

                if (lbFriendNum.Text != "")
                {
                    lbFriendNum.Visible = false;
                    lbFriendNum.Text = "";
                }
            }
        }
        void label_Apply_Click(object sender, EventArgs e, FriendApplyInfo info)
        {
            FriendApplyDialog dialog = new FriendApplyDialog(this, info);
            dialog.ShowDialog();
        }

        private void lbChatList_Click(object sender, EventArgs e)
        {
            pnl_add.Visible = false;
            pnl_thongtin.Visible = false;
            LoadChat(false);
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            pnl_thongtin.Visible = false;
        }

        private async void btn_gui_msg_Click(object sender, EventArgs e)
        {
            ChatList chatlist = new ChatList();
            await chatlist.getListId(Common.user_id_friend);

            Form1 form = new Form1(this);
            form.ShowDialog();
            pnl_thongtin.Visible = false;
        }
    }
}