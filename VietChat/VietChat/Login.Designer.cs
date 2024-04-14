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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btn_login = new Button();
            btn_register = new Button();
            lbl_icon = new Label();
            pnl_login = new Panel();
            label1 = new Label();
            lbl_Account = new Label();
            txt_pass = new TextBox();
            txt_user = new TextBox();
            pnl_register = new Panel();
            lbl_error2 = new Label();
            btn_register2 = new Button();
            lbl_confirm = new Label();
            txt_confirm = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_pass_register = new TextBox();
            txt_user_register = new TextBox();
            lbl_error = new Label();
            pnl_login.SuspendLayout();
            pnl_register.SuspendLayout();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_login.BackColor = Color.FromArgb(35, 142, 250);
            btn_login.FlatAppearance.BorderColor = Color.Black;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.ForeColor = Color.Transparent;
            btn_login.Location = new Point(104, 327);
            btn_login.Margin = new Padding(18, 3, 3, 3);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(164, 52);
            btn_login.TabIndex = 4;
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
            btn_register.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_register.ForeColor = Color.Black;
            btn_register.Location = new Point(104, 398);
            btn_register.Margin = new Padding(18, 3, 3, 3);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(164, 52);
            btn_register.TabIndex = 109;
            btn_register.TabStop = false;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // lbl_icon
            // 
            lbl_icon.Image = (Image)resources.GetObject("lbl_icon.Image");
            lbl_icon.Location = new Point(125, 22);
            lbl_icon.Name = "lbl_icon";
            lbl_icon.Size = new Size(110, 83);
            lbl_icon.TabIndex = 112;
            // 
            // pnl_login
            // 
            pnl_login.BorderStyle = BorderStyle.FixedSingle;
            pnl_login.Controls.Add(label1);
            pnl_login.Controls.Add(lbl_Account);
            pnl_login.Controls.Add(txt_pass);
            pnl_login.Controls.Add(txt_user);
            pnl_login.Location = new Point(12, 139);
            pnl_login.Name = "pnl_login";
            pnl_login.Size = new Size(335, 136);
            pnl_login.TabIndex = 113;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(61, 164, 140);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 76);
            label1.Name = "label1";
            label1.Size = new Size(112, 32);
            label1.TabIndex = 115;
            label1.Text = "Password";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Account
            // 
            lbl_Account.BackColor = Color.FromArgb(61, 164, 140);
            lbl_Account.BorderStyle = BorderStyle.FixedSingle;
            lbl_Account.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Account.Location = new Point(31, 21);
            lbl_Account.Name = "lbl_Account";
            lbl_Account.Size = new Size(112, 32);
            lbl_Account.TabIndex = 114;
            lbl_Account.Text = "Account";
            lbl_Account.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_pass
            // 
            txt_pass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_pass.BorderStyle = BorderStyle.FixedSingle;
            txt_pass.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pass.Location = new Point(149, 76);
            txt_pass.MaxLength = 200;
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(164, 32);
            txt_pass.TabIndex = 2;
            txt_pass.UseSystemPasswordChar = true;
            // 
            // txt_user
            // 
            txt_user.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_user.BorderStyle = BorderStyle.FixedSingle;
            txt_user.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_user.Location = new Point(149, 21);
            txt_user.MaxLength = 200;
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(164, 32);
            txt_user.TabIndex = 1;
            // 
            // pnl_register
            // 
            pnl_register.BorderStyle = BorderStyle.FixedSingle;
            pnl_register.Controls.Add(lbl_error2);
            pnl_register.Controls.Add(btn_register2);
            pnl_register.Controls.Add(lbl_confirm);
            pnl_register.Controls.Add(txt_confirm);
            pnl_register.Controls.Add(label2);
            pnl_register.Controls.Add(label3);
            pnl_register.Controls.Add(txt_pass_register);
            pnl_register.Controls.Add(txt_user_register);
            pnl_register.Location = new Point(12, 131);
            pnl_register.Name = "pnl_register";
            pnl_register.Size = new Size(338, 319);
            pnl_register.TabIndex = 116;
            // 
            // lbl_error2
            // 
            lbl_error2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_error2.Location = new Point(7, 178);
            lbl_error2.Name = "lbl_error2";
            lbl_error2.Size = new Size(262, 33);
            lbl_error2.TabIndex = 119;
            // 
            // btn_register2
            // 
            btn_register2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_register2.BackColor = Color.FromArgb(165, 255, 165);
            btn_register2.FlatAppearance.BorderColor = Color.Black;
            btn_register2.FlatStyle = FlatStyle.Flat;
            btn_register2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_register2.ForeColor = Color.Black;
            btn_register2.Location = new Point(91, 235);
            btn_register2.Margin = new Padding(18, 3, 3, 3);
            btn_register2.Name = "btn_register2";
            btn_register2.Size = new Size(164, 52);
            btn_register2.TabIndex = 118;
            btn_register2.TabStop = false;
            btn_register2.Text = "Register";
            btn_register2.UseVisualStyleBackColor = false;
            btn_register2.Click += btn_register2_Click;
            // 
            // lbl_confirm
            // 
            lbl_confirm.BackColor = Color.FromArgb(61, 164, 140);
            lbl_confirm.BorderStyle = BorderStyle.FixedSingle;
            lbl_confirm.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_confirm.Location = new Point(7, 130);
            lbl_confirm.Name = "lbl_confirm";
            lbl_confirm.Size = new Size(136, 32);
            lbl_confirm.TabIndex = 117;
            lbl_confirm.Text = "Confirm pass";
            lbl_confirm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_confirm
            // 
            txt_confirm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_confirm.BorderStyle = BorderStyle.FixedSingle;
            txt_confirm.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_confirm.Location = new Point(149, 130);
            txt_confirm.MaxLength = 200;
            txt_confirm.Name = "txt_confirm";
            txt_confirm.Size = new Size(184, 32);
            txt_confirm.TabIndex = 7;
            txt_confirm.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(61, 164, 140);
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(7, 76);
            label2.Name = "label2";
            label2.Size = new Size(136, 32);
            label2.TabIndex = 115;
            label2.Text = "Password";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(61, 164, 140);
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(7, 21);
            label3.Name = "label3";
            label3.Size = new Size(136, 32);
            label3.TabIndex = 114;
            label3.Text = "User";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_pass_register
            // 
            txt_pass_register.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_pass_register.BorderStyle = BorderStyle.FixedSingle;
            txt_pass_register.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pass_register.Location = new Point(149, 76);
            txt_pass_register.MaxLength = 200;
            txt_pass_register.Name = "txt_pass_register";
            txt_pass_register.Size = new Size(184, 32);
            txt_pass_register.TabIndex = 6;
            txt_pass_register.UseSystemPasswordChar = true;
            // 
            // txt_user_register
            // 
            txt_user_register.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_user_register.BorderStyle = BorderStyle.FixedSingle;
            txt_user_register.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_user_register.Location = new Point(149, 21);
            txt_user_register.MaxLength = 200;
            txt_user_register.Name = "txt_user_register";
            txt_user_register.Size = new Size(184, 32);
            txt_user_register.TabIndex = 5;
            // 
            // lbl_error
            // 
            lbl_error.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_error.Location = new Point(12, 278);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(216, 34);
            lbl_error.TabIndex = 114;
            lbl_error.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 198);
            ClientSize = new Size(359, 481);
            Controls.Add(pnl_register);
            Controls.Add(pnl_login);
            Controls.Add(lbl_error);
            Controls.Add(lbl_icon);
            Controls.Add(btn_register);
            Controls.Add(btn_login);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            pnl_login.ResumeLayout(false);
            pnl_login.PerformLayout();
            pnl_register.ResumeLayout(false);
            pnl_register.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public Button btn_login;
        public Button btn_register;
        private Label lbl_icon;
        private Panel pnl_login;
        private Label label1;
        private Label lbl_Account;
        private TextBox txt_pass;
        private TextBox txt_user;
        private Label lbl_error;
        private Panel pnl_register;
        private Label lbl_confirm;
        private TextBox txt_confirm;
        private Label label2;
        private Label label3;
        private TextBox txt_pass_register;
        private TextBox txt_user_register;
        public Button btn_register2;
        private Label lbl_error2;
    }
}