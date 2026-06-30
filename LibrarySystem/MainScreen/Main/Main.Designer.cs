namespace LibrarySystem
{
    partial class fmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            scMain = new Sunny.UI.UISplitContainer();
            scLeftSide = new SplitContainer();
            uiLabel1 = new Sunny.UI.UILabel();
            parrotPictureBox2 = new ReaLTaiizor.Controls.ParrotPictureBox();
            menuStrip1 = new MenuStrip();
            dashboradToolStripMenuItem = new ToolStripMenuItem();
            booksToolStripMenuItem = new ToolStripMenuItem();
            membersToolStripMenuItem = new ToolStripMenuItem();
            loansToolStripMenuItem = new ToolStripMenuItem();
            finesToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            scRightSide = new SplitContainer();
            uiTextBox1 = new Sunny.UI.UITextBox();
            parrotPictureBox1 = new ReaLTaiizor.Controls.ParrotPictureBox();
            lUsername = new Sunny.UI.UILabel();
            avUser = new Sunny.UI.UIAvatar();
            pMain = new Sunny.UI.UIPanel();
            ctrlMainSettings1 = new LibrarySystem.MainScreen.Settings.ctrlMainSettings();
            separator1 = new ReaLTaiizor.Controls.Separator();
            (scMain).BeginInit();
            scMain.Panel1.SuspendLayout();
            scMain.Panel2.SuspendLayout();
            scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scLeftSide).BeginInit();
            scLeftSide.Panel1.SuspendLayout();
            scLeftSide.Panel2.SuspendLayout();
            scLeftSide.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scRightSide).BeginInit();
            scRightSide.Panel1.SuspendLayout();
            scRightSide.Panel2.SuspendLayout();
            scRightSide.SuspendLayout();
            pMain.SuspendLayout();
            SuspendLayout();
            // 
            // scMain
            // 
            scMain.ArrowColor = Color.Black;
            scMain.BarColor = Color.White;
            scMain.Dock = DockStyle.Fill;
            scMain.FixedPanel = FixedPanel.Panel1;
            scMain.HandleColor = Color.Gainsboro;
            scMain.Location = new Point(0, 0);
            scMain.MinimumSize = new Size(20, 20);
            scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            scMain.Panel1.Controls.Add(scLeftSide);
            // 
            // scMain.Panel2
            // 
            scMain.Panel2.Controls.Add(scRightSide);
            scMain.Size = new Size(1177, 777);
            scMain.SplitterDistance = 216;
            scMain.SplitterWidth = 3;
            scMain.TabIndex = 0;
            // 
            // scLeftSide
            // 
            scLeftSide.Dock = DockStyle.Fill;
            scLeftSide.FixedPanel = FixedPanel.Panel1;
            scLeftSide.IsSplitterFixed = true;
            scLeftSide.Location = new Point(0, 0);
            scLeftSide.Name = "scLeftSide";
            scLeftSide.Orientation = Orientation.Horizontal;
            // 
            // scLeftSide.Panel1
            // 
            scLeftSide.Panel1.Controls.Add(uiLabel1);
            scLeftSide.Panel1.Controls.Add(parrotPictureBox2);
            // 
            // scLeftSide.Panel2
            // 
            scLeftSide.Panel2.Controls.Add(menuStrip1);
            scLeftSide.Size = new Size(216, 777);
            scLeftSide.SplitterDistance = 92;
            scLeftSide.SplitterWidth = 1;
            scLeftSide.TabIndex = 1;
            // 
            // uiLabel1
            // 
            uiLabel1.Angle = 1;
            uiLabel1.AutoSize = true;
            uiLabel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(81, 31);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(139, 25);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "Central Library";
            // 
            // parrotPictureBox2
            // 
            parrotPictureBox2.ColorLeft = Color.Transparent;
            parrotPictureBox2.ColorRight = Color.Transparent;
            parrotPictureBox2.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.Invalid;
            parrotPictureBox2.FilterAlpha = 200;
            parrotPictureBox2.FilterEnabled = false;
            parrotPictureBox2.Image = Properties.Resources.open_book1;
            parrotPictureBox2.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPictureBox2.IsElipse = false;
            parrotPictureBox2.IsParallax = false;
            parrotPictureBox2.Location = new Point(12, 16);
            parrotPictureBox2.Name = "parrotPictureBox2";
            parrotPictureBox2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox2.Size = new Size(63, 61);
            parrotPictureBox2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox2.TabIndex = 1;
            parrotPictureBox2.Text = "parrotPictureBox2";
            parrotPictureBox2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Font = new Font("Segoe UI", 9F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboradToolStripMenuItem, booksToolStripMenuItem, membersToolStripMenuItem, loansToolStripMenuItem, finesToolStripMenuItem, reportsToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(204, 684);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboradToolStripMenuItem
            // 
            dashboradToolStripMenuItem.Image = Properties.Resources.home__1_;
            dashboradToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            dashboradToolStripMenuItem.Margin = new Padding(20, 0, 20, 0);
            dashboradToolStripMenuItem.Name = "dashboradToolStripMenuItem";
            dashboradToolStripMenuItem.Padding = new Padding(20, 5, 20, 5);
            dashboradToolStripMenuItem.Size = new Size(151, 46);
            dashboradToolStripMenuItem.Text = "Dashboard";
            dashboradToolStripMenuItem.Click += dashboradToolStripMenuItem_Click;
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.Image = Properties.Resources.book;
            booksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            booksToolStripMenuItem.Margin = new Padding(20, 0, 20, 0);
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Padding = new Padding(20, 5, 20, 5);
            booksToolStripMenuItem.Size = new Size(151, 46);
            booksToolStripMenuItem.Text = "Books";
            booksToolStripMenuItem.Click += booksToolStripMenuItem_Click;
            // 
            // membersToolStripMenuItem
            // 
            membersToolStripMenuItem.Image = Properties.Resources.user_groups;
            membersToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            membersToolStripMenuItem.Margin = new Padding(20, 0, 20, 0);
            membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            membersToolStripMenuItem.Padding = new Padding(20, 5, 20, 5);
            membersToolStripMenuItem.Size = new Size(151, 46);
            membersToolStripMenuItem.Text = "Members";
            membersToolStripMenuItem.Click += membersToolStripMenuItem_Click;
            // 
            // loansToolStripMenuItem
            // 
            loansToolStripMenuItem.Image = Properties.Resources.book_borrow;
            loansToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            loansToolStripMenuItem.Margin = new Padding(20, 0, 20, 0);
            loansToolStripMenuItem.Name = "loansToolStripMenuItem";
            loansToolStripMenuItem.Padding = new Padding(20, 5, 20, 5);
            loansToolStripMenuItem.Size = new Size(151, 46);
            loansToolStripMenuItem.Text = "Loans";
            loansToolStripMenuItem.Click += loansToolStripMenuItem_Click;
            // 
            // finesToolStripMenuItem
            // 
            finesToolStripMenuItem.Image = Properties.Resources.Fines;
            finesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            finesToolStripMenuItem.Margin = new Padding(20, 0, 20, 0);
            finesToolStripMenuItem.Name = "finesToolStripMenuItem";
            finesToolStripMenuItem.Padding = new Padding(20, 5, 20, 5);
            finesToolStripMenuItem.Size = new Size(151, 46);
            finesToolStripMenuItem.Text = "Fines";
            finesToolStripMenuItem.Click += finesToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Image = Properties.Resources.Reports;
            reportsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            reportsToolStripMenuItem.Margin = new Padding(20, 0, 20, 0);
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Padding = new Padding(20, 5, 20, 5);
            reportsToolStripMenuItem.Size = new Size(151, 46);
            reportsToolStripMenuItem.Text = "Reports";
            reportsToolStripMenuItem.Click += reportsToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Image = Properties.Resources.settings;
            settingsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            settingsToolStripMenuItem.Margin = new Padding(20, 0, 20, 0);
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Padding = new Padding(20, 5, 20, 5);
            settingsToolStripMenuItem.Size = new Size(151, 46);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // scRightSide
            // 
            scRightSide.Dock = DockStyle.Fill;
            scRightSide.FixedPanel = FixedPanel.Panel1;
            scRightSide.Location = new Point(0, 0);
            scRightSide.Name = "scRightSide";
            scRightSide.Orientation = Orientation.Horizontal;
            // 
            // scRightSide.Panel1
            // 
            scRightSide.Panel1.Controls.Add(uiTextBox1);
            scRightSide.Panel1.Controls.Add(parrotPictureBox1);
            scRightSide.Panel1.Controls.Add(lUsername);
            scRightSide.Panel1.Controls.Add(avUser);
            scRightSide.Panel1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            // 
            // scRightSide.Panel2
            // 
            scRightSide.Panel2.BackColor = Color.WhiteSmoke;
            scRightSide.Panel2.Controls.Add(pMain);
            scRightSide.Panel2.Controls.Add(separator1);
            scRightSide.Size = new Size(958, 777);
            scRightSide.SplitterDistance = 76;
            scRightSide.SplitterWidth = 1;
            scRightSide.TabIndex = 0;
            // 
            // uiTextBox1
            // 
            uiTextBox1.Font = new Font("Microsoft Sans Serif", 12F);
            uiTextBox1.Icon = Properties.Resources.search;
            uiTextBox1.Location = new Point(14, 20);
            uiTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiTextBox1.MinimumSize = new Size(1, 16);
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.Padding = new Padding(5);
            uiTextBox1.Radius = 10;
            uiTextBox1.RectColor = Color.Black;
            uiTextBox1.ShowText = false;
            uiTextBox1.Size = new Size(447, 36);
            uiTextBox1.SymbolRotate = 100;
            uiTextBox1.TabIndex = 5;
            uiTextBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox1.Watermark = "Search for Book , Member , Loan ...";
            // 
            // parrotPictureBox1
            // 
            parrotPictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            parrotPictureBox1.BackColor = Color.White;
            parrotPictureBox1.ColorLeft = Color.DodgerBlue;
            parrotPictureBox1.ColorRight = Color.DodgerBlue;
            parrotPictureBox1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotPictureBox1.Cursor = Cursors.Hand;
            parrotPictureBox1.FilterAlpha = 200;
            parrotPictureBox1.FilterEnabled = false;
            parrotPictureBox1.Image = Properties.Resources.ringing;
            parrotPictureBox1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPictureBox1.IsElipse = true;
            parrotPictureBox1.IsParallax = false;
            parrotPictureBox1.Location = new Point(711, 22);
            parrotPictureBox1.Name = "parrotPictureBox1";
            parrotPictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox1.Size = new Size(32, 32);
            parrotPictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox1.TabIndex = 1;
            parrotPictureBox1.Text = "parrotPictureBox1";
            parrotPictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // lUsername
            // 
            lUsername.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lUsername.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lUsername.ForeColor = Color.FromArgb(48, 48, 48);
            lUsername.Location = new Point(760, 24);
            lUsername.Name = "lUsername";
            lUsername.Size = new Size(125, 29);
            lUsername.TabIndex = 1;
            lUsername.Text = "Waheed alborai";
            lUsername.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // avUser
            // 
            avUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            avUser.AvatarSize = 50;
            avUser.Font = new Font("Microsoft Sans Serif", 12F);
            avUser.Location = new Point(888, 12);
            avUser.MinimumSize = new Size(1, 1);
            avUser.Name = "avUser";
            avUser.Size = new Size(58, 52);
            avUser.TabIndex = 4;
            // 
            // pMain
            // 
            pMain.Controls.Add(ctrlMainSettings1);
            pMain.Dock = DockStyle.Fill;
            pMain.Font = new Font("Microsoft Sans Serif", 12F);
            pMain.Location = new Point(0, 12);
            pMain.Margin = new Padding(4, 5, 4, 5);
            pMain.MinimumSize = new Size(1, 1);
            pMain.Name = "pMain";
            pMain.RectColor = Color.Transparent;
            pMain.Size = new Size(958, 688);
            pMain.TabIndex = 1;
            pMain.Text = null;
            pMain.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // ctrlMainSettings1
            // 
            ctrlMainSettings1.Dock = DockStyle.Fill;
            ctrlMainSettings1.Location = new Point(0, 0);
            ctrlMainSettings1.Name = "ctrlMainSettings1";
            ctrlMainSettings1.Size = new Size(958, 688);
            ctrlMainSettings1.TabIndex = 0;
            // 
            // separator1
            // 
            separator1.BackColor = Color.White;
            separator1.Dock = DockStyle.Top;
            separator1.LineColor = Color.Gray;
            separator1.Location = new Point(0, 0);
            separator1.Name = "separator1";
            separator1.Size = new Size(958, 12);
            separator1.TabIndex = 0;
            separator1.Text = "separator1";
            // 
            // fmMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1177, 777);
            Controls.Add(scMain);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(1920, 1030);
            MinimumSize = new Size(190, 40);
            Name = "fmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library";
            TransparencyKey = Color.Fuchsia;
            Load += fmMain_Load;
            scMain.Panel1.ResumeLayout(false);
            scMain.Panel2.ResumeLayout(false);
            (scMain).EndInit();
            scMain.ResumeLayout(false);
            scLeftSide.Panel1.ResumeLayout(false);
            scLeftSide.Panel1.PerformLayout();
            scLeftSide.Panel2.ResumeLayout(false);
            scLeftSide.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scLeftSide).EndInit();
            scLeftSide.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            scRightSide.Panel1.ResumeLayout(false);
            scRightSide.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scRightSide).EndInit();
            scRightSide.ResumeLayout(false);
            pMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private Sunny.UI.UISplitContainer scMain;
        private SplitContainer scRightSide;
        private SplitContainer scLeftSide;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox2;
        private Sunny.UI.UILabel uiLabel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashboradToolStripMenuItem;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem membersToolStripMenuItem;
        private ToolStripMenuItem loansToolStripMenuItem;
        private ToolStripMenuItem finesToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ReaLTaiizor.Controls.Separator separator1;
        private Sunny.UI.UIAvatar avUser;
        private Sunny.UI.UILabel lUsername;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox1;
        private Sunny.UI.UITextBox uiTextBox1;
        private MainScreen.Loans.ctrlMainLoan ctrlMainLoan1;
        private Sunny.UI.UIPanel pMain;
        private MainScreen.Settings.ctrlMainSettings ctrlMainSettings1;
    }
}
