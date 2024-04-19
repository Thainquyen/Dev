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
            label3 = new Label();
            lbl_out = new Label();
            label1 = new Label();
            lbl_bb = new Label();
            panel2 = new Panel();
            pnl_bb = new Panel();
            pic_photo = new PictureBox();
            lbl_name = new Label();
            panel5 = new Panel();
            label7 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            label6 = new Label();
            lbl_ketban = new Label();
            panel3 = new Panel();
            textBox1 = new TextBox();
            pnl_add = new Panel();
            lbl_msg = new Label();
            txt_input = new TextBox();
            btn_no = new Button();
            btn_yes = new Button();
            pnl_group = new Panel();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnl_bb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_photo).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            pnl_add.SuspendLayout();
            pnl_group.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbl_out);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbl_bb);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(81, 676);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(12, 8);
            label3.Name = "label3";
            label3.Size = new Size(55, 49);
            label3.TabIndex = 5;
            // 
            // lbl_out
            // 
            lbl_out.BackColor = Color.FromArgb(255, 192, 128);
            lbl_out.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_out.Location = new Point(3, 625);
            lbl_out.Name = "lbl_out";
            lbl_out.Size = new Size(70, 43);
            lbl_out.TabIndex = 4;
            lbl_out.Text = "Đăng xuất";
            lbl_out.TextAlign = ContentAlignment.MiddleCenter;
            lbl_out.Click += lbl_out_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 139);
            label1.Name = "label1";
            label1.Size = new Size(73, 30);
            label1.TabIndex = 3;
            label1.Text = "Nhóm";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_bb
            // 
            lbl_bb.BackColor = SystemColors.ActiveCaption;
            lbl_bb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_bb.Location = new Point(3, 77);
            lbl_bb.Name = "lbl_bb";
            lbl_bb.Size = new Size(73, 34);
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
            panel2.Location = new Point(83, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(227, 676);
            panel2.TabIndex = 5;
            // 
            // pnl_bb
            // 
            pnl_bb.BorderStyle = BorderStyle.FixedSingle;
            pnl_bb.Controls.Add(pic_photo);
            pnl_bb.Controls.Add(lbl_name);
            pnl_bb.Location = new Point(6, 189);
            pnl_bb.Name = "pnl_bb";
            pnl_bb.Size = new Size(214, 477);
            pnl_bb.TabIndex = 9;
            // 
            // pic_photo
            // 
            pic_photo.Image = (Image)resources.GetObject("pic_photo.Image");
            pic_photo.Location = new Point(3, 3);
            pic_photo.Name = "pic_photo";
            pic_photo.Size = new Size(57, 48);
            pic_photo.TabIndex = 7;
            pic_photo.TabStop = false;
            // 
            // lbl_name
            // 
            lbl_name.BackColor = Color.White;
            lbl_name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_name.Location = new Point(66, 9);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(139, 38);
            lbl_name.TabIndex = 5;
            lbl_name.Text = "Name";
            lbl_name.TextAlign = ContentAlignment.MiddleCenter;
            lbl_name.Click += lbl_name_Click;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(-1, 123);
            panel5.Name = "panel5";
            panel5.Size = new Size(230, 62);
            panel5.TabIndex = 8;
            // 
            // label7
            // 
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.Location = new Point(7, 9);
            label7.Name = "label7";
            label7.Size = new Size(44, 43);
            label7.TabIndex = 4;
            // 
            // label4
            // 
            label4.BackColor = Color.Bisque;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(57, 17);
            label4.Name = "label4";
            label4.Size = new Size(156, 29);
            label4.TabIndex = 2;
            label4.Text = "Danh sách nhóm";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(lbl_ketban);
            panel4.Location = new Point(-1, 62);
            panel4.Name = "panel4";
            panel4.Size = new Size(230, 62);
            panel4.TabIndex = 7;
            // 
            // label6
            // 
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.Location = new Point(2, 9);
            label6.Name = "label6";
            label6.Size = new Size(54, 43);
            label6.TabIndex = 3;
            // 
            // lbl_ketban
            // 
            lbl_ketban.BackColor = SystemColors.Info;
            lbl_ketban.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ketban.Location = new Point(58, 17);
            lbl_ketban.Name = "lbl_ketban";
            lbl_ketban.Size = new Size(82, 29);
            lbl_ketban.TabIndex = 2;
            lbl_ketban.Text = "Kết bạn";
            lbl_ketban.TextAlign = ContentAlignment.MiddleCenter;
            lbl_ketban.Click += lbl_ketban_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(-1, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 64);
            panel3.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(7, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 32);
            textBox1.TabIndex = 4;
            textBox1.Text = "Tìm kiếm";
            // 
            // pnl_add
            // 
            pnl_add.BackColor = Color.FromArgb(153, 255, 153);
            pnl_add.BorderStyle = BorderStyle.FixedSingle;
            pnl_add.Controls.Add(lbl_msg);
            pnl_add.Controls.Add(txt_input);
            pnl_add.Controls.Add(btn_no);
            pnl_add.Controls.Add(btn_yes);
            pnl_add.Location = new Point(406, 137);
            pnl_add.Name = "pnl_add";
            pnl_add.Size = new Size(558, 259);
            pnl_add.TabIndex = 149;
            pnl_add.Visible = false;
            // 
            // lbl_msg
            // 
            lbl_msg.BackColor = Color.FromArgb(153, 255, 153);
            lbl_msg.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_msg.Location = new Point(73, 53);
            lbl_msg.Name = "lbl_msg";
            lbl_msg.Size = new Size(460, 29);
            lbl_msg.TabIndex = 106;
            lbl_msg.Text = "Please input account";
            lbl_msg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_input
            // 
            txt_input.Font = new Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            txt_input.Location = new Point(73, 85);
            txt_input.Name = "txt_input";
            txt_input.Size = new Size(460, 32);
            txt_input.TabIndex = 105;
            // 
            // btn_no
            // 
            btn_no.BackColor = Color.FromArgb(215, 220, 224);
            btn_no.FlatStyle = FlatStyle.Flat;
            btn_no.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_no.ForeColor = Color.Black;
            btn_no.Location = new Point(312, 167);
            btn_no.Name = "btn_no";
            btn_no.Size = new Size(154, 53);
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
            btn_yes.Location = new Point(137, 167);
            btn_yes.Name = "btn_yes";
            btn_yes.Size = new Size(134, 53);
            btn_yes.TabIndex = 104;
            btn_yes.TabStop = false;
            btn_yes.Text = "Kết bạn";
            btn_yes.UseVisualStyleBackColor = false;
            btn_yes.Click += btn_yes_Click;
            // 
            // pnl_group
            // 
            pnl_group.BackColor = Color.FromArgb(139, 232, 232);
            pnl_group.BorderStyle = BorderStyle.FixedSingle;
            pnl_group.Controls.Add(button1);
            pnl_group.Location = new Point(309, 3);
            pnl_group.Name = "pnl_group";
            pnl_group.Size = new Size(307, 676);
            pnl_group.TabIndex = 150;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(195, 633);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 106;
            button1.TabStop = false;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // VietChat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 691);
            Controls.Add(pnl_group);
            Controls.Add(pnl_add);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "VietChat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VietChat";
            FormClosed += VietChat_FormClosed;
            Load += VietChat_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            pnl_bb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_photo).EndInit();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pnl_add.ResumeLayout(false);
            pnl_add.PerformLayout();
            pnl_group.ResumeLayout(false);
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
        private Label label3;
        private Panel panel5;
        private Label label4;
        private Panel panel4;
        private Label label6;
        private Label label7;
        private Panel pnl_add;
        private Button btn_no;
        private Button btn_yes;
        private Label lbl_msg;
        private TextBox txt_input;
        private Panel pnl_group;
        private Button button1;
        private Panel pnl_bb;
        private Label lbl_name;
        private PictureBox pic_photo;
        private System.Windows.Forms.Timer timer1;
    }
}