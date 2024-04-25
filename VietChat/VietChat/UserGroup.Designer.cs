namespace chat
{
    partial class UserGroup
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
            lbUserNameGroup = new Label();
            panel3 = new Panel();
            lbUserID = new Label();
            panel2 = new Panel();
            pbUserGroup = new PictureBox();
            panel1 = new Panel();
            cbxUserGroup = new CheckBox();
            label3 = new Label();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUserGroup).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbUserNameGroup
            // 
            lbUserNameGroup.AutoSize = true;
            lbUserNameGroup.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbUserNameGroup.ForeColor = SystemColors.InactiveBorder;
            lbUserNameGroup.Location = new Point(88, 23);
            lbUserNameGroup.Margin = new Padding(5, 0, 5, 0);
            lbUserNameGroup.Name = "lbUserNameGroup";
            lbUserNameGroup.Size = new Size(125, 25);
            lbUserNameGroup.TabIndex = 2;
            lbUserNameGroup.Text = "User name";
            lbUserNameGroup.Click += label1_Click_1;
            lbUserNameGroup.MouseEnter += Users_MouseEnter;
            lbUserNameGroup.MouseLeave += Users_MouseLeave;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(123, 123, 123);
            panel3.Controls.Add(lbUserID);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(lbUserNameGroup);
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 0, 0, 4);
            panel3.Size = new Size(360, 81);
            panel3.TabIndex = 6;
            panel3.Click += panel3_Click;
            panel3.Paint += panel3_Paint;
            panel3.MouseEnter += Users_MouseEnter;
            panel3.MouseLeave += Users_MouseLeave;
            // 
            // lbUserID
            // 
            lbUserID.AutoSize = true;
            lbUserID.Location = new Point(243, 50);
            lbUserID.Name = "lbUserID";
            lbUserID.Size = new Size(70, 25);
            lbUserID.TabIndex = 7;
            lbUserID.Text = "User ID";
            lbUserID.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Azure;
            panel2.Controls.Add(pbUserGroup);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(5, 6, 5, 6);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(2);
            panel2.Size = new Size(78, 77);
            panel2.TabIndex = 6;
            panel2.Click += label1_Click;
            // 
            // pbUserGroup
            // 
            pbUserGroup.BackColor = Color.FromArgb(123, 123, 123);
            pbUserGroup.Dock = DockStyle.Fill;
            pbUserGroup.Image = VietChat.Properties.Resources.icons8_User_32;
            pbUserGroup.Location = new Point(2, 2);
            pbUserGroup.Margin = new Padding(5, 6, 5, 6);
            pbUserGroup.Name = "pbUserGroup";
            pbUserGroup.Size = new Size(74, 73);
            pbUserGroup.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUserGroup.TabIndex = 0;
            pbUserGroup.TabStop = false;
            pbUserGroup.Click += pictureBox1_Click_1;
            pbUserGroup.MouseEnter += Users_MouseEnter;
            pbUserGroup.MouseLeave += Users_MouseLeave;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbxUserGroup);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(299, 0);
            panel1.Margin = new Padding(5, 6, 5, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(61, 77);
            panel1.TabIndex = 5;
            panel1.Click += panel1_Click;
            panel1.MouseEnter += Users_MouseEnter;
            panel1.MouseLeave += Users_MouseLeave;
            // 
            // cbxUserGroup
            // 
            cbxUserGroup.AutoSize = true;
            cbxUserGroup.Location = new Point(20, 27);
            cbxUserGroup.Name = "cbxUserGroup";
            cbxUserGroup.Size = new Size(22, 21);
            cbxUserGroup.TabIndex = 0;
            cbxUserGroup.UseVisualStyleBackColor = true;
            cbxUserGroup.CheckedChanged += cbxUserGroup_CheckedChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = Color.FromArgb(80, 80, 80);
            label3.Location = new Point(0, 77);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 0, 0, 5);
            label3.Size = new Size(360, 4);
            label3.TabIndex = 8;
            // 
            // UserGroup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label3);
            Controls.Add(panel3);
            Cursor = Cursors.Hand;
            Margin = new Padding(0);
            Name = "UserGroup";
            Size = new Size(360, 81);
            Load += Users_Load;
            MouseEnter += Users_MouseEnter;
            MouseLeave += Users_MouseLeave;
            MouseHover += Users_MouseHover;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbUserGroup).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lbUserNameGroup;
        private Panel panel3;
        private Panel panel2;
        private Label label3;
        private PictureBox pbUserGroup;
        private Panel panel1;
        private CheckBox cbxUserGroup;
        private Label lbUserID;
    }
}
