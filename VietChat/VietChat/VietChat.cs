namespace VietChat
{
    public partial class VietChat : Form
    {
        public VietChat()
        {
            InitializeComponent();
        }

        private void lbl_out_Click(object sender, EventArgs e)
        {
            Form form = new Login();
            form.Show();
            this.Hide();
        }

        private void VietChat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}