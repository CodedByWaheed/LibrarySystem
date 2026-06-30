namespace LibrarySystem.MainScreen.Members
{
    partial class ctrlMemberCardExtended
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
            ctrlMemberCard2 = new ctrlMemberCard();
            spBottomMain = new SplitContainer();
            spTopBottomMain = new SplitContainer();
            crownLabel2 = new ReaLTaiizor.Controls.CrownLabel();
            crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            lNumLoanBook = new ReaLTaiizor.Controls.CrownLabel();
            lFullName = new ReaLTaiizor.Controls.BigLabel();
            flpActiveLoans = new Sunny.UI.UIFlowLayoutPanel();
            scBottomBottomMain = new SplitContainer();
            crownLabel3 = new ReaLTaiizor.Controls.CrownLabel();
            crownLabel4 = new ReaLTaiizor.Controls.CrownLabel();
            crownLabel5 = new ReaLTaiizor.Controls.CrownLabel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            flpFines = new Sunny.UI.UIFlowLayoutPanel();
            ctrlLoanCard1 = new LibrarySystem.MainScreen.Loans.ctrlLoanCard();
            ctrlLoanCard2 = new LibrarySystem.MainScreen.Loans.ctrlLoanCard();
            ctrlLoanCard3 = new LibrarySystem.MainScreen.Loans.ctrlLoanCard();
            ctrlFinesCard1 = new LibrarySystem.MainScreen.Fines.ctrlFinesCard();
            ((System.ComponentModel.ISupportInitialize)scMain).BeginInit();
            scMain.Panel1.SuspendLayout();
            scMain.Panel2.SuspendLayout();
            scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spBottomMain).BeginInit();
            spBottomMain.Panel1.SuspendLayout();
            spBottomMain.Panel2.SuspendLayout();
            spBottomMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spTopBottomMain).BeginInit();
            spTopBottomMain.Panel1.SuspendLayout();
            spTopBottomMain.Panel2.SuspendLayout();
            spTopBottomMain.SuspendLayout();
            flpActiveLoans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scBottomBottomMain).BeginInit();
            scBottomBottomMain.Panel1.SuspendLayout();
            scBottomBottomMain.Panel2.SuspendLayout();
            scBottomBottomMain.SuspendLayout();
            flpFines.SuspendLayout();
            SuspendLayout();
            // 
            // scMain
            // 
            scMain.Dock = DockStyle.Fill;
            scMain.FixedPanel = FixedPanel.Panel1;
            scMain.Location = new Point(0, 0);
            scMain.Name = "scMain";
            scMain.Orientation = Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            scMain.Panel1.Controls.Add(ctrlMemberCard2);
            // 
            // scMain.Panel2
            // 
            scMain.Panel2.Controls.Add(spBottomMain);
            scMain.Size = new Size(931, 721);
            scMain.SplitterDistance = 199;
            scMain.TabIndex = 0;
            scMain.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // ctrlMemberCard2
            // 
            ctrlMemberCard2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ctrlMemberCard2.BackColor = Color.White;
            ctrlMemberCard2.Border = ctrlMemberCard.enBorder.Visible;
            ctrlMemberCard2.Location = new Point(39, 12);
            ctrlMemberCard2.Name = "ctrlMemberCard2";
            ctrlMemberCard2.Size = new Size(852, 177);
            ctrlMemberCard2.TabIndex = 0;
            // 
            // spBottomMain
            // 
            spBottomMain.Dock = DockStyle.Fill;
            spBottomMain.Location = new Point(0, 0);
            spBottomMain.Name = "spBottomMain";
            spBottomMain.Orientation = Orientation.Horizontal;
            // 
            // spBottomMain.Panel1
            // 
            spBottomMain.Panel1.Controls.Add(spTopBottomMain);
            // 
            // spBottomMain.Panel2
            // 
            spBottomMain.Panel2.Controls.Add(scBottomBottomMain);
            spBottomMain.Size = new Size(931, 518);
            spBottomMain.SplitterDistance = 256;
            spBottomMain.TabIndex = 0;
            // 
            // spTopBottomMain
            // 
            spTopBottomMain.Dock = DockStyle.Fill;
            spTopBottomMain.FixedPanel = FixedPanel.Panel1;
            spTopBottomMain.Location = new Point(0, 0);
            spTopBottomMain.Name = "spTopBottomMain";
            spTopBottomMain.Orientation = Orientation.Horizontal;
            // 
            // spTopBottomMain.Panel1
            // 
            spTopBottomMain.Panel1.Controls.Add(crownLabel2);
            spTopBottomMain.Panel1.Controls.Add(crownLabel1);
            spTopBottomMain.Panel1.Controls.Add(lNumLoanBook);
            spTopBottomMain.Panel1.Controls.Add(lFullName);
            spTopBottomMain.Panel1.Paint += spTopBottomMain_Panel1_Paint;
            // 
            // spTopBottomMain.Panel2
            // 
            spTopBottomMain.Panel2.Controls.Add(flpActiveLoans);
            spTopBottomMain.Size = new Size(931, 256);
            spTopBottomMain.SplitterDistance = 42;
            spTopBottomMain.TabIndex = 0;
            // 
            // crownLabel2
            // 
            crownLabel2.Anchor = AnchorStyles.Left;
            crownLabel2.AutoSize = true;
            crownLabel2.BackColor = Color.Transparent;
            crownLabel2.Font = new Font("Segoe UI", 10.8F);
            crownLabel2.ForeColor = Color.Gray;
            crownLabel2.Location = new Point(318, 9);
            crownLabel2.Name = "crownLabel2";
            crownLabel2.Size = new Size(71, 25);
            crownLabel2.TabIndex = 11;
            crownLabel2.Text = "Books )";
            // 
            // crownLabel1
            // 
            crownLabel1.Anchor = AnchorStyles.Left;
            crownLabel1.AutoSize = true;
            crownLabel1.BackColor = Color.Transparent;
            crownLabel1.Font = new Font("Segoe UI", 10.8F);
            crownLabel1.ForeColor = Color.Gray;
            crownLabel1.Location = new Point(282, 9);
            crownLabel1.Name = "crownLabel1";
            crownLabel1.Size = new Size(17, 25);
            crownLabel1.TabIndex = 10;
            crownLabel1.Text = "(";
            // 
            // lNumLoanBook
            // 
            lNumLoanBook.Anchor = AnchorStyles.Left;
            lNumLoanBook.AutoSize = true;
            lNumLoanBook.BackColor = Color.Transparent;
            lNumLoanBook.Font = new Font("Segoe UI", 10.8F);
            lNumLoanBook.ForeColor = Color.Gray;
            lNumLoanBook.Location = new Point(296, 9);
            lNumLoanBook.Name = "lNumLoanBook";
            lNumLoanBook.Size = new Size(20, 25);
            lNumLoanBook.TabIndex = 9;
            lNumLoanBook.Text = "x";
            // 
            // lFullName
            // 
            lFullName.Anchor = AnchorStyles.Left;
            lFullName.AutoSize = true;
            lFullName.BackColor = Color.Transparent;
            lFullName.Font = new Font("Segoe UI", 25F);
            lFullName.ForeColor = Color.Black;
            lFullName.Location = new Point(29, -11);
            lFullName.Name = "lFullName";
            lFullName.Size = new Size(269, 57);
            lFullName.TabIndex = 8;
            lFullName.Text = "Active Loans ";
            // 
            // flpActiveLoans
            // 
            flpActiveLoans.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpActiveLoans.Controls.Add(ctrlLoanCard3);
            flpActiveLoans.Controls.Add(ctrlLoanCard2);
            flpActiveLoans.Controls.Add(ctrlLoanCard1);
            flpActiveLoans.FillColor = Color.White;
            flpActiveLoans.FillColor2 = Color.White;
            flpActiveLoans.Font = new Font("Microsoft Sans Serif", 12F);
            flpActiveLoans.Location = new Point(17, 5);
            flpActiveLoans.Margin = new Padding(4, 5, 4, 5);
            flpActiveLoans.MinimumSize = new Size(1, 1);
            flpActiveLoans.Name = "flpActiveLoans";
            flpActiveLoans.Padding = new Padding(2);
            flpActiveLoans.RectColor = Color.Transparent;
            flpActiveLoans.ShowText = false;
            flpActiveLoans.Size = new Size(890, 200);
            flpActiveLoans.TabIndex = 0;
            flpActiveLoans.Text = "uiFlowLayoutPanel1";
            flpActiveLoans.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // scBottomBottomMain
            // 
            scBottomBottomMain.Dock = DockStyle.Fill;
            scBottomBottomMain.FixedPanel = FixedPanel.Panel1;
            scBottomBottomMain.Location = new Point(0, 0);
            scBottomBottomMain.Name = "scBottomBottomMain";
            scBottomBottomMain.Orientation = Orientation.Horizontal;
            // 
            // scBottomBottomMain.Panel1
            // 
            scBottomBottomMain.Panel1.Controls.Add(crownLabel3);
            scBottomBottomMain.Panel1.Controls.Add(crownLabel4);
            scBottomBottomMain.Panel1.Controls.Add(crownLabel5);
            scBottomBottomMain.Panel1.Controls.Add(bigLabel1);
            // 
            // scBottomBottomMain.Panel2
            // 
            scBottomBottomMain.Panel2.Controls.Add(flpFines);
            scBottomBottomMain.Size = new Size(931, 258);
            scBottomBottomMain.SplitterDistance = 43;
            scBottomBottomMain.TabIndex = 1;
            // 
            // crownLabel3
            // 
            crownLabel3.Anchor = AnchorStyles.Left;
            crownLabel3.AutoSize = true;
            crownLabel3.BackColor = Color.Transparent;
            crownLabel3.Font = new Font("Segoe UI", 10.8F);
            crownLabel3.ForeColor = Color.Gray;
            crownLabel3.Location = new Point(182, 9);
            crownLabel3.Name = "crownLabel3";
            crownLabel3.Size = new Size(62, 25);
            crownLabel3.TabIndex = 15;
            crownLabel3.Text = "Fines )";
            // 
            // crownLabel4
            // 
            crownLabel4.Anchor = AnchorStyles.Left;
            crownLabel4.AutoSize = true;
            crownLabel4.BackColor = Color.Transparent;
            crownLabel4.Font = new Font("Segoe UI", 10.8F);
            crownLabel4.ForeColor = Color.Gray;
            crownLabel4.Location = new Point(146, 9);
            crownLabel4.Name = "crownLabel4";
            crownLabel4.Size = new Size(17, 25);
            crownLabel4.TabIndex = 14;
            crownLabel4.Text = "(";
            // 
            // crownLabel5
            // 
            crownLabel5.Anchor = AnchorStyles.Left;
            crownLabel5.AutoSize = true;
            crownLabel5.BackColor = Color.Transparent;
            crownLabel5.Font = new Font("Segoe UI", 10.8F);
            crownLabel5.ForeColor = Color.Gray;
            crownLabel5.Location = new Point(160, 9);
            crownLabel5.Name = "crownLabel5";
            crownLabel5.Size = new Size(20, 25);
            crownLabel5.TabIndex = 13;
            crownLabel5.Text = "x";
            // 
            // bigLabel1
            // 
            bigLabel1.Anchor = AnchorStyles.Left;
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.Black;
            bigLabel1.Location = new Point(29, -14);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(120, 57);
            bigLabel1.TabIndex = 12;
            bigLabel1.Text = "Fines";
            // 
            // flpFines
            // 
            flpFines.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpFines.Controls.Add(ctrlFinesCard1);
            flpFines.FillColor = Color.White;
            flpFines.FillColor2 = Color.White;
            flpFines.Font = new Font("Microsoft Sans Serif", 12F);
            flpFines.Location = new Point(20, 7);
            flpFines.Margin = new Padding(4, 5, 4, 5);
            flpFines.MinimumSize = new Size(1, 1);
            flpFines.Name = "flpFines";
            flpFines.Padding = new Padding(2);
            flpFines.Radius = 15;
            flpFines.RectColor = Color.Transparent;
            flpFines.ShowText = false;
            flpFines.Size = new Size(890, 197);
            flpFines.TabIndex = 1;
            flpFines.Text = "uiFlowLayoutPanel2";
            flpFines.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // ctrlLoanCard1
            // 
            ctrlLoanCard1.Location = new Point(12, 15);
            ctrlLoanCard1.Name = "ctrlLoanCard1";
            ctrlLoanCard1.Size = new Size(221, 162);
            ctrlLoanCard1.TabIndex = 3;
            // 
            // ctrlLoanCard2
            // 
            ctrlLoanCard2.Location = new Point(335, 19);
            ctrlLoanCard2.Name = "ctrlLoanCard2";
            ctrlLoanCard2.Size = new Size(221, 162);
            ctrlLoanCard2.TabIndex = 4;
            // 
            // ctrlLoanCard3
            // 
            ctrlLoanCard3.Location = new Point(343, 27);
            ctrlLoanCard3.Name = "ctrlLoanCard3";
            ctrlLoanCard3.Size = new Size(221, 162);
            ctrlLoanCard3.TabIndex = 5;
            // 
            // ctrlFinesCard1
            // 
            ctrlFinesCard1.Border = Fines.ctrlFinesCard.enBorder.Visible;
            ctrlFinesCard1.Location = new Point(76, 59);
            ctrlFinesCard1.Name = "ctrlFinesCard1";
            ctrlFinesCard1.Size = new Size(221, 162);
            ctrlFinesCard1.TabIndex = 3;
            // 
            // ctrlMainMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(scMain);
            Name = "ctrlMainMember";
            Size = new Size(931, 721);
            scMain.Panel1.ResumeLayout(false);
            scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scMain).EndInit();
            scMain.ResumeLayout(false);
            spBottomMain.Panel1.ResumeLayout(false);
            spBottomMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spBottomMain).EndInit();
            spBottomMain.ResumeLayout(false);
            spTopBottomMain.Panel1.ResumeLayout(false);
            spTopBottomMain.Panel1.PerformLayout();
            spTopBottomMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spTopBottomMain).EndInit();
            spTopBottomMain.ResumeLayout(false);
            flpActiveLoans.ResumeLayout(false);
            scBottomBottomMain.Panel1.ResumeLayout(false);
            scBottomBottomMain.Panel1.PerformLayout();
            scBottomBottomMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scBottomBottomMain).EndInit();
            scBottomBottomMain.ResumeLayout(false);
            flpFines.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer scMain;
        private SplitContainer spBottomMain;
        private SplitContainer spTopBottomMain;
        private SplitContainer scBottomBottomMain;
        private ctrlMemberCard ctrlMemberCard1;
        private ReaLTaiizor.Controls.BigLabel lFullName;
        private ReaLTaiizor.Controls.CrownLabel crownLabel2;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
        private ReaLTaiizor.Controls.CrownLabel lNumLoanBook;
        private ReaLTaiizor.Controls.CrownLabel crownLabel3;
        private ReaLTaiizor.Controls.CrownLabel crownLabel4;
        private ReaLTaiizor.Controls.CrownLabel crownLabel5;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Sunny.UI.UIFlowLayoutPanel flpActiveLoans;
        private Sunny.UI.UIFlowLayoutPanel flpFines;
        private ctrlMemberCard ctrlMemberCard2;
        private Loans.ctrlLoanCard ctrlLoanCard3;
        private Loans.ctrlLoanCard ctrlLoanCard2;
        private Loans.ctrlLoanCard ctrlLoanCard1;
        private Fines.ctrlFinesCard ctrlFinesCard1;
    }
}
