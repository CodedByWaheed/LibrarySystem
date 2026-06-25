namespace LibrarySystem.MainScreen.Loans
{
    partial class ctrlLoanCard
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
            pbBookCover = new ReaLTaiizor.Controls.ParrotPictureBox();
            lRemainDateToReturn = new Label();
            lDueDate = new Label();
            label1 = new Label();
            lBookName = new Label();
            uiPanel1 = new Sunny.UI.UIPanel();
            ((System.ComponentModel.ISupportInitialize)scMain).BeginInit();
            scMain.Panel1.SuspendLayout();
            scMain.Panel2.SuspendLayout();
            scMain.SuspendLayout();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // scMain
            // 
            scMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            scMain.Location = new Point(3, 3);
            scMain.Name = "scMain";
            scMain.Orientation = Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            scMain.Panel1.Controls.Add(pbBookCover);
            // 
            // scMain.Panel2
            // 
            scMain.Panel2.Controls.Add(lRemainDateToReturn);
            scMain.Panel2.Controls.Add(lDueDate);
            scMain.Panel2.Controls.Add(label1);
            scMain.Panel2.Controls.Add(lBookName);
            scMain.Size = new Size(171, 124);
            scMain.SplitterDistance = 68;
            scMain.TabIndex = 0;
            // 
            // pbBookCover
            // 
            pbBookCover.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbBookCover.BackColor = Color.Red;
            pbBookCover.ColorLeft = Color.DodgerBlue;
            pbBookCover.ColorRight = Color.DodgerBlue;
            pbBookCover.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            pbBookCover.FilterAlpha = 200;
            pbBookCover.FilterEnabled = true;
            pbBookCover.Image = null;
            pbBookCover.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            pbBookCover.IsElipse = false;
            pbBookCover.IsParallax = false;
            pbBookCover.Location = new Point(3, 3);
            pbBookCover.Name = "pbBookCover";
            pbBookCover.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            pbBookCover.Size = new Size(73, 62);
            pbBookCover.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pbBookCover.TabIndex = 0;
            pbBookCover.Text = "parrotPictureBox1";
            pbBookCover.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // lRemainDateToReturn
            // 
            lRemainDateToReturn.AutoSize = true;
            lRemainDateToReturn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lRemainDateToReturn.ForeColor = Color.FromArgb(192, 0, 0);
            lRemainDateToReturn.Location = new Point(3, 42);
            lRemainDateToReturn.Name = "lRemainDateToReturn";
            lRemainDateToReturn.Size = new Size(144, 20);
            lRemainDateToReturn.TabIndex = 3;
            lRemainDateToReturn.Text = "3 Days Overdue";
            // 
            // lDueDate
            // 
            lDueDate.AutoSize = true;
            lDueDate.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lDueDate.Location = new Point(96, 22);
            lDueDate.Name = "lDueDate";
            lDueDate.Size = new Size(105, 20);
            lDueDate.TabIndex = 2;
            lDueDate.Text = "xx - xx - xxxx";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 22);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 1;
            label1.Text = "Due Date : ";
            // 
            // lBookName
            // 
            lBookName.AutoSize = true;
            lBookName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lBookName.Location = new Point(-1, -4);
            lBookName.Name = "lBookName";
            lBookName.Size = new Size(123, 25);
            lBookName.TabIndex = 0;
            lBookName.Text = "Book Name";
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(scMain);
            uiPanel1.Dock = DockStyle.Fill;
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(0, 0);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 15;
            uiPanel1.RectColor = Color.Black;
            uiPanel1.Size = new Size(177, 130);
            uiPanel1.TabIndex = 1;
            uiPanel1.Text = "uiPanel1";
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // ctrlLoanCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(uiPanel1);
            Name = "ctrlLoanCard";
            Size = new Size(177, 130);
            scMain.Panel1.ResumeLayout(false);
            scMain.Panel2.ResumeLayout(false);
            scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scMain).EndInit();
            scMain.ResumeLayout(false);
            uiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer scMain;
        private Sunny.UI.UIPanel uiPanel1;
        private ReaLTaiizor.Controls.ParrotPictureBox pbBookCover;
        private Label lBookName;
        private Label lDueDate;
        private Label label1;
        private Label lRemainDateToReturn;
    }
}
