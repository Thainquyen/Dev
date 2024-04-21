namespace chat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            searchBox1 = new SearchBox();
            panel5 = new Panel();
            users1 = new Users();
            label3 = new Label();
            panel3 = new Panel();
            typingBox1 = new TypingBox();
            panel4 = new Panel();
            meBubble2 = new MeBubble();
            youBubble1 = new YouBubble();
            meBubble5 = new MeBubble();
            chatHeader1 = new ChatHeader();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1126, 24);
            panel1.TabIndex = 0;
            panel1.MouseDown += OnMouseDownMoveForm;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Dock = DockStyle.Right;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(1056, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 11);
            label2.Size = new Size(35, 24);
            label2.TabIndex = 1;
            label2.Text = "__";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Cursor = Cursors.Hand;
            label1.Dock = DockStyle.Right;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(1091, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 5);
            label1.Size = new Size(35, 24);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(searchBox1);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(3, 27);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(2, 0, 2, 5);
            panel2.Size = new Size(206, 700);
            panel2.TabIndex = 1;
            // 
            // searchBox1
            // 
            searchBox1.BackColor = Color.FromArgb(80, 80, 80);
            searchBox1.Dock = DockStyle.Bottom;
            searchBox1.FocusedColor = Color.WhiteSmoke;
            searchBox1.Location = new Point(2, 666);
            searchBox1.Margin = new Padding(4, 3, 4, 3);
            searchBox1.Name = "searchBox1";
            searchBox1.Padding = new Padding(5, 0, 5, 0);
            searchBox1.Size = new Size(202, 29);
            searchBox1.TabIndex = 2;
            searchBox1.TextColor = SystemColors.GradientActiveCaption;
            searchBox1.UnFocusedColor = SystemColors.GradientActiveCaption;
            searchBox1.Value = "Search...";
            // 
            // panel5
            // 
            panel5.Controls.Add(users1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(2, 42);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 5, 0, 10);
            panel5.Size = new Size(202, 578);
            panel5.TabIndex = 1;
            // 
            // users1
            // 
            users1.BackColor = Color.Transparent;
            users1.Cursor = Cursors.Hand;
            users1.Dock = DockStyle.Top;
            users1.Location = new Point(0, 5);
            users1.Margin = new Padding(0);
            users1.Name = "users1";
            users1.ProfileImageCursor = Cursors.Hand;
            users1.Size = new Size(202, 49);
            users1.StatusMessage = "Online";
            users1.TabIndex = 0;
            users1.UserImage = VietChat.Properties.Resources._2;
            users1.Username = "User 1";
            users1.UserStatus = Status.Online;
            users1.OnClick += OnUserClick;
            users1.Load += users1_Load;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(102, 102, 102);
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(2, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(5, 5, 0, 0);
            label3.Size = new Size(202, 42);
            label3.TabIndex = 0;
            label3.Text = "Recent";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Controls.Add(typingBox1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(209, 689);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5, 0, 5, 5);
            panel3.Size = new Size(920, 38);
            panel3.TabIndex = 3;
            // 
            // typingBox1
            // 
            typingBox1.BackColor = Color.FromArgb(102, 102, 102);
            typingBox1.Dock = DockStyle.Bottom;
            typingBox1.Location = new Point(5, 9);
            typingBox1.Margin = new Padding(4, 3, 4, 3);
            typingBox1.Name = "typingBox1";
            typingBox1.Size = new Size(910, 24);
            typingBox1.TabIndex = 0;
            typingBox1.Value = "Type here...";
            typingBox1.OnHitEnter += typingBox1_OnHitEnter;
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.AutoSize = true;
            panel4.Controls.Add(meBubble2);
            panel4.Controls.Add(youBubble1);
            panel4.Controls.Add(meBubble5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(209, 69);
            panel4.Name = "panel4";
            panel4.Size = new Size(920, 620);
            panel4.TabIndex = 4;
            // 
            // meBubble2
            // 
            meBubble2.AutoSize = true;
            meBubble2.BackColor = Color.Transparent;
            meBubble2.Body = " This is a sample text message. This is a sample text message. This is a sample text message. \r\n\r\nThis is a sample text message. \r\n";
            meBubble2.ChatImageCursor = Cursors.Default;
            meBubble2.ChatTextCursor = Cursors.IBeam;
            meBubble2.Dock = DockStyle.Bottom;
            meBubble2.Location = new Point(0, 335);
            meBubble2.Margin = new Padding(4, 3, 4, 3);
            meBubble2.MinimumSize = new Size(0, 95);
            meBubble2.MsgColor = Color.DodgerBlue;
            meBubble2.MsgTextColor = SystemColors.ControlLightLight;
            meBubble2.Name = "meBubble2";
            meBubble2.Padding = new Padding(0, 5, 0, 5);
            meBubble2.Size = new Size(920, 95);
            meBubble2.Status = MessageStatus.Custom;
            meBubble2.StatusImage = (Image)resources.GetObject("meBubble2.StatusImage");
            meBubble2.TabIndex = 2;
            meBubble2.Time = "11:44 PM";
            meBubble2.TimeColor = Color.White;
            meBubble2.UserImage = (Image)resources.GetObject("meBubble2.UserImage");
            // 
            // youBubble1
            // 
            youBubble1.BackColor = Color.Transparent;
            youBubble1.Body = " This is a sample text message. This is a sample text message. This is a sample text message. \n\nThis is a sample text message. ";
            youBubble1.ChatImageCursor = Cursors.Default;
            youBubble1.ChatTextCursor = Cursors.IBeam;
            youBubble1.Dock = DockStyle.Bottom;
            youBubble1.Location = new Point(0, 430);
            youBubble1.Margin = new Padding(4, 3, 4, 3);
            youBubble1.MinimumSize = new Size(0, 95);
            youBubble1.MsgColor = Color.FromArgb(244, 244, 244);
            youBubble1.MsgTextColor = SystemColors.ControlDarkDark;
            youBubble1.Name = "youBubble1";
            youBubble1.Padding = new Padding(0, 5, 0, 5);
            youBubble1.Size = new Size(920, 95);
            youBubble1.Status = MessageStatus.Custom;
            youBubble1.StatusImage = null;
            youBubble1.TabIndex = 1;
            youBubble1.Time = "11:46 PM";
            youBubble1.TimeColor = Color.White;
            youBubble1.UserImage = VietChat.Properties.Resources._2_32;
            // 
            // meBubble5
            // 
            meBubble5.AutoSize = true;
            meBubble5.BackColor = Color.Transparent;
            meBubble5.Body = " This is a sample text message. This is a sample text message. This is a sample text message. \r\n\r\nThis is a sample text message. \r\n";
            meBubble5.ChatImageCursor = Cursors.Default;
            meBubble5.ChatTextCursor = Cursors.IBeam;
            meBubble5.Dock = DockStyle.Bottom;
            meBubble5.Location = new Point(0, 525);
            meBubble5.Margin = new Padding(4, 3, 4, 3);
            meBubble5.MinimumSize = new Size(0, 95);
            meBubble5.MsgColor = Color.DodgerBlue;
            meBubble5.MsgTextColor = SystemColors.ControlLightLight;
            meBubble5.Name = "meBubble5";
            meBubble5.Padding = new Padding(0, 5, 0, 5);
            meBubble5.Size = new Size(920, 95);
            meBubble5.Status = MessageStatus.Custom;
            meBubble5.StatusImage = (Image)resources.GetObject("meBubble5.StatusImage");
            meBubble5.TabIndex = 5;
            meBubble5.Time = "11:52 PM";
            meBubble5.TimeColor = Color.White;
            meBubble5.UserImage = (Image)resources.GetObject("meBubble5.UserImage");
            // 
            // chatHeader1
            // 
            chatHeader1.BackColor = Color.FromArgb(102, 102, 102);
            chatHeader1.Dock = DockStyle.Top;
            chatHeader1.Location = new Point(209, 27);
            chatHeader1.Margin = new Padding(4, 3, 4, 3);
            chatHeader1.Name = "chatHeader1";
            chatHeader1.Padding = new Padding(0, 2, 0, 2);
            chatHeader1.Size = new Size(920, 42);
            chatHeader1.TabIndex = 2;
            chatHeader1.UserImage = VietChat.Properties.Resources._2_32;
            chatHeader1.UserStatusText = "Typing...";
            chatHeader1.UserTitle = "Kassimu Da.";
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(80, 80, 80);
            ClientSize = new Size(1132, 730);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(chatHeader1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Padding = new Padding(3);
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Panel panel1;
        private Panel panel2;
        private ChatHeader chatHeader1;
        private Panel panel3;
        private TypingBox typingBox1;
        private Panel panel4;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel panel5;
        private SearchBox searchBox1;
        private Users users1;
        private MeBubble meBubble2;
        private YouBubble youBubble1;
        private MeBubble meBubble5;
    }
}