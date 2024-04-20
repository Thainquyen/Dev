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
            users7 = new Users();
            users8 = new Users();
            users9 = new Users();
            users10 = new Users();
            users11 = new Users();
            users6 = new Users();
            users5 = new Users();
            users4 = new Users();
            users3 = new Users();
            users2 = new Users();
            users1 = new Users();
            label3 = new Label();
            panel3 = new Panel();
            typingBox1 = new TypingBox();
            panel4 = new Panel();
            meBubble2 = new MeBubble();
            youBubble1 = new YouBubble();
            meBubble1 = new MeBubble();
            meBubble3 = new MeBubble();
            meBubble4 = new MeBubble();
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
            panel1.Size = new Size(974, 24);
            panel1.TabIndex = 0;
            panel1.MouseDown += OnMouseDownMoveForm;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Dock = DockStyle.Right;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(904, 0);
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
            label1.Location = new Point(939, 0);
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
            panel2.Size = new Size(206, 674);
            panel2.TabIndex = 1;
            // 
            // searchBox1
            // 
            searchBox1.BackColor = Color.FromArgb(80, 80, 80);
            searchBox1.Dock = DockStyle.Bottom;
            searchBox1.FocusedColor = Color.WhiteSmoke;
            searchBox1.Location = new Point(2, 640);
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
            panel5.Controls.Add(users7);
            panel5.Controls.Add(users8);
            panel5.Controls.Add(users9);
            panel5.Controls.Add(users10);
            panel5.Controls.Add(users11);
            panel5.Controls.Add(users6);
            panel5.Controls.Add(users5);
            panel5.Controls.Add(users4);
            panel5.Controls.Add(users3);
            panel5.Controls.Add(users2);
            panel5.Controls.Add(users1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(2, 42);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 5, 0, 10);
            panel5.Size = new Size(202, 578);
            panel5.TabIndex = 1;
            // 
            // users7
            // 
            users7.BackColor = Color.Transparent;
            users7.Cursor = Cursors.Hand;
            users7.Dock = DockStyle.Top;
            users7.Location = new Point(0, 495);
            users7.Margin = new Padding(0);
            users7.Name = "users7";
            users7.ProfileImageCursor = Cursors.Hand;
            users7.Size = new Size(202, 49);
            users7.StatusMessage = "Online";
            users7.TabIndex = 10;
            users7.UserImage = VietChat.Properties.Resources._2_32;
            users7.Username = "Kasimu Da.";
            users7.UserStatus = Status.Online;
            // 
            // users8
            // 
            users8.BackColor = Color.Transparent;
            users8.Cursor = Cursors.Hand;
            users8.Dock = DockStyle.Top;
            users8.Location = new Point(0, 446);
            users8.Margin = new Padding(0);
            users8.Name = "users8";
            users8.ProfileImageCursor = Cursors.Hand;
            users8.Size = new Size(202, 49);
            users8.StatusMessage = "Offline";
            users8.TabIndex = 9;
            users8.UserImage = VietChat.Properties.Resources._1_32;
            users8.Username = "Sacdiyo Xir.";
            users8.UserStatus = Status.Offline;
            // 
            // users9
            // 
            users9.BackColor = Color.Transparent;
            users9.Cursor = Cursors.Hand;
            users9.Dock = DockStyle.Top;
            users9.Location = new Point(0, 397);
            users9.Margin = new Padding(0);
            users9.Name = "users9";
            users9.ProfileImageCursor = Cursors.Hand;
            users9.Size = new Size(202, 49);
            users9.StatusMessage = "Away";
            users9.TabIndex = 8;
            users9.UserImage = VietChat.Properties.Resources._3_32;
            users9.Username = "Isma Ali";
            users9.UserStatus = Status.Away;
            // 
            // users10
            // 
            users10.BackColor = Color.Transparent;
            users10.Cursor = Cursors.Hand;
            users10.Dock = DockStyle.Top;
            users10.Location = new Point(0, 348);
            users10.Margin = new Padding(0);
            users10.Name = "users10";
            users10.ProfileImageCursor = Cursors.Hand;
            users10.Size = new Size(202, 49);
            users10.StatusMessage = "Away";
            users10.TabIndex = 7;
            users10.UserImage = (Image)resources.GetObject("users10.UserImage");
            users10.Username = "Baba BE.";
            users10.UserStatus = Status.Away;
            // 
            // users11
            // 
            users11.BackColor = Color.Transparent;
            users11.Cursor = Cursors.Hand;
            users11.Dock = DockStyle.Top;
            users11.Location = new Point(0, 299);
            users11.Margin = new Padding(0);
            users11.Name = "users11";
            users11.ProfileImageCursor = Cursors.Hand;
            users11.Size = new Size(202, 49);
            users11.StatusMessage = "Online";
            users11.TabIndex = 6;
            users11.UserImage = VietChat.Properties.Resources._2_32;
            users11.Username = "Kasimu Da.";
            users11.UserStatus = Status.Online;
            // 
            // users6
            // 
            users6.BackColor = Color.Transparent;
            users6.Cursor = Cursors.Hand;
            users6.Dock = DockStyle.Top;
            users6.Location = new Point(0, 250);
            users6.Margin = new Padding(0);
            users6.Name = "users6";
            users6.ProfileImageCursor = Cursors.Hand;
            users6.Size = new Size(202, 49);
            users6.StatusMessage = "Offline";
            users6.TabIndex = 5;
            users6.UserImage = VietChat.Properties.Resources._2;
            users6.Username = "Tusbaxle A.";
            users6.UserStatus = Status.Offline;
            users6.OnClick += OnUserClick;
            // 
            // users5
            // 
            users5.BackColor = Color.Transparent;
            users5.Cursor = Cursors.Hand;
            users5.Dock = DockStyle.Top;
            users5.Location = new Point(0, 201);
            users5.Margin = new Padding(0);
            users5.Name = "users5";
            users5.ProfileImageCursor = Cursors.Hand;
            users5.Size = new Size(202, 49);
            users5.StatusMessage = "Offline";
            users5.TabIndex = 4;
            users5.UserImage = VietChat.Properties.Resources._1_32;
            users5.Username = "Sacdiyo Xir.";
            users5.UserStatus = Status.Offline;
            users5.OnClick += OnUserClick;
            // 
            // users4
            // 
            users4.BackColor = Color.Transparent;
            users4.Cursor = Cursors.Hand;
            users4.Dock = DockStyle.Top;
            users4.Location = new Point(0, 152);
            users4.Margin = new Padding(0);
            users4.Name = "users4";
            users4.ProfileImageCursor = Cursors.Hand;
            users4.Size = new Size(202, 49);
            users4.StatusMessage = "Away";
            users4.TabIndex = 3;
            users4.UserImage = VietChat.Properties.Resources._3_32;
            users4.Username = "Isma Ali";
            users4.UserStatus = Status.Away;
            users4.OnClick += OnUserClick;
            // 
            // users3
            // 
            users3.BackColor = Color.Transparent;
            users3.Cursor = Cursors.Hand;
            users3.Dock = DockStyle.Top;
            users3.Location = new Point(0, 103);
            users3.Margin = new Padding(0);
            users3.Name = "users3";
            users3.ProfileImageCursor = Cursors.Hand;
            users3.Size = new Size(202, 49);
            users3.StatusMessage = "Away";
            users3.TabIndex = 2;
            users3.UserImage = (Image)resources.GetObject("users3.UserImage");
            users3.Username = "Baba BE.";
            users3.UserStatus = Status.Away;
            users3.OnClick += OnUserClick;
            users3.Load += users3_Load;
            // 
            // users2
            // 
            users2.BackColor = Color.Transparent;
            users2.Cursor = Cursors.Hand;
            users2.Dock = DockStyle.Top;
            users2.Location = new Point(0, 54);
            users2.Margin = new Padding(0);
            users2.Name = "users2";
            users2.ProfileImageCursor = Cursors.Hand;
            users2.Size = new Size(202, 49);
            users2.StatusMessage = "Online";
            users2.TabIndex = 1;
            users2.UserImage = VietChat.Properties.Resources._2_32;
            users2.Username = "Kasimu Da.";
            users2.UserStatus = Status.Online;
            users2.OnClick += OnUserClick;
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
            users1.UserImage = null;
            users1.Username = "";
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
            panel3.Location = new Point(209, 663);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5, 0, 5, 5);
            panel3.Size = new Size(768, 38);
            panel3.TabIndex = 3;
            // 
            // typingBox1
            // 
            typingBox1.BackColor = Color.FromArgb(102, 102, 102);
            typingBox1.Dock = DockStyle.Bottom;
            typingBox1.Location = new Point(5, 9);
            typingBox1.Margin = new Padding(4, 3, 4, 3);
            typingBox1.Name = "typingBox1";
            typingBox1.Size = new Size(758, 24);
            typingBox1.TabIndex = 0;
            typingBox1.Value = "Type here...";
            typingBox1.OnHitEnter += typingBox1_OnHitEnter;
            // 
            // panel4
            // 
            panel4.Controls.Add(meBubble2);
            panel4.Controls.Add(youBubble1);
            panel4.Controls.Add(meBubble1);
            panel4.Controls.Add(meBubble3);
            panel4.Controls.Add(meBubble4);
            panel4.Controls.Add(meBubble5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(209, 69);
            panel4.Name = "panel4";
            panel4.Size = new Size(768, 594);
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
            meBubble2.Location = new Point(0, 24);
            meBubble2.Margin = new Padding(4, 3, 4, 3);
            meBubble2.MinimumSize = new Size(0, 95);
            meBubble2.MsgColor = Color.DodgerBlue;
            meBubble2.MsgTextColor = SystemColors.ControlLightLight;
            meBubble2.Name = "meBubble2";
            meBubble2.Padding = new Padding(0, 5, 0, 5);
            meBubble2.Size = new Size(768, 95);
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
            youBubble1.Location = new Point(0, 119);
            youBubble1.Margin = new Padding(4, 3, 4, 3);
            youBubble1.MinimumSize = new Size(0, 95);
            youBubble1.MsgColor = Color.FromArgb(244, 244, 244);
            youBubble1.MsgTextColor = SystemColors.ControlDarkDark;
            youBubble1.Name = "youBubble1";
            youBubble1.Padding = new Padding(0, 5, 0, 5);
            youBubble1.Size = new Size(768, 95);
            youBubble1.Status = MessageStatus.Custom;
            youBubble1.StatusImage = null;
            youBubble1.TabIndex = 1;
            youBubble1.Time = "11:46 PM";
            youBubble1.TimeColor = Color.White;
            youBubble1.UserImage = VietChat.Properties.Resources._2_32;
            // 
            // meBubble1
            // 
            meBubble1.AutoSize = true;
            meBubble1.BackColor = Color.Transparent;
            meBubble1.Body = " This is a sample text message. This is a sample text message. This is a sample text message. \r\n\r\nThis is a sample text message. \r\n";
            meBubble1.ChatImageCursor = Cursors.Default;
            meBubble1.ChatTextCursor = Cursors.IBeam;
            meBubble1.Dock = DockStyle.Bottom;
            meBubble1.Location = new Point(0, 214);
            meBubble1.Margin = new Padding(4, 3, 4, 3);
            meBubble1.MinimumSize = new Size(0, 95);
            meBubble1.MsgColor = Color.DodgerBlue;
            meBubble1.MsgTextColor = SystemColors.ControlLightLight;
            meBubble1.Name = "meBubble1";
            meBubble1.Padding = new Padding(0, 5, 0, 5);
            meBubble1.Size = new Size(768, 95);
            meBubble1.Status = MessageStatus.Custom;
            meBubble1.StatusImage = (Image)resources.GetObject("meBubble1.StatusImage");
            meBubble1.TabIndex = 0;
            meBubble1.Time = "11:50 PM";
            meBubble1.TimeColor = Color.White;
            meBubble1.UserImage = (Image)resources.GetObject("meBubble1.UserImage");
            // 
            // meBubble3
            // 
            meBubble3.AutoSize = true;
            meBubble3.BackColor = Color.Transparent;
            meBubble3.Body = " This is a sample text message. This is a sample text message. This is a sample text message. \r\n\r\nThis is a sample text message. \r\n";
            meBubble3.ChatImageCursor = Cursors.Default;
            meBubble3.ChatTextCursor = Cursors.IBeam;
            meBubble3.Dock = DockStyle.Bottom;
            meBubble3.Location = new Point(0, 309);
            meBubble3.Margin = new Padding(4, 3, 4, 3);
            meBubble3.MinimumSize = new Size(0, 95);
            meBubble3.MsgColor = Color.DodgerBlue;
            meBubble3.MsgTextColor = SystemColors.ControlLightLight;
            meBubble3.Name = "meBubble3";
            meBubble3.Padding = new Padding(0, 5, 0, 5);
            meBubble3.Size = new Size(768, 95);
            meBubble3.Status = MessageStatus.Custom;
            meBubble3.StatusImage = (Image)resources.GetObject("meBubble3.StatusImage");
            meBubble3.TabIndex = 3;
            meBubble3.Time = "11:52 PM";
            meBubble3.TimeColor = Color.White;
            meBubble3.UserImage = (Image)resources.GetObject("meBubble3.UserImage");
            // 
            // meBubble4
            // 
            meBubble4.AutoSize = true;
            meBubble4.BackColor = Color.Transparent;
            meBubble4.Body = " This is a sample text message. This is a sample text message. This is a sample text message. \r\n\r\nThis is a sample text message. \r\n";
            meBubble4.ChatImageCursor = Cursors.Default;
            meBubble4.ChatTextCursor = Cursors.IBeam;
            meBubble4.Dock = DockStyle.Bottom;
            meBubble4.Location = new Point(0, 404);
            meBubble4.Margin = new Padding(4, 3, 4, 3);
            meBubble4.MinimumSize = new Size(0, 95);
            meBubble4.MsgColor = Color.DodgerBlue;
            meBubble4.MsgTextColor = SystemColors.ControlLightLight;
            meBubble4.Name = "meBubble4";
            meBubble4.Padding = new Padding(0, 5, 0, 5);
            meBubble4.Size = new Size(768, 95);
            meBubble4.Status = MessageStatus.Custom;
            meBubble4.StatusImage = (Image)resources.GetObject("meBubble4.StatusImage");
            meBubble4.TabIndex = 4;
            meBubble4.Time = "11:52 PM";
            meBubble4.TimeColor = Color.White;
            meBubble4.UserImage = (Image)resources.GetObject("meBubble4.UserImage");
            // 
            // meBubble5
            // 
            meBubble5.AutoSize = true;
            meBubble5.BackColor = Color.Transparent;
            meBubble5.Body = " This is a sample text message. This is a sample text message. This is a sample text message. \r\n\r\nThis is a sample text message. \r\n";
            meBubble5.ChatImageCursor = Cursors.Default;
            meBubble5.ChatTextCursor = Cursors.IBeam;
            meBubble5.Dock = DockStyle.Bottom;
            meBubble5.Location = new Point(0, 499);
            meBubble5.Margin = new Padding(4, 3, 4, 3);
            meBubble5.MinimumSize = new Size(0, 95);
            meBubble5.MsgColor = Color.DodgerBlue;
            meBubble5.MsgTextColor = SystemColors.ControlLightLight;
            meBubble5.Name = "meBubble5";
            meBubble5.Padding = new Padding(0, 5, 0, 5);
            meBubble5.Size = new Size(768, 95);
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
            chatHeader1.Size = new Size(768, 42);
            chatHeader1.TabIndex = 2;
            chatHeader1.UserImage = VietChat.Properties.Resources._2_32;
            chatHeader1.UserStatusText = "Typing...";
            chatHeader1.UserTitle = "Kassimu Da.";
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(80, 80, 80);
            ClientSize = new Size(980, 704);
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
        private Users users6;
        private Users users5;
        private Users users4;
        private Users users3;
        private Users users2;
        private Users users1;
        private MeBubble meBubble2;
        private YouBubble youBubble1;
        private MeBubble meBubble1;
        private MeBubble meBubble3;
        private MeBubble meBubble4;
        private MeBubble meBubble5;
        private Users users7;
        private Users users8;
        private Users users9;
        private Users users10;
        private Users users11;
    }
}