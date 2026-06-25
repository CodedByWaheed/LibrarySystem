namespace LibrarySystem.MainScreen.Members
{
    partial class ctrlMemberCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uiPanel1 = new Sunny.UI.UIPanel();
            scMain = new SplitContainer();
            uiAvatar1 = new Sunny.UI.UIAvatar();
            lMembershipType = new Label();
            label1 = new Label();
            lMemberStatus = new Sunny.UI.UIMarkLabel();
            lMembershipNum = new ReaLTaiizor.Controls.CrownLabel();
            lFullName = new ReaLTaiizor.Controls.BigLabel();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scMain).BeginInit();
            scMain.Panel1.SuspendLayout();
            scMain.Panel2.SuspendLayout();
            scMain.SuspendLayout();
            SuspendLayout();
            // 
            // uiPanel1
            // 
            uiPanel1.BackColor = Color.White;
            uiPanel1.Controls.Add(scMain);
            uiPanel1.Dock = DockStyle.Fill;
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(0, 0);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 15;
            uiPanel1.RectColor = Color.Black;
            uiPanel1.Size = new Size(741, 136);
            uiPanel1.TabIndex = 0;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // scMain
            // 
            scMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            scMain.BackColor = Color.Transparent;
            scMain.FixedPanel = FixedPanel.Panel1;
            scMain.Location = new Point(3, 3);
            scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            scMain.Panel1.BackColor = Color.Transparent;
            scMain.Panel1.Controls.Add(uiAvatar1);
            // 
            // scMain.Panel2
            // 
            scMain.Panel2.BackColor = Color.Transparent;
            scMain.Panel2.Controls.Add(lMembershipType);
            scMain.Panel2.Controls.Add(label1);
            scMain.Panel2.Controls.Add(lMemberStatus);
            scMain.Panel2.Controls.Add(lMembershipNum);
            scMain.Panel2.Controls.Add(lFullName);
            scMain.Size = new Size(735, 130);
            scMain.SplitterDistance = 136;
            scMain.TabIndex = 0;
            // 
            // uiAvatar1
            // 
            uiAvatar1.AvatarSize = 110;
            uiAvatar1.BackColor = Color.Transparent;
            uiAvatar1.Dock = DockStyle.Fill;
            uiAvatar1.Font = new Font("Microsoft Sans Serif", 12F);
            uiAvatar1.Location = new Point(0, 0);
            uiAvatar1.MinimumSize = new Size(1, 1);
            uiAvatar1.Name = "uiAvatar1";
            uiAvatar1.Size = new Size(136, 130);
            uiAvatar1.SymbolSize = 85;
            uiAvatar1.TabIndex = 6;
            uiAvatar1.Text = "uiAvatar1";
            uiAvatar1.Click += uiAvatar1_Click;
            // 
            // lMembershipType
            // 
            lMembershipType.Anchor = AnchorStyles.Left;
            lMembershipType.AutoSize = true;
            lMembershipType.BackColor = Color.Transparent;
            lMembershipType.Location = new Point(344, 93);
            lMembershipType.Name = "lMembershipType";
            lMembershipType.Size = new Size(92, 25);
            lMembershipType.TabIndex = 11;
            lMembershipType.Text = "Standard";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(157, 93);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 10;
            label1.Text = "Membership Type :";
            // 
            // lMemberStatus
            // 
            lMemberStatus.Anchor = AnchorStyles.Left;
            lMemberStatus.BackColor = Color.Transparent;
            lMemberStatus.Font = new Font("Microsoft Sans Serif", 12F);
            lMemberStatus.ForeColor = Color.FromArgb(48, 48, 48);
            lMemberStatus.Location = new Point(26, 93);
            lMemberStatus.MarkColor = Color.Lime;
            lMemberStatus.MarkSize = 5;
            lMemberStatus.Name = "lMemberStatus";
            lMemberStatus.Padding = new Padding(5, 0, 0, 0);
            lMemberStatus.Size = new Size(96, 29);
            lMemberStatus.TabIndex = 9;
            lMemberStatus.Text = "Active";
            // 
            // lMembershipNum
            // 
            lMembershipNum.Anchor = AnchorStyles.Left;
            lMembershipNum.AutoSize = true;
            lMembershipNum.BackColor = Color.Transparent;
            lMembershipNum.ForeColor = Color.Gray;
            lMembershipNum.Location = new Point(26, 60);
            lMembershipNum.Name = "lMembershipNum";
            lMembershipNum.Size = new Size(96, 25);
            lMembershipNum.TabIndex = 8;
            lMembershipNum.Text = "M - xxxxx";
            // 
            // lFullName
            // 
            lFullName.Anchor = AnchorStyles.Left;
            lFullName.AutoSize = true;
            lFullName.BackColor = Color.Transparent;
            lFullName.Font = new Font("Segoe UI", 25F);
            lFullName.ForeColor = Color.Black;
            lFullName.Location = new Point(13, 13);
            lFullName.Name = "lFullName";
            lFullName.Size = new Size(212, 57);
            lFullName.TabIndex = 7;
            lFullName.Text = "Full Name";
            // 
            // ctrlMemberCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(uiPanel1);
            Name = "ctrlMemberCard";
            Size = new Size(741, 136);
            uiPanel1.ResumeLayout(false);
            scMain.Panel1.ResumeLayout(false);
            scMain.Panel2.ResumeLayout(false);
            scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scMain).EndInit();
            scMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private SplitContainer scMain;
        private Label lMembershipType;
        private Label label1;
        private Sunny.UI.UIMarkLabel lMemberStatus;
        private ReaLTaiizor.Controls.CrownLabel lMembershipNum;
        private ReaLTaiizor.Controls.BigLabel lFullName;
        private Sunny.UI.UIAvatar uiAvatar1;
    }
}
