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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VietChat));
            panel1 = new Panel();
            label3 = new Label();
            lbl_out = new Label();
            label1 = new Label();
            lbl_bb = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            label7 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            label6 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
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
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(83, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(227, 676);
            panel2.TabIndex = 5;
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
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
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
            // label5
            // 
            label5.BackColor = SystemColors.Info;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(58, 17);
            label5.Name = "label5";
            label5.Size = new Size(82, 29);
            label5.TabIndex = 2;
            label5.Text = "Kết bạn";
            label5.TextAlign = ContentAlignment.MiddleCenter;
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
            // VietChat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 691);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "VietChat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VietChat";
            FormClosed += VietChat_FormClosed;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lbl_bb;
        private Label lbl_out;
        private Panel panel2;
        private TextBox textBox1;
        private Label label5;
        private Panel panel3;
        private Label label3;
        private Panel panel5;
        private Label label4;
        private Panel panel4;
        private Label label6;
        private Label label7;
    }
}