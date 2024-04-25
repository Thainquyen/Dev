namespace VietChat
{
    partial class Group
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
            lbSelectUsers = new Label();
            btnAddGroup = new Button();
            btnCancelAddGroup = new Button();
            tbUserlist = new TableLayoutPanel();
            SuspendLayout();
            // 
            // lbSelectUsers
            // 
            lbSelectUsers.AutoSize = true;
            lbSelectUsers.ForeColor = SystemColors.ControlLightLight;
            lbSelectUsers.Location = new Point(145, 47);
            lbSelectUsers.Name = "lbSelectUsers";
            lbSelectUsers.Size = new Size(270, 25);
            lbSelectUsers.TabIndex = 0;
            lbSelectUsers.Text = "Vui lòng chọn bạn để tạo nhóm!";
            // 
            // btnAddGroup
            // 
            btnAddGroup.BackColor = SystemColors.GradientActiveCaption;
            btnAddGroup.Location = new Point(99, 468);
            btnAddGroup.Name = "btnAddGroup";
            btnAddGroup.Size = new Size(141, 41);
            btnAddGroup.TabIndex = 2;
            btnAddGroup.Text = "Thêm Nhóm";
            btnAddGroup.UseVisualStyleBackColor = false;
            btnAddGroup.Click += btnAddGroup_Click;
            // 
            // btnCancelAddGroup
            // 
            btnCancelAddGroup.BackColor = SystemColors.ControlDark;
            btnCancelAddGroup.Location = new Point(303, 468);
            btnCancelAddGroup.Name = "btnCancelAddGroup";
            btnCancelAddGroup.Size = new Size(141, 41);
            btnCancelAddGroup.TabIndex = 3;
            btnCancelAddGroup.Text = "Đóng";
            btnCancelAddGroup.UseVisualStyleBackColor = false;
            btnCancelAddGroup.Click += btnCancelAddGroup_Click;
            // 
            // tbUserlist
            // 
            tbUserlist.ColumnCount = 1;
            tbUserlist.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tbUserlist.Location = new Point(34, 120);
            tbUserlist.Name = "tbUserlist";
            tbUserlist.RowCount = 1;
            tbUserlist.RowStyles.Add(new RowStyle());
            tbUserlist.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tbUserlist.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tbUserlist.Size = new Size(503, 65);
            tbUserlist.TabIndex = 4;
            // 
            // Group
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(562, 567);
            Controls.Add(tbUserlist);
            Controls.Add(btnCancelAddGroup);
            Controls.Add(btnAddGroup);
            Controls.Add(lbSelectUsers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Group";
            Text = "Group";
            Load += Group_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbSelectUsers;
        private Button btnAddGroup;
        private Button btnCancelAddGroup;
        private TableLayoutPanel tbUserlist;
    }
}