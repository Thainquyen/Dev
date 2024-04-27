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
            lbSelectUsers.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbSelectUsers.ForeColor = SystemColors.ControlLightLight;
            lbSelectUsers.Location = new Point(102, 28);
            lbSelectUsers.Margin = new Padding(2, 0, 2, 0);
            lbSelectUsers.Name = "lbSelectUsers";
            lbSelectUsers.Size = new Size(201, 19);
            lbSelectUsers.TabIndex = 0;
            lbSelectUsers.Text = "Vui lòng chọn bạn để tạo nhóm!";
            // 
            // btnAddGroup
            // 
            btnAddGroup.BackColor = SystemColors.GradientActiveCaption;
            btnAddGroup.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddGroup.Location = new Point(55, 283);
            btnAddGroup.Margin = new Padding(2);
            btnAddGroup.Name = "btnAddGroup";
            btnAddGroup.Size = new Size(113, 33);
            btnAddGroup.TabIndex = 2;
            btnAddGroup.Text = "Thêm Nhóm";
            btnAddGroup.UseVisualStyleBackColor = false;
            btnAddGroup.Click += btnAddGroup_Click;
            // 
            // btnCancelAddGroup
            // 
            btnCancelAddGroup.BackColor = SystemColors.ControlDark;
            btnCancelAddGroup.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelAddGroup.Location = new Point(206, 283);
            btnCancelAddGroup.Margin = new Padding(2);
            btnCancelAddGroup.Name = "btnCancelAddGroup";
            btnCancelAddGroup.Size = new Size(113, 33);
            btnCancelAddGroup.TabIndex = 3;
            btnCancelAddGroup.Text = "Đóng";
            btnCancelAddGroup.UseVisualStyleBackColor = false;
            btnCancelAddGroup.Click += btnCancelAddGroup_Click;
            // 
            // tbUserlist
            // 
            tbUserlist.ColumnCount = 1;
            tbUserlist.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tbUserlist.Location = new Point(24, 72);
            tbUserlist.Margin = new Padding(2);
            tbUserlist.Name = "tbUserlist";
            tbUserlist.RowCount = 1;
            tbUserlist.RowStyles.Add(new RowStyle());
            tbUserlist.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tbUserlist.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tbUserlist.Size = new Size(352, 39);
            tbUserlist.TabIndex = 4;
            // 
            // Group
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(393, 340);
            Controls.Add(tbUserlist);
            Controls.Add(btnCancelAddGroup);
            Controls.Add(btnAddGroup);
            Controls.Add(lbSelectUsers);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Group";
            StartPosition = FormStartPosition.CenterScreen;
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