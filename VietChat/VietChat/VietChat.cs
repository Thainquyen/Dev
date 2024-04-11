namespace VietChat
{
    public partial class VietChat : Form
    {
        public VietChat()
        {
            InitializeComponent();
        }

        private void VietChat_Load(object sender, EventArgs e)
        {

        }

        private void VietChat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}