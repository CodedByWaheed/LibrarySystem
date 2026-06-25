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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlMemberCard));
            uiPanel1 = new Sunny.UI.UIPanel();
            scMain = new SplitContainer();
            uiAvatar1 = new Sunny.UI.UIAvatar();
            parrotPictureBox1 = new ReaLTaiizor.Controls.ParrotPictureBox();
            scLeftMain = new SplitContainer();
            lMembershipNum = new ReaLTaiizor.Controls.CrownLabel();
            lFullName = new ReaLTaiizor.Controls.BigLabel();
            scBottomLeftMain = new SplitContainer();
            label2 = new Label();
            lNumberOfBorrowBook = new Label();
            lMemberStatus = new Sunny.UI.UIMarkLabel();
            label3 = new Label();
            lPhoneNumber = new Label();
            label1 = new Label();
            lMembershipType = new Label();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scMain).BeginInit();
            scMain.Panel1.SuspendLayout();
            scMain.Panel2.SuspendLayout();
            scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scLeftMain).BeginInit();
            scLeftMain.Panel1.SuspendLayout();
            scLeftMain.Panel2.SuspendLayout();
            scLeftMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scBottomLeftMain).BeginInit();
            scBottomLeftMain.Panel1.SuspendLayout();
            scBottomLeftMain.Panel2.SuspendLayout();
            scBottomLeftMain.SuspendLayout();
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
            uiPanel1.Size = new Size(670, 154);
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
            scMain.Panel1.Controls.Add(parrotPictureBox1);
            // 
            // scMain.Panel2
            // 
            scMain.Panel2.BackColor = Color.Transparent;
            scMain.Panel2.Controls.Add(scLeftMain);
            scMain.Size = new Size(664, 148);
            scMain.SplitterDistance = 136;
            scMain.TabIndex = 0;
            // 
            // uiAvatar1
            // 
            uiAvatar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            uiAvatar1.AvatarSize = 85;
            uiAvatar1.Font = new Font("Microsoft Sans Serif", 12F);
            uiAvatar1.Location = new Point(23, 10);
            uiAvatar1.MinimumSize = new Size(1, 1);
            uiAvatar1.Name = "uiAvatar1";
            uiAvatar1.Size = new Size(91, 89);
            uiAvatar1.SymbolSize = 55;
            uiAvatar1.TabIndex = 1;
            uiAvatar1.Text = "uiAvatar1";
            // 
            // parrotPictureBox1
            // 
            parrotPictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            parrotPictureBox1.BackColor = Color.Transparent;
            parrotPictureBox1.ColorLeft = Color.DodgerBlue;
            parrotPictureBox1.ColorRight = Color.DodgerBlue;
            parrotPictureBox1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotPictureBox1.FilterAlpha = 200;
            parrotPictureBox1.FilterEnabled = false;
            parrotPictureBox1.Image = (Image)resources.GetObject("parrotPictureBox1.Image");
            parrotPictureBox1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPictureBox1.IsElipse = true;
            parrotPictureBox1.IsParallax = false;
            parrotPictureBox1.Location = new Point(23, 10);
            parrotPictureBox1.Name = "parrotPictureBox1";
            parrotPictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox1.Size = new Size(91, 89);
            parrotPictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox1.TabIndex = 0;
            parrotPictureBox1.Text = "parrotPictureBox1";
            parrotPictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // scLeftMain
            // 
            scLeftMain.Dock = DockStyle.Fill;
            scLeftMain.FixedPanel = FixedPanel.Panel1;
            scLeftMain.IsSplitterFixed = true;
            scLeftMain.Location = new Point(0, 0);
            scLeftMain.Name = "scLeftMain";
            scLeftMain.Orientation = Orientation.Horizontal;
            // 
            // scLeftMain.Panel1
            // 
            scLeftMain.Panel1.Controls.Add(lMembershipNum);
            scLeftMain.Panel1.Controls.Add(lFullName);
            // 
            // scLeftMain.Panel2
            // 
            scLeftMain.Panel2.Controls.Add(scBottomLeftMain);
            scLeftMain.Size = new Size(524, 148);
            scLeftMain.SplitterDistance = 76;
            scLeftMain.TabIndex = 12;
            // 
            // lMembershipNum
            // 
            lMembershipNum.Anchor = AnchorStyles.Left;
            lMembershipNum.AutoSize = true;
            lMembershipNum.BackColor = Color.Transparent;
            lMembershipNum.ForeColor = Color.Gray;
            lMembershipNum.Location = new Point(16, 47);
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
            lFullName.Location = new Point(3, 0);
            lFullName.Name = "lFullName";
            lFullName.Size = new Size(212, 57);
            lFullName.TabIndex = 7;
            lFullName.Text = "Full Name";
            // 
            // scBottomLeftMain
            // 
            scBottomLeftMain.Dock = DockStyle.Fill;
            scBottomLeftMain.FixedPanel = FixedPanel.Panel1;
            scBottomLeftMain.IsSplitterFixed = true;
            scBottomLeftMain.Location = new Point(0, 0);
            scBottomLeftMain.Name = "scBottomLeftMain";
            // 
            // scBottomLeftMain.Panel1
            // 
            scBottomLeftMain.Panel1.Controls.Add(label2);
            scBottomLeftMain.Panel1.Controls.Add(lNumberOfBorrowBook);
            scBottomLeftMain.Panel1.Controls.Add(lMemberStatus);
            // 
            // scBottomLeftMain.Panel2
            // 
            scBottomLeftMain.Panel2.Controls.Add(label3);
            scBottomLeftMain.Panel2.Controls.Add(lPhoneNumber);
            scBottomLeftMain.Panel2.Controls.Add(label1);
            scBottomLeftMain.Panel2.Controls.Add(lMembershipType);
            scBottomLeftMain.Size = new Size(524, 68);
            scBottomLeftMain.SplitterDistance = 262;
            scBottomLeftMain.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(11, 54);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 10;
            label2.Text = "Borrow  Count :";
            // 
            // lNumberOfBorrowBook
            // 
            lNumberOfBorrowBook.AutoSize = true;
            lNumberOfBorrowBook.Font = new Font("Microsoft Sans Serif", 12F);
            lNumberOfBorrowBook.Location = new Point(169, 54);
            lNumberOfBorrowBook.Name = "lNumberOfBorrowBook";
            lNumberOfBorrowBook.Size = new Size(90, 25);
            lNumberOfBorrowBook.TabIndex = 11;
            lNumberOfBorrowBook.Text = "2/3 Book";
            // 
            // lMemberStatus
            // 
            lMemberStatus.BackColor = Color.Transparent;
            lMemberStatus.Font = new Font("Microsoft Sans Serif", 12F);
            lMemberStatus.ForeColor = Color.FromArgb(48, 48, 48);
            lMemberStatus.Location = new Point(16, 11);
            lMemberStatus.MarkColor = Color.Lime;
            lMemberStatus.MarkSize = 5;
            lMemberStatus.Name = "lMemberStatus";
            lMemberStatus.Padding = new Padding(5, 0, 0, 0);
            lMemberStatus.Size = new Size(96, 29);
            lMemberStatus.TabIndex = 9;
            lMemberStatus.Text = "Active";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(3, 54);
            label3.Name = "label3";
            label3.Size = new Size(154, 25);
            label3.TabIndex = 12;
            label3.Text = "Phone Number :";
            // 
            // lPhoneNumber
            // 
            lPhoneNumber.AutoSize = true;
            lPhoneNumber.Font = new Font("Microsoft Sans Serif", 12F);
            lPhoneNumber.Location = new Point(158, 54);
            lPhoneNumber.Name = "lPhoneNumber";
            lPhoneNumber.Size = new Size(125, 25);
            lPhoneNumber.TabIndex = 13;
            lPhoneNumber.Text = "059xxxxxxxx";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 10;
            label1.Text = "Membership Type :";
            // 
            // lMembershipType
            // 
            lMembershipType.AutoSize = true;
            lMembershipType.BackColor = Color.Transparent;
            lMembershipType.Location = new Point(190, 13);
            lMembershipType.Name = "lMembershipType";
            lMembershipType.Size = new Size(92, 25);
            lMembershipType.TabIndex = 11;
            lMembershipType.Text = "Standard";
            // 
            // ctrlMemberCard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(uiPanel1);
            Name = "ctrlMemberCard";
            Size = new Size(670, 154);
            Load += ctrlMemberCard_Load;
            uiPanel1.ResumeLayout(false);
            scMain.Panel1.ResumeLayout(false);
            scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scMain).EndInit();
            scMain.ResumeLayout(false);
            scLeftMain.Panel1.ResumeLayout(false);
            scLeftMain.Panel1.PerformLayout();
            scLeftMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scLeftMain).EndInit();
            scLeftMain.ResumeLayout(false);
            scBottomLeftMain.Panel1.ResumeLayout(false);
            scBottomLeftMain.Panel1.PerformLayout();
            scBottomLeftMain.Panel2.ResumeLayout(false);
            scBottomLeftMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scBottomLeftMain).EndInit();
            scBottomLeftMain.ResumeLayout(false);
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
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox1;
        private SplitContainer scLeftMain;
        private SplitContainer scBottomLeftMain;
        private Label label2;
        private Label lNumberOfBorrowBook;
        private Label label3;
        private Label lPhoneNumber;
        private Sunny.UI.UIAvatar uiAvatar1;
    }
}
