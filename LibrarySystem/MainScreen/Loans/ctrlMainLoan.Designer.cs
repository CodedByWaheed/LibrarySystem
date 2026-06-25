namespace LibrarySystem.MainScreen.Loans
{
    partial class ctrlMainLoan
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
            uiPanel1 = new Sunny.UI.UIPanel();
            ctrlMemberCard1 = new LibrarySystem.MainScreen.Members.ctrlMemberCard();
            tbSearchMember = new Sunny.UI.UITextBox();
            uiPanel2 = new Sunny.UI.UIPanel();
            ctrlBookCardExtended1 = new LibrarySystem.MainScreen.Books.ctrlBookCardExtended();
            tbSearchBook = new Sunny.UI.UITextBox();
            lDueDate = new Label();
            label1 = new Label();
            btnExtendLoan = new Sunny.UI.UIButton();
            btnReturnBook = new Sunny.UI.UIButton();
            btnIssueLoan = new Sunny.UI.UIButton();
            separator1 = new ReaLTaiizor.Controls.Separator();
            ((System.ComponentModel.ISupportInitialize)scMain).BeginInit();
            scMain.Panel1.SuspendLayout();
            scMain.Panel2.SuspendLayout();
            scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scTopMain).BeginInit();
            scTopMain.Panel1.SuspendLayout();
            scTopMain.Panel2.SuspendLayout();
            scTopMain.SuspendLayout();
            uiPanel1.SuspendLayout();
            uiPanel2.SuspendLayout();
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
            scMain.Panel2.Controls.Add(lDueDate);
            scMain.Panel2.Controls.Add(label1);
            scMain.Panel2.Controls.Add(btnExtendLoan);
            scMain.Panel2.Controls.Add(btnReturnBook);
            scMain.Panel2.Controls.Add(btnIssueLoan);
            scMain.Panel2.Controls.Add(separator1);
            scMain.Size = new Size(917, 496);
            scMain.SplitterDistance = 354;
            scMain.TabIndex = 0;
            // 
            // scTopMain
            // 
            scTopMain.Dock = DockStyle.Fill;
            scTopMain.Location = new Point(0, 0);
            scTopMain.Name = "scTopMain";
            // 
            // scTopMain.Panel1
            // 
            scTopMain.Panel1.Controls.Add(uiPanel1);
            scTopMain.Panel1.Controls.Add(tbSearchMember);
            // 
            // scTopMain.Panel2
            // 
            scTopMain.Panel2.Controls.Add(uiPanel2);
            scTopMain.Panel2.Controls.Add(tbSearchBook);
            scTopMain.Size = new Size(917, 354);
            scTopMain.SplitterDistance = 454;
            scTopMain.TabIndex = 0;
            // 
            // uiPanel1
            // 
            uiPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiPanel1.BackColor = Color.Transparent;
            uiPanel1.Controls.Add(ctrlMemberCard1);
            uiPanel1.FillColor = Color.Transparent;
            uiPanel1.FillColor2 = Color.Transparent;
            uiPanel1.FillDisableColor = Color.Transparent;
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(24, 62);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.RectColor = Color.Transparent;
            uiPanel1.RectDisableColor = Color.Transparent;
            uiPanel1.Size = new Size(406, 287);
            uiPanel1.TabIndex = 1;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // ctrlMemberCard1
            // 
            ctrlMemberCard1.BackColor = Color.White;
            ctrlMemberCard1.Border = Members.ctrlMemberCard.enBorder.Visible;
            ctrlMemberCard1.Dock = DockStyle.Top;
            ctrlMemberCard1.Location = new Point(0, 0);
            ctrlMemberCard1.Name = "ctrlMemberCard1";
            ctrlMemberCard1.Size = new Size(406, 226);
            ctrlMemberCard1.TabIndex = 0;
            // 
            // tbSearchMember
            // 
            tbSearchMember.Font = new Font("Microsoft Sans Serif", 12F);
            tbSearchMember.Icon = Properties.Resources.search;
            tbSearchMember.Location = new Point(24, 16);
            tbSearchMember.Margin = new Padding(4, 5, 4, 5);
            tbSearchMember.MinimumSize = new Size(1, 16);
            tbSearchMember.Name = "tbSearchMember";
            tbSearchMember.Padding = new Padding(5);
            tbSearchMember.Radius = 15;
            tbSearchMember.RectColor = Color.Black;
            tbSearchMember.ShowText = false;
            tbSearchMember.Size = new Size(406, 36);
            tbSearchMember.TabIndex = 0;
            tbSearchMember.TextAlignment = ContentAlignment.MiddleLeft;
            tbSearchMember.Watermark = "Search Member (Name Or ID) ...";
            // 
            // uiPanel2
            // 
            uiPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiPanel2.Controls.Add(ctrlBookCardExtended1);
            uiPanel2.FillColor = Color.Transparent;
            uiPanel2.FillColor2 = Color.Transparent;
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel2.Location = new Point(26, 62);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.RectColor = Color.Transparent;
            uiPanel2.Size = new Size(406, 287);
            uiPanel2.TabIndex = 2;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // ctrlBookCardExtended1
            // 
            ctrlBookCardExtended1.Dock = DockStyle.Top;
            ctrlBookCardExtended1.Location = new Point(0, 0);
            ctrlBookCardExtended1.Name = "ctrlBookCardExtended1";
            ctrlBookCardExtended1.Size = new Size(406, 259);
            ctrlBookCardExtended1.TabIndex = 0;
            // 
            // tbSearchBook
            // 
            tbSearchBook.Font = new Font("Microsoft Sans Serif", 12F);
            tbSearchBook.Icon = Properties.Resources.search;
            tbSearchBook.Location = new Point(26, 16);
            tbSearchBook.Margin = new Padding(4, 5, 4, 5);
            tbSearchBook.MinimumSize = new Size(1, 16);
            tbSearchBook.Name = "tbSearchBook";
            tbSearchBook.Padding = new Padding(5);
            tbSearchBook.Radius = 15;
            tbSearchBook.RectColor = Color.Black;
            tbSearchBook.ShowText = false;
            tbSearchBook.Size = new Size(406, 36);
            tbSearchBook.TabIndex = 1;
            tbSearchBook.TextAlignment = ContentAlignment.MiddleLeft;
            tbSearchBook.Watermark = "Search Book  (Title , Author or ISBN ) ....";
            // 
            // lDueDate
            // 
            lDueDate.Anchor = AnchorStyles.Top;
            lDueDate.AutoSize = true;
            lDueDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lDueDate.Location = new Point(457, 20);
            lDueDate.Name = "lDueDate";
            lDueDate.Size = new Size(120, 28);
            lDueDate.TabIndex = 11;
            lDueDate.Text = "xx - xx - xxxx";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(339, 20);
            label1.Name = "label1";
            label1.Size = new Size(112, 28);
            label1.TabIndex = 10;
            label1.Text = "Due Date :";
            // 
            // btnExtendLoan
            // 
            btnExtendLoan.Anchor = AnchorStyles.Top;
            btnExtendLoan.FillColor = Color.White;
            btnExtendLoan.Font = new Font("Microsoft Sans Serif", 12F);
            btnExtendLoan.ForeColor = Color.Black;
            btnExtendLoan.Location = new Point(545, 69);
            btnExtendLoan.MinimumSize = new Size(1, 1);
            btnExtendLoan.Name = "btnExtendLoan";
            btnExtendLoan.Radius = 20;
            btnExtendLoan.RectColor = Color.Black;
            btnExtendLoan.Size = new Size(125, 44);
            btnExtendLoan.TabIndex = 9;
            btnExtendLoan.Text = "Extend Loan";
            btnExtendLoan.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // btnReturnBook
            // 
            btnReturnBook.Anchor = AnchorStyles.Top;
            btnReturnBook.FillColor = Color.White;
            btnReturnBook.Font = new Font("Microsoft Sans Serif", 12F);
            btnReturnBook.ForeColor = Color.Black;
            btnReturnBook.Location = new Point(395, 69);
            btnReturnBook.MinimumSize = new Size(1, 1);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Radius = 20;
            btnReturnBook.RectColor = Color.Black;
            btnReturnBook.Size = new Size(125, 44);
            btnReturnBook.TabIndex = 8;
            btnReturnBook.Text = "Return Book";
            btnReturnBook.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // btnIssueLoan
            // 
            btnIssueLoan.Anchor = AnchorStyles.Top;
            btnIssueLoan.Font = new Font("Microsoft Sans Serif", 12F);
            btnIssueLoan.Location = new Point(247, 69);
            btnIssueLoan.MinimumSize = new Size(1, 1);
            btnIssueLoan.Name = "btnIssueLoan";
            btnIssueLoan.Radius = 20;
            btnIssueLoan.Size = new Size(125, 44);
            btnIssueLoan.TabIndex = 7;
            btnIssueLoan.Text = "Issue Loan";
            btnIssueLoan.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // separator1
            // 
            separator1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            separator1.LineColor = Color.Silver;
            separator1.Location = new Point(83, 3);
            separator1.Name = "separator1";
            separator1.Size = new Size(751, 10);
            separator1.TabIndex = 0;
            separator1.Text = "separator1";
            // 
            // ctrlMainLoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(scMain);
            Name = "ctrlMainLoan";
            Size = new Size(917, 496);
            scMain.Panel1.ResumeLayout(false);
            scMain.Panel2.ResumeLayout(false);
            scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scMain).EndInit();
            scMain.ResumeLayout(false);
            scTopMain.Panel1.ResumeLayout(false);
            scTopMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scTopMain).EndInit();
            scTopMain.ResumeLayout(false);
            uiPanel1.ResumeLayout(false);
            uiPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer scMain;
        private ReaLTaiizor.Controls.Separator separator1;
        private Sunny.UI.UITextBox tbSearchMember;
        private SplitContainer scTopMain;
        private Sunny.UI.UITextBox tbSearchBook;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIButton btnExtendLoan;
        private Sunny.UI.UIButton btnReturnBook;
        private Sunny.UI.UIButton btnIssueLoan;
        private Label lDueDate;
        private Label label1;
        private Sunny.UI.UIPanel uiPanel1;
        private Members.ctrlMemberCard ctrlMemberCard1;
        private Books.ctrlBookCardExtended ctrlBookCardExtended1;
    }
}
