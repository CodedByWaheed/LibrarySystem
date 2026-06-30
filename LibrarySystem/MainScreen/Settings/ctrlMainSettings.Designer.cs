namespace LibrarySystem.MainScreen.Settings
{
    partial class ctrlMainSettings
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
            scMain = new SplitContainer();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            scBottomMain = new SplitContainer();
            scLeftBottomMain = new SplitContainer();
            scTopLeftBottomMain = new SplitContainer();
            uiPanel1 = new Sunny.UI.UIPanel();
            label2 = new Label();
            parrotPictureBox1 = new ReaLTaiizor.Controls.ParrotPictureBox();
            label1 = new Label();
            uiPanel3 = new Sunny.UI.UIPanel();
            label5 = new Label();
            parrotPictureBox3 = new ReaLTaiizor.Controls.ParrotPictureBox();
            label6 = new Label();
            scBottomLeftBottomMain = new SplitContainer();
            uiPanel4 = new Sunny.UI.UIPanel();
            parrotPictureBox4 = new ReaLTaiizor.Controls.ParrotPictureBox();
            label8 = new Label();
            scRightBottomMain = new SplitContainer();
            uiPanel2 = new Sunny.UI.UIPanel();
            numudMaxBookPerPriMember = new Sunny.UI.UIIntegerUpDown();
            udnumDefaultDays = new Sunny.UI.UIIntegerUpDown();
            numudMaxBookPerMember = new Sunny.UI.UIIntegerUpDown();
            numudMaxRenewals = new Sunny.UI.UIIntegerUpDown();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label3 = new Label();
            parrotPictureBox2 = new ReaLTaiizor.Controls.ParrotPictureBox();
            label4 = new Label();
            uiPanel5 = new Sunny.UI.UIPanel();
            numudGracePeriod = new Sunny.UI.UIIntegerUpDown();
            numudDailyFee = new Sunny.UI.UIDoubleUpDown();
            label11 = new Label();
            label13 = new Label();
            parrotPictureBox7 = new ReaLTaiizor.Controls.ParrotPictureBox();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)scMain).BeginInit();
            scMain.Panel1.SuspendLayout();
            scMain.Panel2.SuspendLayout();
            scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scBottomMain).BeginInit();
            scBottomMain.Panel1.SuspendLayout();
            scBottomMain.Panel2.SuspendLayout();
            scBottomMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scLeftBottomMain).BeginInit();
            scLeftBottomMain.Panel1.SuspendLayout();
            scLeftBottomMain.Panel2.SuspendLayout();
            scLeftBottomMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scTopLeftBottomMain).BeginInit();
            scTopLeftBottomMain.Panel1.SuspendLayout();
            scTopLeftBottomMain.Panel2.SuspendLayout();
            scTopLeftBottomMain.SuspendLayout();
            uiPanel1.SuspendLayout();
            uiPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scBottomLeftBottomMain).BeginInit();
            scBottomLeftBottomMain.Panel1.SuspendLayout();
            scBottomLeftBottomMain.SuspendLayout();
            uiPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scRightBottomMain).BeginInit();
            scRightBottomMain.Panel1.SuspendLayout();
            scRightBottomMain.Panel2.SuspendLayout();
            scRightBottomMain.SuspendLayout();
            uiPanel2.SuspendLayout();
            uiPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // scMain
            // 
            scMain.Dock = DockStyle.Fill;
            scMain.FixedPanel = FixedPanel.Panel1;
            scMain.IsSplitterFixed = true;
            scMain.Location = new Point(0, 0);
            scMain.Name = "scMain";
            scMain.Orientation = Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            scMain.Panel1.Controls.Add(bigLabel1);
            // 
            // scMain.Panel2
            // 
            scMain.Panel2.Controls.Add(scBottomMain);
            scMain.Size = new Size(803, 534);
            scMain.SplitterDistance = 56;
            scMain.TabIndex = 0;
            scMain.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel1.Location = new Point(3, -1);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(174, 57);
            bigLabel1.TabIndex = 0;
            bigLabel1.Text = "Settings";
            // 
            // scBottomMain
            // 
            scBottomMain.Dock = DockStyle.Fill;
            scBottomMain.Location = new Point(0, 0);
            scBottomMain.Name = "scBottomMain";
            // 
            // scBottomMain.Panel1
            // 
            scBottomMain.Panel1.Controls.Add(scLeftBottomMain);
            // 
            // scBottomMain.Panel2
            // 
            scBottomMain.Panel2.Controls.Add(scRightBottomMain);
            scBottomMain.Size = new Size(803, 474);
            scBottomMain.SplitterDistance = 264;
            scBottomMain.TabIndex = 0;
            // 
            // scLeftBottomMain
            // 
            scLeftBottomMain.Dock = DockStyle.Fill;
            scLeftBottomMain.FixedPanel = FixedPanel.Panel1;
            scLeftBottomMain.IsSplitterFixed = true;
            scLeftBottomMain.Location = new Point(0, 0);
            scLeftBottomMain.Name = "scLeftBottomMain";
            scLeftBottomMain.Orientation = Orientation.Horizontal;
            // 
            // scLeftBottomMain.Panel1
            // 
            scLeftBottomMain.Panel1.Controls.Add(scTopLeftBottomMain);
            // 
            // scLeftBottomMain.Panel2
            // 
            scLeftBottomMain.Panel2.Controls.Add(scBottomLeftBottomMain);
            scLeftBottomMain.Size = new Size(264, 474);
            scLeftBottomMain.SplitterDistance = 235;
            scLeftBottomMain.TabIndex = 0;
            // 
            // scTopLeftBottomMain
            // 
            scTopLeftBottomMain.Dock = DockStyle.Fill;
            scTopLeftBottomMain.FixedPanel = FixedPanel.Panel1;
            scTopLeftBottomMain.IsSplitterFixed = true;
            scTopLeftBottomMain.Location = new Point(0, 0);
            scTopLeftBottomMain.Name = "scTopLeftBottomMain";
            scTopLeftBottomMain.Orientation = Orientation.Horizontal;
            // 
            // scTopLeftBottomMain.Panel1
            // 
            scTopLeftBottomMain.Panel1.Controls.Add(uiPanel1);
            // 
            // scTopLeftBottomMain.Panel2
            // 
            scTopLeftBottomMain.Panel2.Controls.Add(uiPanel3);
            scTopLeftBottomMain.Size = new Size(264, 235);
            scTopLeftBottomMain.SplitterDistance = 114;
            scTopLeftBottomMain.TabIndex = 0;
            // 
            // uiPanel1
            // 
            uiPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiPanel1.Controls.Add(label2);
            uiPanel1.Controls.Add(parrotPictureBox1);
            uiPanel1.Controls.Add(label1);
            uiPanel1.Cursor = Cursors.Hand;
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(10, 13);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 15;
            uiPanel1.RectColor = Color.Black;
            uiPanel1.Size = new Size(250, 88);
            uiPanel1.TabIndex = 5;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 48);
            label2.Name = "label2";
            label2.Size = new Size(297, 22);
            label2.TabIndex = 2;
            label2.Text = "Current Key Value , Member Profile ";
            // 
            // parrotPictureBox1
            // 
            parrotPictureBox1.BackColor = Color.Transparent;
            parrotPictureBox1.ColorLeft = Color.DodgerBlue;
            parrotPictureBox1.ColorRight = Color.DodgerBlue;
            parrotPictureBox1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotPictureBox1.FilterAlpha = 200;
            parrotPictureBox1.FilterEnabled = false;
            parrotPictureBox1.Image = Properties.Resources.people;
            parrotPictureBox1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPictureBox1.IsElipse = true;
            parrotPictureBox1.IsParallax = false;
            parrotPictureBox1.Location = new Point(9, 8);
            parrotPictureBox1.Name = "parrotPictureBox1";
            parrotPictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox1.Size = new Size(37, 37);
            parrotPictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox1.TabIndex = 1;
            parrotPictureBox1.Text = "parrotPictureBox1";
            parrotPictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 13);
            label1.Name = "label1";
            label1.Size = new Size(174, 29);
            label1.TabIndex = 0;
            label1.Text = "Profile Account";
            // 
            // uiPanel3
            // 
            uiPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiPanel3.Controls.Add(label5);
            uiPanel3.Controls.Add(parrotPictureBox3);
            uiPanel3.Controls.Add(label6);
            uiPanel3.Cursor = Cursors.Hand;
            uiPanel3.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel3.Location = new Point(7, 14);
            uiPanel3.Margin = new Padding(4, 5, 4, 5);
            uiPanel3.MinimumSize = new Size(1, 1);
            uiPanel3.Name = "uiPanel3";
            uiPanel3.Radius = 15;
            uiPanel3.RectColor = Color.Black;
            uiPanel3.Size = new Size(250, 88);
            uiPanel3.TabIndex = 6;
            uiPanel3.Text = null;
            uiPanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 48);
            label5.Name = "label5";
            label5.Size = new Size(164, 22);
            label5.TabIndex = 2;
            label5.Text = "Current Notification";
            // 
            // parrotPictureBox3
            // 
            parrotPictureBox3.BackColor = Color.Transparent;
            parrotPictureBox3.ColorLeft = Color.DodgerBlue;
            parrotPictureBox3.ColorRight = Color.DodgerBlue;
            parrotPictureBox3.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotPictureBox3.FilterAlpha = 200;
            parrotPictureBox3.FilterEnabled = false;
            parrotPictureBox3.Image = Properties.Resources.bellBackground;
            parrotPictureBox3.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPictureBox3.IsElipse = true;
            parrotPictureBox3.IsParallax = false;
            parrotPictureBox3.Location = new Point(9, 8);
            parrotPictureBox3.Name = "parrotPictureBox3";
            parrotPictureBox3.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox3.Size = new Size(37, 37);
            parrotPictureBox3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox3.TabIndex = 1;
            parrotPictureBox3.Text = "parrotPictureBox3";
            parrotPictureBox3.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(49, 13);
            label6.Name = "label6";
            label6.Size = new Size(145, 29);
            label6.TabIndex = 0;
            label6.Text = "Notifications";
            // 
            // scBottomLeftBottomMain
            // 
            scBottomLeftBottomMain.Dock = DockStyle.Fill;
            scBottomLeftBottomMain.FixedPanel = FixedPanel.Panel1;
            scBottomLeftBottomMain.IsSplitterFixed = true;
            scBottomLeftBottomMain.Location = new Point(0, 0);
            scBottomLeftBottomMain.Name = "scBottomLeftBottomMain";
            scBottomLeftBottomMain.Orientation = Orientation.Horizontal;
            // 
            // scBottomLeftBottomMain.Panel1
            // 
            scBottomLeftBottomMain.Panel1.Controls.Add(uiPanel4);
            scBottomLeftBottomMain.Size = new Size(264, 235);
            scBottomLeftBottomMain.SplitterDistance = 114;
            scBottomLeftBottomMain.TabIndex = 0;
            // 
            // uiPanel4
            // 
            uiPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiPanel4.Controls.Add(parrotPictureBox4);
            uiPanel4.Controls.Add(label8);
            uiPanel4.Cursor = Cursors.Hand;
            uiPanel4.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel4.Location = new Point(7, 13);
            uiPanel4.Margin = new Padding(4, 5, 4, 5);
            uiPanel4.MinimumSize = new Size(1, 1);
            uiPanel4.Name = "uiPanel4";
            uiPanel4.Radius = 15;
            uiPanel4.RectColor = Color.Black;
            uiPanel4.Size = new Size(250, 88);
            uiPanel4.TabIndex = 7;
            uiPanel4.Text = null;
            uiPanel4.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // parrotPictureBox4
            // 
            parrotPictureBox4.BackColor = Color.Transparent;
            parrotPictureBox4.ColorLeft = Color.DodgerBlue;
            parrotPictureBox4.ColorRight = Color.DodgerBlue;
            parrotPictureBox4.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotPictureBox4.FilterAlpha = 200;
            parrotPictureBox4.FilterEnabled = false;
            parrotPictureBox4.Image = Properties.Resources.role1;
            parrotPictureBox4.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPictureBox4.IsElipse = true;
            parrotPictureBox4.IsParallax = false;
            parrotPictureBox4.Location = new Point(9, 8);
            parrotPictureBox4.Name = "parrotPictureBox4";
            parrotPictureBox4.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox4.Size = new Size(37, 37);
            parrotPictureBox4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox4.TabIndex = 1;
            parrotPictureBox4.Text = "parrotPictureBox4";
            parrotPictureBox4.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(49, 13);
            label8.Name = "label8";
            label8.Size = new Size(191, 29);
            label8.TabIndex = 0;
            label8.Text = "Roles Permision";
            // 
            // scRightBottomMain
            // 
            scRightBottomMain.Dock = DockStyle.Fill;
            scRightBottomMain.Location = new Point(0, 0);
            scRightBottomMain.Name = "scRightBottomMain";
            // 
            // scRightBottomMain.Panel1
            // 
            scRightBottomMain.Panel1.Controls.Add(uiPanel2);
            // 
            // scRightBottomMain.Panel2
            // 
            scRightBottomMain.Panel2.Controls.Add(uiPanel5);
            scRightBottomMain.Size = new Size(535, 474);
            scRightBottomMain.SplitterDistance = 272;
            scRightBottomMain.TabIndex = 0;
            // 
            // uiPanel2
            // 
            uiPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiPanel2.Controls.Add(numudMaxBookPerPriMember);
            uiPanel2.Controls.Add(udnumDefaultDays);
            uiPanel2.Controls.Add(numudMaxBookPerMember);
            uiPanel2.Controls.Add(numudMaxRenewals);
            uiPanel2.Controls.Add(label10);
            uiPanel2.Controls.Add(label9);
            uiPanel2.Controls.Add(label7);
            uiPanel2.Controls.Add(label3);
            uiPanel2.Controls.Add(parrotPictureBox2);
            uiPanel2.Controls.Add(label4);
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel2.Location = new Point(9, 13);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Radius = 15;
            uiPanel2.RectColor = Color.Black;
            uiPanel2.Size = new Size(254, 403);
            uiPanel2.TabIndex = 6;
            uiPanel2.Text = " ";
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // numudMaxBookPerPriMember
            // 
            numudMaxBookPerPriMember.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numudMaxBookPerPriMember.Font = new Font("Microsoft Sans Serif", 12F);
            numudMaxBookPerPriMember.Location = new Point(15, 344);
            numudMaxBookPerPriMember.Margin = new Padding(4, 5, 4, 5);
            numudMaxBookPerPriMember.MinimumSize = new Size(1, 16);
            numudMaxBookPerPriMember.Name = "numudMaxBookPerPriMember";
            numudMaxBookPerPriMember.Padding = new Padding(5);
            numudMaxBookPerPriMember.Radius = 15;
            numudMaxBookPerPriMember.ShowText = false;
            numudMaxBookPerPriMember.Size = new Size(223, 36);
            numudMaxBookPerPriMember.TabIndex = 13;
            numudMaxBookPerPriMember.Text = "0";
            numudMaxBookPerPriMember.TextAlignment = ContentAlignment.MiddleCenter;
            numudMaxBookPerPriMember.ValueChanged += uiIntegerUpDown3_ValueChanged;
            // 
            // udnumDefaultDays
            // 
            udnumDefaultDays.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            udnumDefaultDays.Font = new Font("Microsoft Sans Serif", 12F);
            udnumDefaultDays.Location = new Point(15, 109);
            udnumDefaultDays.Margin = new Padding(4, 5, 4, 5);
            udnumDefaultDays.MinimumSize = new Size(1, 16);
            udnumDefaultDays.Name = "udnumDefaultDays";
            udnumDefaultDays.Padding = new Padding(5);
            udnumDefaultDays.Radius = 15;
            udnumDefaultDays.ShowText = false;
            udnumDefaultDays.Size = new Size(223, 36);
            udnumDefaultDays.TabIndex = 13;
            udnumDefaultDays.Text = "0";
            udnumDefaultDays.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // numudMaxBookPerMember
            // 
            numudMaxBookPerMember.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numudMaxBookPerMember.Font = new Font("Microsoft Sans Serif", 12F);
            numudMaxBookPerMember.Location = new Point(15, 266);
            numudMaxBookPerMember.Margin = new Padding(4, 5, 4, 5);
            numudMaxBookPerMember.MinimumSize = new Size(1, 16);
            numudMaxBookPerMember.Name = "numudMaxBookPerMember";
            numudMaxBookPerMember.Padding = new Padding(5);
            numudMaxBookPerMember.Radius = 15;
            numudMaxBookPerMember.ShowText = false;
            numudMaxBookPerMember.Size = new Size(223, 36);
            numudMaxBookPerMember.TabIndex = 13;
            numudMaxBookPerMember.Text = "0";
            numudMaxBookPerMember.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // numudMaxRenewals
            // 
            numudMaxRenewals.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numudMaxRenewals.Font = new Font("Microsoft Sans Serif", 12F);
            numudMaxRenewals.Location = new Point(15, 185);
            numudMaxRenewals.Margin = new Padding(4, 5, 4, 5);
            numudMaxRenewals.MinimumSize = new Size(1, 16);
            numudMaxRenewals.Name = "numudMaxRenewals";
            numudMaxRenewals.Padding = new Padding(5);
            numudMaxRenewals.Radius = 15;
            numudMaxRenewals.ShowText = false;
            numudMaxRenewals.Size = new Size(223, 36);
            numudMaxRenewals.TabIndex = 12;
            numudMaxRenewals.Text = "0";
            numudMaxRenewals.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(15, 317);
            label10.Name = "label10";
            label10.Size = new Size(294, 25);
            label10.TabIndex = 11;
            label10.Text = "Max Book Per Primum Member :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(15, 236);
            label9.Name = "label9";
            label9.Size = new Size(223, 25);
            label9.TabIndex = 10;
            label9.Text = "Max Book Per Member :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(15, 155);
            label7.Name = "label7";
            label7.Size = new Size(151, 25);
            label7.TabIndex = 9;
            label7.Text = "Max Renewals :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(15, 74);
            label3.Name = "label3";
            label3.Size = new Size(139, 25);
            label3.TabIndex = 8;
            label3.Text = " Default Days :";
            // 
            // parrotPictureBox2
            // 
            parrotPictureBox2.BackColor = Color.Transparent;
            parrotPictureBox2.ColorLeft = Color.DodgerBlue;
            parrotPictureBox2.ColorRight = Color.DodgerBlue;
            parrotPictureBox2.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotPictureBox2.FilterAlpha = 200;
            parrotPictureBox2.FilterEnabled = false;
            parrotPictureBox2.Image = Properties.Resources.books;
            parrotPictureBox2.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPictureBox2.IsElipse = true;
            parrotPictureBox2.IsParallax = false;
            parrotPictureBox2.Location = new Point(10, 9);
            parrotPictureBox2.Name = "parrotPictureBox2";
            parrotPictureBox2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox2.Size = new Size(37, 37);
            parrotPictureBox2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox2.TabIndex = 7;
            parrotPictureBox2.Text = "parrotPictureBox2";
            parrotPictureBox2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 14);
            label4.Name = "label4";
            label4.Size = new Size(165, 29);
            label4.TabIndex = 6;
            label4.Text = "Borrow Rules ";
            // 
            // uiPanel5
            // 
            uiPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiPanel5.Controls.Add(numudGracePeriod);
            uiPanel5.Controls.Add(numudDailyFee);
            uiPanel5.Controls.Add(label11);
            uiPanel5.Controls.Add(label13);
            uiPanel5.Controls.Add(parrotPictureBox7);
            uiPanel5.Controls.Add(label14);
            uiPanel5.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel5.Location = new Point(11, 13);
            uiPanel5.Margin = new Padding(4, 5, 4, 5);
            uiPanel5.MinimumSize = new Size(1, 1);
            uiPanel5.Name = "uiPanel5";
            uiPanel5.Radius = 15;
            uiPanel5.RectColor = Color.Black;
            uiPanel5.Size = new Size(236, 261);
            uiPanel5.TabIndex = 6;
            uiPanel5.Text = " ";
            uiPanel5.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // numudGracePeriod
            // 
            numudGracePeriod.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numudGracePeriod.Font = new Font("Microsoft Sans Serif", 12F);
            numudGracePeriod.Location = new Point(22, 183);
            numudGracePeriod.Margin = new Padding(4, 5, 4, 5);
            numudGracePeriod.MinimumSize = new Size(1, 16);
            numudGracePeriod.Name = "numudGracePeriod";
            numudGracePeriod.Padding = new Padding(5);
            numudGracePeriod.Radius = 15;
            numudGracePeriod.ShowText = false;
            numudGracePeriod.Size = new Size(208, 36);
            numudGracePeriod.TabIndex = 14;
            numudGracePeriod.Text = "0";
            numudGracePeriod.TextAlignment = ContentAlignment.MiddleCenter;
            numudGracePeriod.ValueChanged += uiIntegerUpDown5_ValueChanged;
            // 
            // numudDailyFee
            // 
            numudDailyFee.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numudDailyFee.Font = new Font("Microsoft Sans Serif", 12F);
            numudDailyFee.Location = new Point(22, 109);
            numudDailyFee.Margin = new Padding(4, 5, 4, 5);
            numudDailyFee.MinimumSize = new Size(1, 16);
            numudDailyFee.Name = "numudDailyFee";
            numudDailyFee.Padding = new Padding(5);
            numudDailyFee.Radius = 15;
            numudDailyFee.ShowText = false;
            numudDailyFee.Size = new Size(208, 36);
            numudDailyFee.Step = 1D;
            numudDailyFee.TabIndex = 10;
            numudDailyFee.Text = "0.00";
            numudDailyFee.TextAlignment = ContentAlignment.MiddleCenter;
            numudDailyFee.Value = 0D;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(22, 155);
            label11.Name = "label11";
            label11.Size = new Size(137, 25);
            label11.TabIndex = 9;
            label11.Text = "Grace Period :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Location = new Point(22, 74);
            label13.Name = "label13";
            label13.Size = new Size(105, 25);
            label13.TabIndex = 8;
            label13.Text = "Daily Fee :";
            // 
            // parrotPictureBox7
            // 
            parrotPictureBox7.BackColor = Color.Transparent;
            parrotPictureBox7.ColorLeft = Color.DodgerBlue;
            parrotPictureBox7.ColorRight = Color.DodgerBlue;
            parrotPictureBox7.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotPictureBox7.FilterAlpha = 200;
            parrotPictureBox7.FilterEnabled = false;
            parrotPictureBox7.Image = Properties.Resources.punishment;
            parrotPictureBox7.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPictureBox7.IsElipse = true;
            parrotPictureBox7.IsParallax = false;
            parrotPictureBox7.Location = new Point(10, 9);
            parrotPictureBox7.Name = "parrotPictureBox7";
            parrotPictureBox7.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox7.Size = new Size(37, 37);
            parrotPictureBox7.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox7.TabIndex = 7;
            parrotPictureBox7.Text = "parrotPictureBox7";
            parrotPictureBox7.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(50, 14);
            label14.Name = "label14";
            label14.Size = new Size(129, 29);
            label14.TabIndex = 6;
            label14.Text = "Fine Rules";
            // 
            // ctrlMainSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(scMain);
            Name = "ctrlMainSettings";
            Size = new Size(803, 534);
            scMain.Panel1.ResumeLayout(false);
            scMain.Panel1.PerformLayout();
            scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scMain).EndInit();
            scMain.ResumeLayout(false);
            scBottomMain.Panel1.ResumeLayout(false);
            scBottomMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scBottomMain).EndInit();
            scBottomMain.ResumeLayout(false);
            scLeftBottomMain.Panel1.ResumeLayout(false);
            scLeftBottomMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scLeftBottomMain).EndInit();
            scLeftBottomMain.ResumeLayout(false);
            scTopLeftBottomMain.Panel1.ResumeLayout(false);
            scTopLeftBottomMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scTopLeftBottomMain).EndInit();
            scTopLeftBottomMain.ResumeLayout(false);
            uiPanel1.ResumeLayout(false);
            uiPanel1.PerformLayout();
            uiPanel3.ResumeLayout(false);
            uiPanel3.PerformLayout();
            scBottomLeftBottomMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scBottomLeftBottomMain).EndInit();
            scBottomLeftBottomMain.ResumeLayout(false);
            uiPanel4.ResumeLayout(false);
            uiPanel4.PerformLayout();
            scRightBottomMain.Panel1.ResumeLayout(false);
            scRightBottomMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scRightBottomMain).EndInit();
            scRightBottomMain.ResumeLayout(false);
            uiPanel2.ResumeLayout(false);
            uiPanel2.PerformLayout();
            uiPanel5.ResumeLayout(false);
            uiPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer scMain;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel1;
        private SplitContainer scBottomMain;
        private SplitContainer scLeftBottomMain;
        private SplitContainer scTopLeftBottomMain;
        private Sunny.UI.UIPanel uiPanel1;
        private Label label2;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox1;
        private Label label1;
        private SplitContainer scRightBottomMain;
        private Sunny.UI.UIPanel uiPanel2;
        private Label label3;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox2;
        private Label label4;
        private Sunny.UI.UIPanel uiPanel5;
        private Label label13;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox7;
        private Label label14;
        private Sunny.UI.UIPanel uiPanel3;
        private Label label5;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox3;
        private Label label6;
        private SplitContainer scBottomLeftBottomMain;
        private Sunny.UI.UIPanel uiPanel4;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox4;
        private Label label8;
        private Label label9;
        private Label label7;
        private Label label10;
        private Label label11;
        private Sunny.UI.UIIntegerUpDown numudMaxBookPerPriMember;
        private Sunny.UI.UIIntegerUpDown udnumDefaultDays;
        private Sunny.UI.UIIntegerUpDown numudMaxBookPerMember;
        private Sunny.UI.UIIntegerUpDown numudMaxRenewals;
        private Sunny.UI.UIDoubleUpDown numudDailyFee;
        private Sunny.UI.UIIntegerUpDown numudGracePeriod;
    }
}
