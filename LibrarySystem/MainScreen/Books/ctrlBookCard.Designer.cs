namespace LibrarySystem.MainScreen.Controls
{
    partial class ctrlBookCard
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
            pbBookCover = new ReaLTaiizor.Controls.ParrotPictureBox();
            sbStatusBook = new Sunny.UI.UIStatusBox();
            lBookAuthor = new Label();
            lBookTitle = new Label();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scMain).BeginInit();
            scMain.Panel1.SuspendLayout();
            scMain.Panel2.SuspendLayout();
            scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sbStatusBook).BeginInit();
            SuspendLayout();
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
            uiPanel1.Radius = 10;
            uiPanel1.RectColor = Color.Black;
            uiPanel1.Size = new Size(133, 166);
            uiPanel1.TabIndex = 0;
            uiPanel1.Text = "uiPanel1";
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
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
            scMain.Panel2.Controls.Add(sbStatusBook);
            scMain.Panel2.Controls.Add(lBookAuthor);
            scMain.Panel2.Controls.Add(lBookTitle);
            scMain.Size = new Size(127, 158);
            scMain.SplitterDistance = 110;
            scMain.TabIndex = 1;
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
            pbBookCover.Location = new Point(10, 7);
            pbBookCover.Name = "pbBookCover";
            pbBookCover.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            pbBookCover.Size = new Size(108, 100);
            pbBookCover.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pbBookCover.TabIndex = 0;
            pbBookCover.Text = "parrotPictureBox1";
            pbBookCover.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // sbStatusBook
            // 
            sbStatusBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            sbStatusBook.BackColor = Color.Transparent;
            sbStatusBook.Location = new Point(82, 7);
            sbStatusBook.Name = "sbStatusBook";
            sbStatusBook.Size = new Size(45, 43);
            sbStatusBook.SizeMode = PictureBoxSizeMode.StretchImage;
            sbStatusBook.Status = 1;
            sbStatusBook.Status1 = Properties.Resources.Available_512;
            sbStatusBook.Status2 = Properties.Resources.Borrowed_512;
            sbStatusBook.Status3 = Properties.Resources.reserved512;
            sbStatusBook.Status4 = Properties.Resources.Damaged512;
            sbStatusBook.Status5 = Properties.Resources.missing512;
            sbStatusBook.TabIndex = 1;
            sbStatusBook.TabStop = false;
            sbStatusBook.Visible = false;
            // 
            // lBookAuthor
            // 
            lBookAuthor.AutoSize = true;
            lBookAuthor.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lBookAuthor.Location = new Point(3, 28);
            lBookAuthor.Name = "lBookAuthor";
            lBookAuthor.Size = new Size(115, 22);
            lBookAuthor.TabIndex = 1;
            lBookAuthor.Text = "Author Name";
            // 
            // lBookTitle
            // 
            lBookTitle.AutoSize = true;
            lBookTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lBookTitle.Location = new Point(3, 5);
            lBookTitle.Name = "lBookTitle";
            lBookTitle.Size = new Size(111, 25);
            lBookTitle.TabIndex = 0;
            lBookTitle.Text = "Book Name";
            // 
            // ctrlBookCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(uiPanel1);
            Name = "ctrlBookCard";
            Size = new Size(133, 166);
            uiPanel1.ResumeLayout(false);
            scMain.Panel1.ResumeLayout(false);
            scMain.Panel2.ResumeLayout(false);
            scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scMain).EndInit();
            scMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sbStatusBook).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private SplitContainer scMain;
        private Sunny.UI.UIStatusBox sbStatusBook;
        private ReaLTaiizor.Controls.ParrotPictureBox pbBookCover;
        private Label lBookAuthor;
        private Label lBookTitle;
    }
}
