﻿using System.ComponentModel;
using System.Drawing.Drawing2D;
using Shaping;
using System.Drawing.Design;
using VietChat.Properties;

namespace chat
{
    public partial class YouBubble : UserControl
    {
        public YouBubble()
        {
            InitializeComponent();
        }

       

        [Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string Body
        {
            get
            {
                return label1.Text.Replace(Environment.NewLine,"\n");
            }
            set
            {
                label1.Text = value.Replace("\n", Environment.NewLine);
            }
        }

        public Image UserImage
        {
            get
            {
                return pictureBox1.Image;
            }
            set
            {
                pictureBox1.Image = value;
            }
        }

        public Cursor ChatImageCursor
        {
            get
            {
                return pictureBox1.Cursor;
            }
            set
            {
                pictureBox1.Cursor = value;
            }
        }

        public Cursor ChatTextCursor
        {
            get
            {
                return label1.Cursor;
            }
            set
            {
                label1.Cursor = value;
            }
        }

        public Color MsgColor
        {
            get
            {
                return label1.BackColor;
            }
            set
            {
                label1.BackColor = value;
            }
        }

        public Color MsgTextColor
        {
            get
            {
                return label1.ForeColor;
            }
            set
            {
                label1.ForeColor = value;
            }
        }

        public Color TimeColor
        {
            get
            {
                return time.ForeColor;
            }
            set
            {
                time.ForeColor = value;
            }
        }

        public string Time
        {
            get
            {
                return time.Text;

            }
            set
            {
                time.Text = value;
                SetTimeWidth();
            }
        }
        private void SetTimeWidth()
        {
            time.Width = TextRenderer.MeasureText(time.Text, time.Font).Width;
        }
        private MessageStatus _CurrentMessageStatus = MessageStatus.Sent;

        private Image msgStatusImage = null;
        public Image StatusImage
        {
            get
            {
                return msgStatus.Image;
            }
            set
            {
                msgStatusImage = value;
                _CurrentMessageStatus = MessageStatus.Custom;
                SetMsgStatus();
            }
        }



        public MessageStatus Status
        {
            get
            {
                return GetMsgStatus();
            }
            set
            {
                _CurrentMessageStatus = value;
                SetMsgStatus();
            }
        }

        private MessageStatus GetMsgStatus()
        {
            return _CurrentMessageStatus;
        }

        private void SetMsgStatus()
        {
            switch (_CurrentMessageStatus)
            {
                case MessageStatus.Sent:
                    {
                        msgStatus.Image = Resources.MsgSent_32;
                        break;
                    }
                case MessageStatus.Sending:
                    {
                        msgStatus.Image = Resources.MsgSending_32;
                        break;
                    }
                case MessageStatus.Delivered:
                    {
                        msgStatus.Image = Resources.MsgDelivered_32;
                        break;
                    }
                case MessageStatus.Read:
                    {
                        msgStatus.Image = Resources.MsgRead_32;
                        break;
                    }
                case MessageStatus.Error:
                    {
                        msgStatus.Image = Resources.MsgError_32;
                        break;
                    }
                case MessageStatus.None:
                    {
                        msgStatus.Image = null;
                        break;
                    }
                case MessageStatus.Custom:
                    {
                        msgStatus.Image = msgStatusImage;
                        break;
                    }
            }
        }


        Panel messageBottom = new Panel();
        Label time = new Label();
        PictureBox msgStatus = new PictureBox();
        bool isAdded = false;

        private void YouBubble_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            label1.MaximumSize = new Size((this.Width - panel1.Width - 21)/2, 0);
            label1.Width = this.Width - panel1.Width - 21;

            //if (label1.Height < panel2.Height + 1)
            //{
            //    this.MinimumSize = new Size(0, panel2.Height + 11);
            //    this.Height = panel2.Height + 11;
            //}
            //else
            //{
            //    this.MinimumSize = new Size(0, label1.Height + 20);
            //    this.Height = label1.Height + 20;
            //}
            if (label1.Height < panel2.Height + 1)
            {
                this.MinimumSize = new Size(0, panel2.Height + 11 + 15);
                this.Height = panel2.Height + 11 + 15;
            }
            else
            {
                this.MinimumSize = new Size(0, label1.Height + 10 + 15);
                this.Height = label1.Height + 10 + 15;
            }

            if (!isAdded)
            {
                messageBottom.Size = new Size(0, 15);
                messageBottom.Dock = DockStyle.Bottom;
                messageBottom.Padding = new Padding(47, 0, 0, 0);
                messageBottom.BackColor = Color.Transparent;
                messageBottom.ForeColor = Color.White;

                time.Dock = DockStyle.Left;
                SetTimeWidth();

                msgStatus.Dock = DockStyle.Left;
                msgStatus.SizeMode = PictureBoxSizeMode.StretchImage;
                msgStatus.Size = new Size(15, 15);

               
                messageBottom.Controls.Add(msgStatus);
                messageBottom.Controls.Add(time);


                this.Controls.Add(messageBottom);
                SetMsgStatus();
                isAdded = true;
            }

            GraphicsPath gr = RoundedRectangle.Create(panel2.ClientRectangle, 16, RoundedRectangle.RectangleCorners.All);
            panel2.Region = new Region(gr);

            GraphicsPath gr1 = RoundedRectangle.Create(pictureBox1.ClientRectangle, 16, RoundedRectangle.RectangleCorners.All);
            pictureBox1.Region = new Region(gr1);

            GraphicsPath path = RoundedRectangle.Create(label1.ClientRectangle, 5, RoundedRectangle.RectangleCorners.All);
            label1.Region = new Region(path);

            base.OnPaint(e);
        }

        public delegate void ChatImageClick(object sender, EventArgs e);
        public delegate void ChatTextClick(object sender, EventArgs e);

        public event ChatImageClick OnChatImageClick;
        public event ChatTextClick OnChatTextClick;

        private void label1_Click(object sender, EventArgs e)
        {
            if (OnChatTextClick != null)
            {
                OnChatTextClick.Invoke(sender, e);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (OnChatImageClick != null)
            {
                OnChatImageClick.Invoke(sender, e);
            }
        }
    }

   
}
