using VietChat.Services;

namespace VietChat
{
    public partial class Login : Form
    {
        /// <summary>
        /// API
        /// </summary>
        Logging logging = new Logging();

        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            logging.Signing(txt_user.Text, txt_pass.Text);
        }
    }
}
