namespace VietChat
{
    partial class VietChat
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VietChat));
            panel1 = new Panel();
            lbl_photo_me = new Label();
            lbl_out = new Label();
            label1 = new Label();
            lbl_bb = new Label();
            panel2 = new Panel();
            pnl_bb = new Panel();
            panel5 = new Panel();
            lbCreateGroup = new Label();
            panel4 = new Panel();
            label6 = new Label();
            lbl_ketban = new Label();
            panel3 = new Panel();
            textBox1 = new TextBox();
            pnl_add = new Panel();
            pnl_details = new Panel();
            btn_huy = new Button();
            btn_gui = new Button();
            lbl_text = new Label();
            txt_text = new TextBox();
            lbl_username = new Label();
            lbl_nickname = new Label();
            lbl_name = new Label();
            lbl_photo_detail = new Label();
            btn_yes = new Button();
            btn_no = new Button();
            lbl_photosearch = new Label();
            lbl_searchuser = new Label();
            lbl_msg = new Label();
            txt_input = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            pnl_add.SuspendLayout();
            pnl_details.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lbl_photo_me);
            panel1.Controls.Add(lbl_out);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbl_bb);
            panel1.Location = new Point(4, 5);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(115, 1125);
            panel1.TabIndex = 0;
            // 
            // lbl_photo_me
            // 
            lbl_photo_me.Image = (Image)resources.GetObject("lbl_photo_me.Image");
            lbl_photo_me.Location = new Point(12, 8);
            lbl_photo_me.Name = "lbl_photo_me";
            lbl_photo_me.Size = new Size(55, 49);
            lbl_photo_me.TabIndex = 5;
            // 
            // lbl_out
            // 
            lbl_out.BackColor = Color.FromArgb(255, 192, 128);
            lbl_out.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_out.Location = new Point(4, 1042);
            lbl_out.Margin = new Padding(4, 0, 4, 0);
            lbl_out.Name = "lbl_out";
            lbl_out.Size = new Size(100, 72);
            lbl_out.TabIndex = 4;
            lbl_out.Text = "Đăng xuất";
            lbl_out.TextAlign = ContentAlignment.MiddleCenter;
            lbl_out.Click += lbl_out_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(4, 195);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 50);
            label1.TabIndex = 3;
            label1.Text = "Nhóm";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // lbl_bb
            // 
            lbl_bb.BackColor = SystemColors.ActiveCaption;
            lbl_bb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_bb.Location = new Point(4, 128);
            lbl_bb.Margin = new Padding(4, 0, 4, 0);
            lbl_bb.Name = "lbl_bb";
            lbl_bb.Size = new Size(104, 57);
            lbl_bb.TabIndex = 2;
            lbl_bb.Text = "Bạn bè";
            lbl_bb.TextAlign = ContentAlignment.MiddleCenter;
            lbl_bb.Click += lbl_bb_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pnl_bb);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(119, 5);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 1125);
            panel2.TabIndex = 5;
            // 
            // pnl_bb
            // 
            pnl_bb.AutoScroll = true;
            pnl_bb.BorderStyle = BorderStyle.FixedSingle;
            pnl_bb.Location = new Point(9, 315);
            pnl_bb.Margin = new Padding(4, 5, 4, 5);
            pnl_bb.Name = "pnl_bb";
            pnl_bb.Size = new Size(305, 794);
            pnl_bb.TabIndex = 9;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label7);
            panel5.Controls.Add(lbCreateGroup);
            panel5.Location = new Point(-1, 205);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(328, 102);
            panel5.TabIndex = 8;
            // 
            // lbCreateGroup
            // 
            lbCreateGroup.BackColor = Color.Bisque;
            lbCreateGroup.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCreateGroup.Location = new Point(81, 28);
            lbCreateGroup.Margin = new Padding(4, 0, 4, 0);
            lbCreateGroup.Name = "lbCreateGroup";
            lbCreateGroup.Size = new Size(223, 48);
            lbCreateGroup.TabIndex = 2;
            lbCreateGroup.Text = "Tạo Nhóm";
            lbCreateGroup.TextAlign = ContentAlignment.MiddleCenter;
            lbCreateGroup.Click += lbCreateGroup_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(lbl_ketban);
            panel4.Location = new Point(-1, 103);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(328, 102);
            panel4.TabIndex = 7;
            // 
            // label6
            // 
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.Location = new Point(3, 15);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(77, 72);
            label6.TabIndex = 3;
            // 
            // lbl_ketban
            // 
            lbl_ketban.BackColor = SystemColors.Info;
            lbl_ketban.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ketban.Location = new Point(83, 28);
            lbl_ketban.Margin = new Padding(4, 0, 4, 0);
            lbl_ketban.Name = "lbl_ketban";
            lbl_ketban.Size = new Size(117, 48);
            lbl_ketban.TabIndex = 2;
            lbl_ketban.Text = "Kết bạn";
            lbl_ketban.TextAlign = ContentAlignment.MiddleCenter;
            lbl_ketban.Click += lbl_ketban_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(-1, -2);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(328, 105);
            panel3.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(10, 27);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 44);
            textBox1.TabIndex = 4;
            textBox1.Text = "Tìm kiếm";
            // 
            // pnl_add
            // 
            pnl_add.BackColor = Color.FromArgb(224, 224, 224);
            pnl_add.BorderStyle = BorderStyle.FixedSingle;
            pnl_add.Controls.Add(pnl_details);
            pnl_add.Controls.Add(lbl_photosearch);
            pnl_add.Controls.Add(lbl_searchuser);
            pnl_add.Controls.Add(lbl_msg);
            pnl_add.Controls.Add(txt_input);
            pnl_add.Location = new Point(319, 10);
            pnl_add.Name = "pnl_add";
            pnl_add.Size = new Size(785, 669);
            pnl_add.Controls.Add(btn_no);
            pnl_add.Controls.Add(btn_yes);
            pnl_add.Location = new Point(484, 33);
            pnl_add.Margin = new Padding(4, 5, 4, 5);
            pnl_add.Name = "pnl_add";
            pnl_add.Size = new Size(1092, 992);
            pnl_add.TabIndex = 149;
            pnl_add.Visible = false;
            // 
            // pnl_details
            // 
            pnl_details.Controls.Add(btn_huy);
            pnl_details.Controls.Add(btn_gui);
            pnl_details.Controls.Add(lbl_text);
            pnl_details.Controls.Add(txt_text);
            pnl_details.Controls.Add(lbl_username);
            pnl_details.Controls.Add(lbl_nickname);
            pnl_details.Controls.Add(lbl_name);
            pnl_details.Controls.Add(lbl_photo_detail);
            pnl_details.Controls.Add(btn_yes);
            pnl_details.Controls.Add(btn_no);
            pnl_details.Location = new Point(22, 246);
            pnl_details.Name = "pnl_details";
            pnl_details.Size = new Size(729, 355);
            pnl_details.TabIndex = 110;
            // 
            // btn_huy
            // 
            btn_huy.BackColor = Color.FromArgb(215, 220, 224);
            btn_huy.FlatStyle = FlatStyle.Flat;
            btn_huy.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_huy.ForeColor = Color.Black;
            btn_huy.Location = new Point(411, 209);
            btn_huy.Name = "btn_huy";
            btn_huy.Size = new Size(91, 39);
            btn_huy.TabIndex = 117;
            btn_huy.TabStop = false;
            btn_huy.Text = "Quay lại";
            btn_huy.UseVisualStyleBackColor = false;
            btn_huy.Click += btn_huy_Click;
            // 
            // btn_gui
            // 
            btn_gui.BackColor = Color.LimeGreen;
            btn_gui.FlatStyle = FlatStyle.Flat;
            btn_gui.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_gui.ForeColor = Color.Transparent;
            btn_gui.Location = new Point(236, 209);
            btn_gui.Name = "btn_gui";
            btn_gui.Size = new Size(110, 39);
            btn_gui.TabIndex = 116;
            btn_gui.TabStop = false;
            btn_gui.Text = "Gửi";
            btn_gui.UseVisualStyleBackColor = false;
            // 
            // lbl_text
            // 
            lbl_text.BackColor = Color.White;
            lbl_text.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_text.Location = new Point(112, 129);
            lbl_text.Name = "lbl_text";
            lbl_text.Size = new Size(504, 29);
            lbl_text.TabIndex = 115;
            lbl_text.Text = "Bạn cần gửi đơn đăng ký xác minh và đợi bên kia xác nhận";
            lbl_text.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_text
            // 
            txt_text.Font = new Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            txt_text.Location = new Point(112, 161);
            txt_text.Name = "txt_text";
            txt_text.Size = new Size(504, 32);
            txt_text.TabIndex = 114;
            // 
            // lbl_username
            // 
            lbl_username.BackColor = SystemColors.ButtonHighlight;
            lbl_username.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_username.Location = new Point(103, 62);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(197, 29);
            lbl_username.TabIndex = 113;
            lbl_username.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_nickname
            // 
            lbl_nickname.BackColor = SystemColors.ButtonHighlight;
            lbl_nickname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nickname.Location = new Point(103, 33);
            lbl_nickname.Name = "lbl_nickname";
            lbl_nickname.Size = new Size(197, 29);
            lbl_nickname.TabIndex = 112;
            lbl_nickname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_name
            // 
            lbl_name.BackColor = SystemColors.ButtonHighlight;
            lbl_name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_name.Location = new Point(103, 4);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(197, 29);
            lbl_name.TabIndex = 111;
            lbl_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_photo_detail
            // 
            lbl_photo_detail.Image = (Image)resources.GetObject("lbl_photo_detail.Image");
            lbl_photo_detail.Location = new Point(4, 4);
            lbl_photo_detail.Name = "lbl_photo_detail";
            lbl_photo_detail.Size = new Size(91, 82);
            lbl_photo_detail.TabIndex = 110;
            // 
            // btn_yes
            // 
            btn_yes.BackColor = Color.FromArgb(35, 142, 250);
            btn_yes.FlatStyle = FlatStyle.Flat;
            btn_yes.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_yes.ForeColor = Color.Transparent;
            btn_yes.Location = new Point(236, 261);
            btn_yes.Name = "btn_yes";
            btn_yes.Size = new Size(134, 53);
            btn_yes.TabIndex = 104;
            btn_yes.TabStop = false;
            btn_yes.Text = "Kết bạn";
            btn_yes.UseVisualStyleBackColor = false;
            btn_yes.Click += btn_yes_Click;
            // 
            // btn_no
            // 
            btn_no.BackColor = Color.FromArgb(215, 220, 224);
            btn_no.FlatStyle = FlatStyle.Flat;
            btn_no.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_no.ForeColor = Color.Black;
            btn_no.Location = new Point(411, 261);
            btn_no.Name = "btn_no";
            btn_no.Size = new Size(154, 53);
            btn_no.TabIndex = 104;
            btn_no.TabStop = false;
            btn_no.Text = "Quay lại";
            btn_no.UseVisualStyleBackColor = false;
            btn_no.Click += btn_no_Click;
            // 
            // lbl_photosearch
            // 
            lbl_photosearch.Image = (Image)resources.GetObject("lbl_photosearch.Image");
            lbl_photosearch.Location = new Point(140, 124);
            lbl_photosearch.Location = new Point(260, 207);
            lbl_photosearch.Margin = new Padding(4, 0, 4, 0);
            lbl_photosearch.Name = "lbl_photosearch";
            lbl_photosearch.Size = new Size(79, 82);
            lbl_photosearch.TabIndex = 108;
            // 
            // lbl_searchuser
            // 
            lbl_searchuser.BackColor = SystemColors.ButtonHighlight;
            lbl_searchuser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_searchuser.Location = new Point(189, 124);
            lbl_searchuser.Name = "lbl_searchuser";
            lbl_searchuser.Size = new Size(453, 49);
            lbl_searchuser.Location = new Point(330, 207);
            lbl_searchuser.Margin = new Padding(4, 0, 4, 0);
            lbl_searchuser.Name = "lbl_searchuser";
            lbl_searchuser.Size = new Size(587, 82);
            lbl_searchuser.TabIndex = 107;
            lbl_searchuser.TextAlign = ContentAlignment.MiddleCenter;
            lbl_searchuser.Click += lbl_searchuser_Click;
            // 
            // lbl_msg
            // 
            lbl_msg.BackColor = Color.White;
            lbl_msg.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_msg.Location = new Point(138, 53);
            lbl_msg.Name = "lbl_msg";
            lbl_msg.Size = new Size(504, 29);
            lbl_msg.Location = new Point(260, 88);
            lbl_msg.Margin = new Padding(4, 0, 4, 0);
            lbl_msg.Name = "lbl_msg";
            lbl_msg.Size = new Size(657, 48);
            lbl_msg.TabIndex = 106;
            lbl_msg.Text = "Nhập tên người dùng\\email\\điện thoại di động của bạn bè";
            lbl_msg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_input
            // 
            txt_input.Font = new Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            txt_input.Location = new Point(138, 85);
            txt_input.Name = "txt_input";
            txt_input.Size = new Size(504, 32);
            txt_input.TabIndex = 105;
            txt_input.TextChanged += txt_input_TextChanged;
            // 
            txt_input.Location = new Point(260, 142);
            txt_input.Margin = new Padding(4, 5, 4, 5);
            txt_input.Name = "txt_input";
            txt_input.Size = new Size(655, 44);
            txt_input.TabIndex = 105;
            txt_input.TextChanged += txt_input_TextChanged;
            // 
            // btn_no
            // 
            btn_no.BackColor = Color.FromArgb(215, 220, 224);
            btn_no.FlatStyle = FlatStyle.Flat;
            btn_no.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_no.ForeColor = Color.Black;
            btn_no.Location = new Point(580, 540);
            btn_no.Margin = new Padding(4, 5, 4, 5);
            btn_no.Name = "btn_no";
            btn_no.Size = new Size(220, 88);
            btn_no.TabIndex = 104;
            btn_no.TabStop = false;
            btn_no.Text = "Cancel";
            btn_no.UseVisualStyleBackColor = false;
            btn_no.Click += btn_no_Click;
            // 
            // btn_yes
            // 
            btn_yes.BackColor = Color.FromArgb(35, 142, 250);
            btn_yes.FlatStyle = FlatStyle.Flat;
            btn_yes.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_yes.ForeColor = Color.Transparent;
            btn_yes.Location = new Point(330, 540);
            btn_yes.Margin = new Padding(4, 5, 4, 5);
            btn_yes.Name = "btn_yes";
            btn_yes.Size = new Size(191, 88);
            btn_yes.TabIndex = 104;
            btn_yes.TabStop = false;
            btn_yes.Text = "Kết bạn";
            btn_yes.UseVisualStyleBackColor = false;
            btn_yes.Click += btn_yes_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // label7
            // 
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.Location = new Point(10, 15);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(63, 72);
            label7.TabIndex = 4;
            // 
            // VietChat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1594, 1152);
            Controls.Add(pnl_add);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "VietChat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VietChat";
            FormClosed += VietChat_FormClosed;
            Load += VietChat_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pnl_add.ResumeLayout(false);
            pnl_add.PerformLayout();
            pnl_details.ResumeLayout(false);
            pnl_details.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lbl_bb;
        private Label lbl_out;
        private Panel panel2;
        private TextBox textBox1;
        private Label lbl_ketban;
        private Panel panel3;
        private Label lbl_photo_me;
        private Panel panel5;
        private Label lbCreateGroup;
        private Panel panel4;
        private Label label6;
        private Panel pnl_add;
        private Button btn_no;
        private Button btn_yes;
        private Label lbl_msg;
        private TextBox txt_input;
        private Panel pnl_bb;
        private System.Windows.Forms.Timer timer1;
        private Label lbl_photosearch;
        private Label lbl_searchuser;
        private Panel pnl_details;
        private Label lbl_username;
        private Label lbl_nickname;
        private Label lbl_name;
        private Label lbl_photo_detail;
        private Label lbl_text;
        private TextBox txt_text;
        private Button btn_gui;
        private Button btn_huy;
        private Label label7;
    }
}