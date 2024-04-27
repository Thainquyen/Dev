﻿using Newtonsoft.Json;
using VietChat;
using VietChat.Model;
using VietChat.Services;
using WebSocket4Net;

namespace chat
{
    public partial class Form1 : BeautyForm //Inherited from Beauty, which a custom form.
    {
        private WebSocket4Net.WebSocket websocket;
        const string host = "wss://ws.vietvozchat.online";
        delegate void SetMessageCallback(SocketMesssageRespone res);

        private void SetMessage(SocketMesssageRespone res)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.panel4.InvokeRequired)
            {
                SetMessageCallback d = new SetMessageCallback(SetMessage);
                this.Invoke(d, new object[] { res });
            }
            else
            {
                // you
                if (res.data.data.msg.user_info.uid != Common.uId)
                {
                    YouBubble youBubble = new YouBubble();
                    youBubble.AutoSize = true;
                    youBubble.BackColor = Color.Transparent;
                    youBubble.Body = res.data.data.msg.content.text + "\r\n";
                    youBubble.ChatImageCursor = Cursors.Default;
                    youBubble.ChatTextCursor = Cursors.IBeam;
                    youBubble.Dock = DockStyle.Bottom;
                    youBubble.MsgColor = Color.DodgerBlue;
                    youBubble.MsgTextColor = SystemColors.ControlLightLight;
                    youBubble.Padding = new Padding(0, 5, 0, 5);
                    youBubble.Size = new Size(768, 152);
                    youBubble.Status = MessageStatus.Custom;
                    youBubble.TabIndex = 2;
                    youBubble.Time = "11:44 PM";
                    youBubble.TimeColor = Color.White;
                    youBubble.UserImage = Common.b_image_user;
                    panel4.Controls.Add(youBubble);
                }
                else
                {
                    MeBubble meBubble = new MeBubble();
                    meBubble.AutoSize = true;
                    meBubble.BackColor = Color.Transparent;
                    meBubble.Body = res.data.data.msg.content.text + "\r\n";
                    meBubble.ChatImageCursor = Cursors.Default;
                    meBubble.ChatTextCursor = Cursors.IBeam;
                    meBubble.Dock = DockStyle.Bottom;
                    meBubble.MsgColor = Color.DodgerBlue;
                    meBubble.MsgTextColor = SystemColors.ControlLightLight;
                    meBubble.Padding = new Padding(0, 5, 0, 5);
                    meBubble.Size = new Size(768, 152);
                    meBubble.Status = MessageStatus.Custom;
                    meBubble.TabIndex = 2;
                    meBubble.Time = "11:44 PM";
                    meBubble.TimeColor = Color.White;
                    meBubble.UserImage = Common.b_image_me;
                    panel4.Controls.Add(meBubble);
                }

                panel4.AutoScrollPosition = new Point(0, panel4.VerticalScroll.Maximum);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private FVietChat _vietChat;
        public Form1(FVietChat vietChat)
        {
            _vietChat = vietChat;
            InitializeComponent();
        }

        //Move Form with the mouse. This method is available in BeautyForm that this form inherits
        protected override void OnMouseDownMoveForm(object sender, MouseEventArgs e)
        {
            base.OnMouseDownMoveForm(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void typingBox1_OnTypingTextChanged(string newVal)
        {
            // When you type something this fires... From 'typingBox11.OnTypingTextChanged'
            //'NewVal' is the new value... also can be gotten from 'typingBox1.Value'

        }

        private async void typingBox1_OnHitEnter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(typingBox1.Value))
            {
                ChatList chatlist = new ChatList();
                await chatlist.getTextMsg(typingBox1.Value);
                typingBox1.Value = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OnUserClick(object sender, EventArgs e)
        {
            var ClickedUser = ((Users)sender);

            string name = ClickedUser.Username;
            string statusText = ClickedUser.StatusMessage;
            Image profileImage = ClickedUser.UserImage;

            this.chatHeader1.UserTitle = name;
            this.chatHeader1.UserStatusText = statusText;
            this.chatHeader1.UserImage = profileImage;
        }

        private void users1_Load(object sender, EventArgs e)
        {
            //youBubble1.Body = Common.last_msg;
            //youBubble1.UserImage = Common.b_image_user;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            websocket = new WebSocket4Net.WebSocket(host);

            websocket.Opened += WebSocket_Opened;
            websocket.MessageReceived += WebSocket_MessageReceived;
            websocket.Error += WebSocket_Error;
            websocket.Closed += WebSocket_Closed;
            websocket.DataReceived += WebSocket_DataReceived;
            websocket.OpenAsync();
            if (Common.chat_friend)
            {
                LoadChatFriend();
            }
            else
            {
                LoadChatGroup();
            }

        }

        private async void LoadChatFriend()
        {
            users1.Username = Common.name_friend;
            users1.UserImage = Common.b_image_user;

            chatHeader1.UserTitle = Common.name_friend;
            chatHeader1.UserImage = Common.b_image_user;

            ChatList chatlist = new ChatList();
            ChatDataRespone chatDataRespone = await chatlist.getChatData();

            if (chatDataRespone != null && chatDataRespone?.data?.list?.Count > 0)
            {
                for (int i = 0; i < chatDataRespone?.data?.list?.Count; i++)
                {
                    DataList item = chatDataRespone?.data?.list[i];
                    // me
                    if (item.msg.user_info.uid == Common.uId)
                    {
                        MeBubble meBubble = new MeBubble();
                        meBubble.AutoSize = true;
                        meBubble.BackColor = Color.Transparent;
                        meBubble.Body = item.msg.content.text + "\r\n";
                        meBubble.ChatImageCursor = Cursors.Default;
                        meBubble.ChatTextCursor = Cursors.IBeam;
                        meBubble.Dock = DockStyle.Bottom;
                        meBubble.MsgColor = Color.DodgerBlue;
                        meBubble.MsgTextColor = SystemColors.ControlLightLight;
                        meBubble.Padding = new Padding(0, 5, 0, 5);
                        meBubble.Size = new Size(768, 152);
                        meBubble.Status = MessageStatus.Custom;
                        meBubble.TabIndex = 2;
                        meBubble.Time = "11:44 PM";
                        meBubble.TimeColor = Color.White;
                        Common.b_image_me = new Bitmap(Common.b_image_me, new Size(65, 58));
                        meBubble.UserImage = Common.b_image_me;
                        panel4.Controls.Add(meBubble);
                    }
                    else
                    {
                        // you
                        YouBubble youBubble = new YouBubble();
                        youBubble.AutoSize = true;
                        youBubble.BackColor = Color.Transparent;
                        youBubble.Body = item.msg.content.text + "\r\n";
                        youBubble.ChatImageCursor = Cursors.Default;
                        youBubble.ChatTextCursor = Cursors.IBeam;
                        youBubble.Dock = DockStyle.Bottom;
                        youBubble.MsgColor = Color.DodgerBlue;
                        youBubble.MsgTextColor = SystemColors.ControlLightLight;
                        youBubble.Padding = new Padding(0, 5, 0, 5);
                        youBubble.Size = new Size(768, 152);
                        youBubble.Status = MessageStatus.Custom;
                        youBubble.TabIndex = 2;
                        youBubble.Time = "11:44 PM";
                        youBubble.TimeColor = Color.White;
                        if (Common.b_image_user != null)
                        {
                            Common.b_image_user = new Bitmap(Common.b_image_user, new Size(65, 58));
                            youBubble.UserImage = Common.b_image_user;
                        }
                        panel4.Controls.Add(youBubble);
                    }
                }

                panel4.AutoScrollMinSize = new Size(0, panel4.Height);
                panel4.AutoScrollPosition = new Point(0, panel4.VerticalScroll.Maximum);
                panel4.ResumeLayout();
                this.PerformLayout();
            }
            typingBox1.Focus();
        }

        private async void LoadChatGroup()
        {
            users1.Username = Common.group_name;
            users1.UserImage = Common.photo_group;

            chatHeader1.UserTitle = Common.group_name;
            chatHeader1.UserImage = Common.photo_group;

            ChatList chatlist = new ChatList();
            ChatDataRespone chatDataRespone = await chatlist.getChatData();

            if (chatDataRespone != null && chatDataRespone?.data?.list?.Count > 0)
            {
                for (int i = 0; i < chatDataRespone?.data?.list?.Count; i++)
                {
                    DataList item = chatDataRespone?.data?.list[i];
                    // me
                    if (item.msg.user_info.uid == Common.uId)
                    {
                        MeBubble meBubble = new MeBubble();
                        meBubble.AutoSize = true;
                        meBubble.BackColor = Color.Transparent;
                        meBubble.Body = item.msg.content.text + "\r\n";
                        meBubble.ChatImageCursor = Cursors.Default;
                        meBubble.ChatTextCursor = Cursors.IBeam;
                        meBubble.Dock = DockStyle.Bottom;
                        meBubble.MsgColor = Color.DodgerBlue;
                        meBubble.MsgTextColor = SystemColors.ControlLightLight;
                        meBubble.Padding = new Padding(0, 5, 0, 5);
                        meBubble.Size = new Size(768, 152);
                        meBubble.Status = MessageStatus.Custom;
                        meBubble.TabIndex = 2;
                        meBubble.Time = "11:44 PM";
                        meBubble.TimeColor = Color.White;
                        Common.b_image_me = new Bitmap(Common.b_image_me, new Size(65, 58));
                        meBubble.UserImage = Common.b_image_me;
                        panel4.Controls.Add(meBubble);
                    }
                    else
                    {
                        string folder = Path.GetDirectoryName(item.msg.user_info.face);
                        if (folder != null && !folder.Equals("default_man"))
                        {
                            string photo = Path.GetFileName(item.msg.user_info.face);
                            Common.b_image_user = (Bitmap)Bitmap.FromFile(Common.URL_IMAGE + item.msg.user_info.uid + photo);
                            // you
                            YouBubble youBubble = new YouBubble();
                            youBubble.AutoSize = true;
                            youBubble.BackColor = Color.Transparent;
                            youBubble.Body = item.msg.content.text + "\r\n";
                            youBubble.ChatImageCursor = Cursors.Default;
                            youBubble.ChatTextCursor = Cursors.IBeam;
                            youBubble.Dock = DockStyle.Bottom;
                            youBubble.MsgColor = Color.DodgerBlue;
                            youBubble.MsgTextColor = SystemColors.ControlLightLight;
                            youBubble.Padding = new Padding(0, 5, 0, 5);
                            youBubble.Size = new Size(768, 152);
                            youBubble.Status = MessageStatus.Custom;
                            youBubble.TabIndex = 2;
                            youBubble.Time = "11:44 PM";
                            youBubble.TimeColor = Color.White;
                            Common.b_image_user = new Bitmap(Common.b_image_user, new Size(65, 58));
                            youBubble.UserImage = Common.b_image_user;
                            panel4.Controls.Add(youBubble);
                        }
                    }
                }

                panel4.AutoScrollMinSize = new Size(0, panel4.Height);
                panel4.AutoScrollPosition = new Point(0, panel4.VerticalScroll.Maximum);
                panel4.ResumeLayout();
                this.PerformLayout();
            }
            typingBox1.Focus();
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

            if (!string.IsNullOrEmpty(e.Message))
            {
                SocketMesssageRespone res = new SocketMesssageRespone();
                res = JsonConvert.DeserializeObject<SocketMesssageRespone>(e.Message);

                if (res != null && res.action == "chatData" && res.data.list_id == Common.list_id)
                {
                    SetMessage(res);
                }
            }
        }

        private void WebSocket_Error(object sender, SuperSocket.ClientEngine.ErrorEventArgs e)
        {
            //MessageBox.Show("WebSocket error: " + e.Exception.Message);
        }

        private void WebSocket_Closed(object sender, EventArgs e)
        {
            websocket.Close();
        }
    }
}
