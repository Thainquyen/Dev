namespace VietChat
{
    partial class Login
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
            btn_login = new Button();
            btn_register = new Button();
            label6 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            lbl_Account = new Label();
            txt_pass = new TextBox();
            txt_user = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_login.BackColor = Color.FromArgb(35, 142, 250);
            btn_login.FlatAppearance.BorderColor = Color.Black;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("MS UI Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.ForeColor = Color.Transparent;
            btn_login.Location = new Point(104, 297);
            btn_login.Margin = new Padding(18, 3, 3, 3);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(164, 52);
            btn_login.TabIndex = 108;
            btn_login.TabStop = false;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_register
            // 
            btn_register.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_register.BackColor = Color.FromArgb(165, 255, 165);
            btn_register.FlatAppearance.BorderColor = Color.Black;
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.Font = new Font("MS UI Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_register.ForeColor = Color.Black;
            btn_register.Location = new Point(104, 378);
            btn_register.Margin = new Padding(18, 3, 3, 3);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(164, 52);
            btn_register.TabIndex = 109;
            btn_register.TabStop = false;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.Location = new Point(125, 22);
            label6.Name = "label6";
            label6.Size = new Size(110, 83);
            label6.TabIndex = 112;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbl_Account);
            panel1.Controls.Add(txt_pass);
            panel1.Controls.Add(txt_user);
            panel1.Location = new Point(12, 139);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 136);
            panel1.TabIndex = 113;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(61, 164, 140);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("MS UI Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 76);
            label1.Name = "label1";
            label1.Size = new Size(112, 35);
            label1.TabIndex = 115;
            label1.Text = "Password";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Account
            // 
            lbl_Account.BackColor = Color.FromArgb(61, 164, 140);
            lbl_Account.BorderStyle = BorderStyle.FixedSingle;
            lbl_Account.Font = new Font("MS UI Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Account.Location = new Point(31, 21);
            lbl_Account.Name = "lbl_Account";
            lbl_Account.Size = new Size(112, 35);
            lbl_Account.TabIndex = 114;
            lbl_Account.Text = "Account";
            lbl_Account.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pass.Location = new Point(149, 76);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(164, 35);
            txt_pass.TabIndex = 113;
            txt_pass.UseSystemPasswordChar = true;
            // 
            // txt_user
            // 
            txt_user.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_user.Location = new Point(149, 21);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(164, 35);
            txt_user.TabIndex = 112;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 481);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(btn_register);
            Controls.Add(btn_login);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public Button btn_login;
        public Button btn_register;
        private Label label6;
        private Panel panel1;
        private Label label1;
        private Label lbl_Account;
        private TextBox txt_pass;
        private TextBox txt_user;
    }
}