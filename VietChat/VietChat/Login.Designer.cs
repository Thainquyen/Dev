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
            txt_user = new TextBox();
            txt_pass = new TextBox();
            btn_login = new Button();
            btn_register = new Button();
            lbl_Account = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txt_user
            // 
            txt_user.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_user.Location = new Point(155, 111);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(164, 35);
            txt_user.TabIndex = 0;
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pass.Location = new Point(155, 166);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(164, 35);
            txt_pass.TabIndex = 1;
            txt_pass.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_login.BackColor = Color.FromArgb(35, 142, 250);
            btn_login.FlatAppearance.BorderColor = Color.Black;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("MS UI Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.ForeColor = Color.Transparent;
            btn_login.Location = new Point(101, 237);
            btn_login.Margin = new Padding(18, 3, 3, 3);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(164, 52);
            btn_login.TabIndex = 108;
            btn_login.TabStop = false;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            // 
            // btn_register
            // 
            btn_register.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_register.BackColor = Color.FromArgb(165, 255, 165);
            btn_register.FlatAppearance.BorderColor = Color.Black;
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.Font = new Font("MS UI Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_register.ForeColor = Color.Black;
            btn_register.Location = new Point(101, 318);
            btn_register.Margin = new Padding(18, 3, 3, 3);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(164, 52);
            btn_register.TabIndex = 109;
            btn_register.TabStop = false;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            // 
            // lbl_Account
            // 
            lbl_Account.BackColor = Color.FromArgb(61, 164, 140);
            lbl_Account.BorderStyle = BorderStyle.FixedSingle;
            lbl_Account.Font = new Font("MS UI Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Account.Location = new Point(37, 111);
            lbl_Account.Name = "lbl_Account";
            lbl_Account.Size = new Size(112, 35);
            lbl_Account.TabIndex = 110;
            lbl_Account.Text = "Account";
            lbl_Account.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(61, 164, 140);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("MS UI Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 166);
            label1.Name = "label1";
            label1.Size = new Size(112, 35);
            label1.TabIndex = 111;
            label1.Text = "Password";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 481);
            Controls.Add(label1);
            Controls.Add(lbl_Account);
            Controls.Add(btn_register);
            Controls.Add(btn_login);
            Controls.Add(txt_pass);
            Controls.Add(txt_user);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_user;
        private TextBox txt_pass;
        public Button btn_login;
        public Button btn_register;
        private Label lbl_Account;
        private Label label1;
    }
}