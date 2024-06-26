﻿using VietChat.Services;

namespace VietChat
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
        {
            txt_user.Focus();
            pnl_register.Visible = false;
            pnl_register.BringToFront();
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_user.Text.Trim()))
            {
                lbl_error.Text = "Account is empty";
                lbl_error.ForeColor = Color.Red;
                txt_user.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txt_pass.Text.Trim()))
            {
                lbl_error.Text = "Password is empty";
                lbl_error.ForeColor = Color.Red;
                txt_pass.Focus();
                return;
            }
            else
            {
                lbl_error.Text = "";
            }
            Logging logging = new Logging();
            await logging.Signing(txt_user.Text, txt_pass.Text);

            if (Common.error_flag > 0)
            {
                txt_user.Focus();
                txt_pass.Clear();
                lbl_error.Text = "Error login";
            }
            if (Common.error_flag == 0)
            {
                Form form = new FVietChat();
                form.Show();
                this.Hide();
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            pnl_register.Visible = true;
        }

        private async void btn_register2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_user_register.Text.Trim()))
            {
                lbl_error2.Text = "Account is empty";
                lbl_error2.ForeColor = Color.Red;
                txt_user_register.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txt_pass_register.Text.Trim()))
            {
                lbl_error2.Text = "Password is empty";
                lbl_error2.ForeColor = Color.Red;
                txt_pass_register.Focus();
                return;
            }
            else if (!txt_pass_register.Text.Trim().Equals(txt_confirm.Text.Trim()))
            {
                lbl_error2.Text = "Confirm password is false";
                lbl_error2.ForeColor = Color.Red;
                txt_confirm.Focus();
                return;
            }
            Register register = new Register();
            await register.Registering(txt_user_register.Text, txt_pass_register.Text);
            // 
            if (Common.error_flag == 0)
            {
                Logging logging = new Logging();
                await logging.Signing(txt_user_register.Text, txt_pass_register.Text);

                pnl_register.Visible = false;
                Form updateProfile = new UpdateProfile();
                updateProfile.Show();
                this.Hide();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            pnl_register.Visible = false;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
