namespace LibrarySystem.MainScreen
{
    partial class ctrlDashboard
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
            scTopMain = new SplitContainer();
            label1 = new Label();
            scBottomTopMain = new SplitContainer();
            scLeftBottomTopMain = new SplitContainer();
            uiPanel1 = new Sunny.UI.UIPanel();
            lTotalBooks = new Label();
            label2 = new Label();
            uiPanel2 = new Sunny.UI.UIPanel();
            lActiveLoans = new Label();
            label4 = new Label();
            scRightBottomTopMain = new SplitContainer();
            uiPanel3 = new Sunny.UI.UIPanel();
            lOverdueItems = new Label();
            label6 = new Label();
            uiPanel4 = new Sunny.UI.UIPanel();
            label10 = new Label();
            lPendingFInes = new Label();
            label8 = new Label();
            scBottomMain = new SplitContainer();
            label9 = new Label();
            scLeftBottomMain = new SplitContainer();
            fpRecentlyActiveBook = new Sunny.UI.UIFlowLayoutPanel();
            ctrlBook2 = new LibrarySystem.MainScreen.Controls.ctrlBookCard();
            ctrlBook1 = new LibrarySystem.MainScreen.Controls.ctrlBookCard();
            uiLineChart1 = new Sunny.UI.UILineChart();
            ctrlBook3 = new LibrarySystem.MainScreen.Controls.ctrlBookCard();
            ctrlBook4 = new LibrarySystem.MainScreen.Controls.ctrlBookCard();
            ctrlBook5 = new LibrarySystem.MainScreen.Controls.ctrlBookCard();
            ((System.ComponentModel.ISupportInitialize)scMain).BeginInit();
            scMain.Panel1.SuspendLayout();
            scMain.Panel2.SuspendLayout();
            scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scTopMain).BeginInit();
            scTopMain.Panel1.SuspendLayout();
            scTopMain.Panel2.SuspendLayout();
            scTopMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scBottomTopMain).BeginInit();
            scBottomTopMain.Panel1.SuspendLayout();
            scBottomTopMain.Panel2.SuspendLayout();
            scBottomTopMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scLeftBottomTopMain).BeginInit();
            scLeftBottomTopMain.Panel1.SuspendLayout();
            scLeftBottomTopMain.Panel2.SuspendLayout();
            scLeftBottomTopMain.SuspendLayout();
            uiPanel1.SuspendLayout();
            uiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scRightBottomTopMain).BeginInit();
            scRightBottomTopMain.Panel1.SuspendLayout();
            scRightBottomTopMain.Panel2.SuspendLayout();
            scRightBottomTopMain.SuspendLayout();
            uiPanel3.SuspendLayout();
            uiPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scBottomMain).BeginInit();
            scBottomMain.Panel1.SuspendLayout();
            scBottomMain.Panel2.SuspendLayout();
            scBottomMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scLeftBottomMain).BeginInit();
            scLeftBottomMain.Panel2.SuspendLayout();
            scLeftBottomMain.SuspendLayout();
            fpRecentlyActiveBook.SuspendLayout();
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
            scMain.Panel1.Controls.Add(scTopMain);
            // 
            // scMain.Panel2
            // 
            scMain.Panel2.Controls.Add(scBottomMain);
            scMain.Size = new Size(796, 409);
            scMain.SplitterDistance = 202;
            scMain.TabIndex = 4;
            // 
            // scTopMain
            // 
            scTopMain.Dock = DockStyle.Fill;
            scTopMain.FixedPanel = FixedPanel.Panel1;
            scTopMain.IsSplitterFixed = true;
            scTopMain.Location = new Point(0, 0);
            scTopMain.Name = "scTopMain";
            scTopMain.Orientation = Orientation.Horizontal;
            // 
            // scTopMain.Panel1
            // 
            scTopMain.Panel1.Controls.Add(label1);
            // 
            // scTopMain.Panel2
            // 
            scTopMain.Panel2.Controls.Add(scBottomTopMain);
            scTopMain.Size = new Size(796, 202);
            scTopMain.SplitterDistance = 63;
            scTopMain.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Tai Le", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 16);
            label1.Name = "label1";
            label1.Size = new Size(149, 36);
            label1.TabIndex = 9;
            label1.Text = "Dashborad";
            // 
            // scBottomTopMain
            // 
            scBottomTopMain.Dock = DockStyle.Fill;
            scBottomTopMain.IsSplitterFixed = true;
            scBottomTopMain.Location = new Point(0, 0);
            scBottomTopMain.Name = "scBottomTopMain";
            // 
            // scBottomTopMain.Panel1
            // 
            scBottomTopMain.Panel1.Controls.Add(scLeftBottomTopMain);
            // 
            // scBottomTopMain.Panel2
            // 
            scBottomTopMain.Panel2.Controls.Add(scRightBottomTopMain);
            scBottomTopMain.Size = new Size(796, 135);
            scBottomTopMain.SplitterDistance = 387;
            scBottomTopMain.TabIndex = 0;
            // 
            // scLeftBottomTopMain
            // 
            scLeftBottomTopMain.Dock = DockStyle.Fill;
            scLeftBottomTopMain.IsSplitterFixed = true;
            scLeftBottomTopMain.Location = new Point(0, 0);
            scLeftBottomTopMain.Name = "scLeftBottomTopMain";
            // 
            // scLeftBottomTopMain.Panel1
            // 
            scLeftBottomTopMain.Panel1.Controls.Add(uiPanel1);
            // 
            // scLeftBottomTopMain.Panel2
            // 
            scLeftBottomTopMain.Panel2.Controls.Add(uiPanel2);
            scLeftBottomTopMain.Size = new Size(387, 135);
            scLeftBottomTopMain.SplitterDistance = 191;
            scLeftBottomTopMain.TabIndex = 0;
            // 
            // uiPanel1
            // 
            uiPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uiPanel1.Controls.Add(lTotalBooks);
            uiPanel1.Controls.Add(label2);
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.ForeDisableColor = Color.Black;
            uiPanel1.Location = new Point(17, 20);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 25;
            uiPanel1.RectColor = Color.Black;
            uiPanel1.RectDisableColor = Color.Black;
            uiPanel1.Size = new Size(158, 94);
            uiPanel1.TabIndex = 10;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lTotalBooks
            // 
            lTotalBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lTotalBooks.AutoSize = true;
            lTotalBooks.Location = new Point(28, 51);
            lTotalBooks.Name = "lTotalBooks";
            lTotalBooks.Size = new Size(72, 25);
            lTotalBooks.TabIndex = 1;
            lTotalBooks.Text = "00,000";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 0;
            label2.Text = "Total Books";
            // 
            // uiPanel2
            // 
            uiPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uiPanel2.Controls.Add(lActiveLoans);
            uiPanel2.Controls.Add(label4);
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel2.ForeDisableColor = Color.Black;
            uiPanel2.Location = new Point(17, 20);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Radius = 25;
            uiPanel2.RectColor = Color.Black;
            uiPanel2.RectDisableColor = Color.Black;
            uiPanel2.Size = new Size(159, 94);
            uiPanel2.TabIndex = 11;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lActiveLoans
            // 
            lActiveLoans.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lActiveLoans.AutoSize = true;
            lActiveLoans.Location = new Point(28, 51);
            lActiveLoans.Name = "lActiveLoans";
            lActiveLoans.Size = new Size(72, 25);
            lActiveLoans.TabIndex = 1;
            lActiveLoans.Text = "00,000";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 9);
            label4.Name = "label4";
            label4.Size = new Size(125, 25);
            label4.TabIndex = 0;
            label4.Text = "Active Loans";
            // 
            // scRightBottomTopMain
            // 
            scRightBottomTopMain.Dock = DockStyle.Fill;
            scRightBottomTopMain.IsSplitterFixed = true;
            scRightBottomTopMain.Location = new Point(0, 0);
            scRightBottomTopMain.Name = "scRightBottomTopMain";
            // 
            // scRightBottomTopMain.Panel1
            // 
            scRightBottomTopMain.Panel1.Controls.Add(uiPanel3);
            // 
            // scRightBottomTopMain.Panel2
            // 
            scRightBottomTopMain.Panel2.Controls.Add(uiPanel4);
            scRightBottomTopMain.Size = new Size(405, 135);
            scRightBottomTopMain.SplitterDistance = 224;
            scRightBottomTopMain.TabIndex = 0;
            // 
            // uiPanel3
            // 
            uiPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uiPanel3.Controls.Add(lOverdueItems);
            uiPanel3.Controls.Add(label6);
            uiPanel3.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel3.ForeDisableColor = Color.Black;
            uiPanel3.Location = new Point(35, 20);
            uiPanel3.Margin = new Padding(4, 5, 4, 5);
            uiPanel3.MinimumSize = new Size(1, 1);
            uiPanel3.Name = "uiPanel3";
            uiPanel3.Radius = 25;
            uiPanel3.RectColor = Color.Black;
            uiPanel3.RectDisableColor = Color.Black;
            uiPanel3.Size = new Size(156, 94);
            uiPanel3.TabIndex = 12;
            uiPanel3.Text = null;
            uiPanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lOverdueItems
            // 
            lOverdueItems.AutoSize = true;
            lOverdueItems.Location = new Point(28, 51);
            lOverdueItems.Name = "lOverdueItems";
            lOverdueItems.Size = new Size(72, 25);
            lOverdueItems.TabIndex = 1;
            lOverdueItems.Text = "00,000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 9);
            label6.Name = "label6";
            label6.Size = new Size(140, 25);
            label6.TabIndex = 0;
            label6.Text = "Overdue Items";
            // 
            // uiPanel4
            // 
            uiPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uiPanel4.Controls.Add(label10);
            uiPanel4.Controls.Add(lPendingFInes);
            uiPanel4.Controls.Add(label8);
            uiPanel4.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel4.ForeDisableColor = Color.Black;
            uiPanel4.Location = new Point(8, 20);
            uiPanel4.Margin = new Padding(4, 5, 4, 5);
            uiPanel4.MinimumSize = new Size(1, 1);
            uiPanel4.Name = "uiPanel4";
            uiPanel4.Radius = 25;
            uiPanel4.RectColor = Color.Black;
            uiPanel4.RectDisableColor = Color.Black;
            uiPanel4.Size = new Size(161, 94);
            uiPanel4.TabIndex = 13;
            uiPanel4.Text = null;
            uiPanel4.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 51);
            label10.Name = "label10";
            label10.Size = new Size(23, 25);
            label10.TabIndex = 2;
            label10.Text = "$";
            // 
            // lPendingFInes
            // 
            lPendingFInes.AutoSize = true;
            lPendingFInes.Location = new Point(28, 51);
            lPendingFInes.Name = "lPendingFInes";
            lPendingFInes.Size = new Size(72, 25);
            lPendingFInes.TabIndex = 1;
            lPendingFInes.Text = "00,000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 9);
            label8.Name = "label8";
            label8.Size = new Size(141, 25);
            label8.TabIndex = 0;
            label8.Text = "Pending Fine's";
            // 
            // scBottomMain
            // 
            scBottomMain.Dock = DockStyle.Fill;
            scBottomMain.Location = new Point(0, 0);
            scBottomMain.Name = "scBottomMain";
            // 
            // scBottomMain.Panel1
            // 
            scBottomMain.Panel1.Controls.Add(label9);
            scBottomMain.Panel1.Controls.Add(scLeftBottomMain);
            // 
            // scBottomMain.Panel2
            // 
            scBottomMain.Panel2.Controls.Add(uiLineChart1);
            scBottomMain.Size = new Size(796, 203);
            scBottomMain.SplitterDistance = 434;
            scBottomMain.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Tai Le", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(21, 8);
            label9.Name = "label9";
            label9.Size = new Size(274, 36);
            label9.TabIndex = 10;
            label9.Text = "Recently Active Book";
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
            // scLeftBottomMain.Panel2
            // 
            scLeftBottomMain.Panel2.Controls.Add(fpRecentlyActiveBook);
            scLeftBottomMain.Size = new Size(434, 203);
            scLeftBottomMain.SplitterDistance = 53;
            scLeftBottomMain.TabIndex = 0;
            // 
            // fpRecentlyActiveBook
            // 
            fpRecentlyActiveBook.Controls.Add(ctrlBook5);
            fpRecentlyActiveBook.Controls.Add(ctrlBook4);
            fpRecentlyActiveBook.Controls.Add(ctrlBook3);
            fpRecentlyActiveBook.Controls.Add(ctrlBook2);
            fpRecentlyActiveBook.Controls.Add(ctrlBook1);
            fpRecentlyActiveBook.Dock = DockStyle.Fill;
            fpRecentlyActiveBook.FillColor = SystemColors.Control;
            fpRecentlyActiveBook.Font = new Font("Microsoft Sans Serif", 12F);
            fpRecentlyActiveBook.Location = new Point(0, 0);
            fpRecentlyActiveBook.Margin = new Padding(4, 5, 4, 5);
            fpRecentlyActiveBook.MinimumSize = new Size(1, 1);
            fpRecentlyActiveBook.Name = "fpRecentlyActiveBook";
            fpRecentlyActiveBook.Padding = new Padding(2);
            fpRecentlyActiveBook.RectColor = Color.White;
            fpRecentlyActiveBook.ShowText = false;
            fpRecentlyActiveBook.Size = new Size(434, 146);
            fpRecentlyActiveBook.TabIndex = 0;
            fpRecentlyActiveBook.Text = "uiFlowLayoutPanel1";
            fpRecentlyActiveBook.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // ctrlBook2
            // 
            ctrlBook2.Location = new Point(99, 5);
            ctrlBook2.Name = "ctrlBook2";
            ctrlBook2.Size = new Size(196, 262);
            ctrlBook2.TabIndex = 4;
            // 
            // ctrlBook1
            // 
            ctrlBook1.Location = new Point(21, 0);
            ctrlBook1.Name = "ctrlBook1";
            ctrlBook1.Size = new Size(196, 262);
            ctrlBook1.TabIndex = 3;
            // 
            // uiLineChart1
            // 
            uiLineChart1.BackColor = SystemColors.Control;
            uiLineChart1.Dock = DockStyle.Fill;
            uiLineChart1.FillColor = SystemColors.Control;
            uiLineChart1.Font = new Font("Microsoft Sans Serif", 12F);
            uiLineChart1.LegendFont = new Font("Microsoft Sans Serif", 9F);
            uiLineChart1.Location = new Point(0, 0);
            uiLineChart1.MinimumSize = new Size(1, 1);
            uiLineChart1.MouseDownType = Sunny.UI.UILineChartMouseDownType.Zoom;
            uiLineChart1.Name = "uiLineChart1";
            uiLineChart1.RectColor = Color.White;
            uiLineChart1.Size = new Size(358, 203);
            uiLineChart1.SubFont = new Font("Microsoft Sans Serif", 9F);
            uiLineChart1.TabIndex = 0;
            uiLineChart1.Text = "uiLineChart1";
            // 
            // ctrlBook3
            // 
            ctrlBook3.Location = new Point(144, -10);
            ctrlBook3.Name = "ctrlBook3";
            ctrlBook3.Size = new Size(196, 262);
            ctrlBook3.TabIndex = 5;
            // 
            // ctrlBook4
            // 
            ctrlBook4.Location = new Point(119, -58);
            ctrlBook4.Name = "ctrlBook4";
            ctrlBook4.Size = new Size(196, 262);
            ctrlBook4.TabIndex = 6;
            // 
            // ctrlBook5
            // 
            ctrlBook5.Location = new Point(191, -31);
            ctrlBook5.Name = "ctrlBook5";
            ctrlBook5.Size = new Size(196, 262);
            ctrlBook5.TabIndex = 7;
            // 
            // ctrlDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(scMain);
            Name = "ctrlDashboard";
            Size = new Size(796, 409);
            scMain.Panel1.ResumeLayout(false);
            scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scMain).EndInit();
            scMain.ResumeLayout(false);
            scTopMain.Panel1.ResumeLayout(false);
            scTopMain.Panel1.PerformLayout();
            scTopMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scTopMain).EndInit();
            scTopMain.ResumeLayout(false);
            scBottomTopMain.Panel1.ResumeLayout(false);
            scBottomTopMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scBottomTopMain).EndInit();
            scBottomTopMain.ResumeLayout(false);
            scLeftBottomTopMain.Panel1.ResumeLayout(false);
            scLeftBottomTopMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scLeftBottomTopMain).EndInit();
            scLeftBottomTopMain.ResumeLayout(false);
            uiPanel1.ResumeLayout(false);
            uiPanel1.PerformLayout();
            uiPanel2.ResumeLayout(false);
            uiPanel2.PerformLayout();
            scRightBottomTopMain.Panel1.ResumeLayout(false);
            scRightBottomTopMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scRightBottomTopMain).EndInit();
            scRightBottomTopMain.ResumeLayout(false);
            uiPanel3.ResumeLayout(false);
            uiPanel3.PerformLayout();
            uiPanel4.ResumeLayout(false);
            uiPanel4.PerformLayout();
            scBottomMain.Panel1.ResumeLayout(false);
            scBottomMain.Panel1.PerformLayout();
            scBottomMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scBottomMain).EndInit();
            scBottomMain.ResumeLayout(false);
            scLeftBottomMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scLeftBottomMain).EndInit();
            scLeftBottomMain.ResumeLayout(false);
            fpRecentlyActiveBook.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private SplitContainer scMain;
        private SplitContainer scTopMain;
        private Sunny.UI.UIPanel uiPanel2;
        private Label lActiveLoans;
        private Label label4;
        private Sunny.UI.UIPanel uiPanel3;
        private Label lOverdueItems;
        private Label label6;
        private Sunny.UI.UIPanel uiPanel4;
        private Label lPendingFInes;
        private Label label8;
        private Sunny.UI.UIPanel uiPanel1;
        private Label lTotalBooks;
        private Label label2;
        private Label label1;
        private SplitContainer scBottomTopMain;
        private SplitContainer scLeftBottomTopMain;
        private SplitContainer scRightBottomTopMain;
        private SplitContainer scLeftBottomMain;
        private Label label9;
        private SplitContainer scBottomMain;
        private Sunny.UI.UILineChart uiLineChart1;
        private Label label10;
        private Sunny.UI.UIFlowLayoutPanel fpRecentlyActiveBook;
        private Controls.ctrlBookCard ctrlBook2;
        private Controls.ctrlBookCard ctrlBook1;
        private Controls.ctrlBookCard ctrlBook5;
        private Controls.ctrlBookCard ctrlBook4;
        private Controls.ctrlBookCard ctrlBook3;
    }
}
