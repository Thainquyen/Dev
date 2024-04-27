namespace VietChat
{
    partial class FriendApplyDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FriendApplyDialog));
            lbl_photo_me = new Label();
            label2 = new Label();
            label3 = new Label();
            lbl_username = new Label();
            lbl_nickname = new Label();
            lbl_name = new Label();
            btnAddFriend = new Button();
            btn_close = new Button();
            SuspendLayout();
            // 
            // lbl_photo_me
            // 
            lbl_photo_me.Image = (Image)resources.GetObject("lbl_photo_me.Image");
            lbl_photo_me.Location = new Point(24, 44);
            lbl_photo_me.Name = "lbl_photo_me";
            lbl_photo_me.Size = new Size(129, 110);
            lbl_photo_me.TabIndex = 6;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(167, 119);
            label2.Name = "label2";
            label2.Size = new Size(113, 37);
            label2.TabIndex = 124;
            label2.Text = "User name:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(167, 82);
            label3.Name = "label3";
            label3.Size = new Size(113, 37);
            label3.TabIndex = 123;
            label3.Text = "Nick name:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_username
            // 
            lbl_username.BackColor = SystemColors.ButtonHighlight;
            lbl_username.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_username.Location = new Point(280, 119);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(177, 37);
            lbl_username.TabIndex = 122;
            lbl_username.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_nickname
            // 
            lbl_nickname.BackColor = SystemColors.ButtonHighlight;
            lbl_nickname.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nickname.Location = new Point(280, 82);
            lbl_nickname.Name = "lbl_nickname";
            lbl_nickname.Size = new Size(177, 37);
            lbl_nickname.TabIndex = 121;
            lbl_nickname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_name
            // 
            lbl_name.BackColor = SystemColors.ButtonHighlight;
            lbl_name.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_name.Location = new Point(167, 44);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(291, 37);
            lbl_name.TabIndex = 120;
            lbl_name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAddFriend
            // 
            btnAddFriend.BackColor = Color.FromArgb(128, 255, 128);
            btnAddFriend.Location = new Point(43, 200);
            btnAddFriend.Name = "btnAddFriend";
            btnAddFriend.Size = new Size(173, 33);
            btnAddFriend.TabIndex = 125;
            btnAddFriend.Text = "Thêm Bạn";
            btnAddFriend.UseVisualStyleBackColor = false;
            btnAddFriend.Click += btnAddFriend_Click;
            // 
            // btn_close
            // 
            btn_close.BackColor = SystemColors.ControlLight;
            btn_close.Location = new Point(270, 200);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(170, 33);
            btn_close.TabIndex = 126;
            btn_close.Text = "Đóng";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // FriendApplyDialog
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(474, 261);
            Controls.Add(btn_close);
            Controls.Add(btnAddFriend);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lbl_username);
            Controls.Add(lbl_nickname);
            Controls.Add(lbl_name);
            Controls.Add(lbl_photo_me);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FriendApplyDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin bạn bè";
            Load += FriendApplyDialog_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_photo_me;
        private Label label2;
        private Label label3;
        private Label lbl_username;
        private Label lbl_nickname;
        private Label lbl_name;
        private Button btnAddFriend;
        private Button btn_close;
    }
}