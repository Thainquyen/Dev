namespace VietChat
{
    partial class UpdateProfile
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
            lblNewFriend = new Label();
            label1 = new Label();
            txt_input = new TextBox();
            lbl_open = new Label();
            lbl_avatar = new Label();
            btn_yes = new Button();
            SuspendLayout();
            // 
            // lblNewFriend
            // 
            lblNewFriend.BackColor = SystemColors.ControlLight;
            lblNewFriend.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNewFriend.Location = new Point(68, 102);
            lblNewFriend.Name = "lblNewFriend";
            lblNewFriend.Size = new Size(105, 29);
            lblNewFriend.TabIndex = 5;
            lblNewFriend.Text = "Avatar";
            lblNewFriend.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(68, 170);
            label1.Name = "label1";
            label1.Size = new Size(105, 29);
            label1.TabIndex = 6;
            label1.Text = "Nick name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_input
            // 
            txt_input.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_input.Location = new Point(189, 167);
            txt_input.Name = "txt_input";
            txt_input.Size = new Size(504, 29);
            txt_input.TabIndex = 106;
            // 
            // lbl_open
            // 
            lbl_open.BackColor = SystemColors.ActiveCaption;
            lbl_open.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_open.Location = new Point(189, 102);
            lbl_open.Name = "lbl_open";
            lbl_open.Size = new Size(105, 29);
            lbl_open.TabIndex = 107;
            lbl_open.Text = "Chọn file";
            lbl_open.TextAlign = ContentAlignment.MiddleCenter;
            lbl_open.Click += lbl_open_Click;
            // 
            // lbl_avatar
            // 
            lbl_avatar.Location = new Point(322, 87);
            lbl_avatar.Margin = new Padding(2, 0, 2, 0);
            lbl_avatar.Name = "lbl_avatar";
            lbl_avatar.Size = new Size(65, 58);
            lbl_avatar.TabIndex = 108;
            // 
            // btn_yes
            // 
            btn_yes.BackColor = Color.FromArgb(35, 142, 250);
            btn_yes.FlatStyle = FlatStyle.Flat;
            btn_yes.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_yes.ForeColor = Color.Transparent;
            btn_yes.Location = new Point(340, 234);
            btn_yes.Name = "btn_yes";
            btn_yes.Size = new Size(134, 53);
            btn_yes.TabIndex = 109;
            btn_yes.TabStop = false;
            btn_yes.Text = "Tiếp theo";
            btn_yes.UseVisualStyleBackColor = false;
            btn_yes.Click += btn_yes_Click;
            // 
            // UpdateProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 421);
            Controls.Add(btn_yes);
            Controls.Add(lbl_avatar);
            Controls.Add(lbl_open);
            Controls.Add(txt_input);
            Controls.Add(label1);
            Controls.Add(lblNewFriend);
            Name = "UpdateProfile";
            Text = "Cập nhật thông tin";
            Load += UpdateProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNewFriend;
        private Label label1;
        private TextBox txt_input;
        private Label lbl_open;
        private Label lbl_avatar;
        private Button btn_yes;
    }
}