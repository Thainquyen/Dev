using System.Drawing.Drawing2D;
using Shaping;
using VietChat;
using VietChat.Properties;

namespace chat
{
    public partial class UserGroup : UserControl
    {
        public UserGroup()
        {
            InitializeComponent();
        }

        public delegate void ProfileImageClick(object sender, EventArgs e);
        public delegate void UserTitleClick(object sender, EventArgs e);
        public delegate void UserStatusTextClick(object sender, EventArgs e);
        public delegate void UserStatusClick(object sender, EventArgs e);
        public delegate void Clicked(object sender, EventArgs e);

        public event ProfileImageClick OnProfileImageClick;
        public event UserTitleClick OnUserTitleClick;
        public event UserStatusTextClick OnUserStatusTextClick;
        public event UserStatusClick OnUserStatusClick;
        public event Clicked OnClick;

        public string Username
        {
            get { return lbUserNameGroup.Text; }
            set { lbUserNameGroup.Text = value; }
        }

        public bool SelectedUser
        {
            get { return cbxUserGroup.Checked; }
            set { cbxUserGroup.Checked = value; }
        }

        public string UserID
        {
            get { return lbUserID.Text; }
            set { lbUserID.Text = value; }
        }
        //public string StatusMessage
        //{
        //    //get { return label2.Text; }
        //    //set { label2.Text = value; }
        //}
        public Status UserStatus
        {
            get
            {
                return GetStatus();
            }
            set
            {
                CurrentStatus = value;
                SetStatus();
            }
        }
        public Image UserImage
        {
            get
            {
                return pbUserGroup.Image;
            }
            set
            {
                pbUserGroup.Image = value;
            }
        }

        public Cursor ProfileImageCursor
        {
            get
            {
                return pbUserGroup.Cursor;
            }
            set
            {
                pbUserGroup.Cursor = value;
            }
        }

        private Status CurrentStatus = Status.Online;
        private Status GetStatus()
        {
            return CurrentStatus;
        }
        private void SetStatus()
        {
            //switch (CurrentStatus)
            //{
            //    case Status.Online:
            //        {
            //            pictureBox2.Image = Resources.Online_32;
            //            break;
            //        }
            //    case Status.Away:
            //        {
            //            pictureBox2.Image = Resources.Away_32;
            //            break;
            //        }
            //    case Status.Offline:
            //        {
            //            pictureBox2.Image = Resources.offline_32;
            //            break;
            //        }
            //    default:
            //        {
            //            pictureBox2.Image = Resources.Online_32;
            //            break;
            //        }
            //}
        }
        private void Users_Load(object sender, EventArgs e)
        {

        }
        bool isPaddingSet = false;
        Label LeftIndicator = new Label();
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath gr = RoundedRectangle.Create(panel2.ClientRectangle, 22, RoundedRectangle.RectangleCorners.All);
            panel2.Region = new Region(gr);

            GraphicsPath gr1 = RoundedRectangle.Create(pbUserGroup.ClientRectangle, 22, RoundedRectangle.RectangleCorners.All);
            pbUserGroup.Region = new Region(gr1);

            LeftIndicator.BackColor = Color.FromArgb(80, 80, 80);
            LeftIndicator.Dock = DockStyle.Left;
            LeftIndicator.Width = 2;

            if (!isPaddingSet)
            {
                panel3.Controls.Add(LeftIndicator);
                isPaddingSet = true;
            }


            base.OnPaint(e);
        }

        private void Users_MouseEnter(object sender, EventArgs e)
        {
            LeftIndicator.BackColor = Color.NavajoWhite;
        }

        private void Users_MouseHover(object sender, EventArgs e)
        {
            //  BackColor = Color.Navy;
        }

        private void Users_MouseLeave(object sender, EventArgs e)
        {

            LeftIndicator.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (OnProfileImageClick != null)
            {
                OnProfileImageClick.Invoke(sender, e);
            }
            else
            {
                OnClick?.Invoke(this, EventArgs.Empty);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            if (OnUserTitleClick != null)
            {
                OnUserTitleClick.Invoke(sender, e);
            }
            else
            {
                OnClick?.Invoke(this, EventArgs.Empty);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (OnUserStatusTextClick != null)
            {
                OnUserStatusTextClick.Invoke(sender, e);
            }
            else
            {
                OnClick?.Invoke(this, EventArgs.Empty);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (OnUserStatusClick != null)
            {
                OnUserStatusClick.Invoke(sender, e);
            }
            else
            {
                OnClick?.Invoke(this, EventArgs.Empty);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Users_Click(object sender, EventArgs e)
        {
            // Click?.Invoke(sender, e);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            OnClick?.Invoke(this, EventArgs.Empty);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            OnClick?.Invoke(this, EventArgs.Empty);
        }

        private void cbxUserGroup_CheckedChanged(object sender, EventArgs e)
        {
            this.SelectedUser = cbxUserGroup.Checked;
            int userID = int.Parse(lbUserID.Text);
            if (this.SelectedUser)
            {
                Common.selectedUserID.Add(userID);
            }
            else
            {
                Common.selectedUserID.Remove(userID);
            }
        }
    }
}
