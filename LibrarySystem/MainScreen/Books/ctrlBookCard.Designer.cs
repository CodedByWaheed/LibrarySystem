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
            scMain = new SplitContainer();
            pbBookCover = new ReaLTaiizor.Controls.ParrotPictureBox();
            lBookAuthor = new Label();
            lBookTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)scMain).BeginInit();
            scMain.Panel1.SuspendLayout();
            scMain.Panel2.SuspendLayout();
            scMain.SuspendLayout();
            SuspendLayout();
            // 
            // scMain
            // 
            scMain.Dock = DockStyle.Fill;
            scMain.Location = new Point(0, 0);
            scMain.Name = "scMain";
            scMain.Orientation = Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            scMain.Panel1.Controls.Add(pbBookCover);
            // 
            // scMain.Panel2
            // 
            scMain.Panel2.Controls.Add(lBookAuthor);
            scMain.Panel2.Controls.Add(lBookTitle);
            scMain.Size = new Size(133, 166);
            scMain.SplitterDistance = 116;
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
            pbBookCover.Location = new Point(10, 7);
            pbBookCover.Name = "pbBookCover";
            pbBookCover.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            pbBookCover.Size = new Size(110, 106);
            pbBookCover.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pbBookCover.TabIndex = 0;
            pbBookCover.Text = "parrotPictureBox1";
            pbBookCover.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // lBookAuthor
            // 
            lBookAuthor.AutoSize = true;
            lBookAuthor.Location = new Point(3, 28);
            lBookAuthor.Name = "lBookAuthor";
            lBookAuthor.Size = new Size(98, 20);
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
            // ctrlBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(scMain);
            Name = "ctrlBook";
            Size = new Size(133, 166);
            scMain.Panel1.ResumeLayout(false);
            scMain.Panel2.ResumeLayout(false);
            scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scMain).EndInit();
            scMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer scMain;
        private ReaLTaiizor.Controls.ParrotPictureBox pbBookCover;
        private Label lBookTitle;
        private Label lBookAuthor;
    }
}
