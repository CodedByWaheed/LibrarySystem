namespace LibrarySystem.MainScreen.Books
{
    partial class ctrlBookCardExtended
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
            parrotPictureBox1 = new ReaLTaiizor.Controls.ParrotPictureBox();
            lShelfLocation = new Label();
            label5 = new Label();
            lCopyBarcode = new Label();
            label3 = new Label();
            lISBN = new Label();
            label1 = new Label();
            lAuthor = new ReaLTaiizor.Controls.CrownLabel();
            lBookName = new ReaLTaiizor.Controls.BigLabel();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scMain).BeginInit();
            scMain.Panel1.SuspendLayout();
            scMain.Panel2.SuspendLayout();
            scMain.SuspendLayout();
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
            uiPanel1.Radius = 15;
            uiPanel1.RectColor = Color.Black;
            uiPanel1.Size = new Size(357, 207);
            uiPanel1.TabIndex = 0;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // scMain
            // 
            scMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            scMain.FixedPanel = FixedPanel.Panel1;
            scMain.IsSplitterFixed = true;
            scMain.Location = new Point(3, 3);
            scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            scMain.Panel1.Controls.Add(parrotPictureBox1);
            // 
            // scMain.Panel2
            // 
            scMain.Panel2.Controls.Add(lShelfLocation);
            scMain.Panel2.Controls.Add(label5);
            scMain.Panel2.Controls.Add(lCopyBarcode);
            scMain.Panel2.Controls.Add(label3);
            scMain.Panel2.Controls.Add(lISBN);
            scMain.Panel2.Controls.Add(label1);
            scMain.Panel2.Controls.Add(lAuthor);
            scMain.Panel2.Controls.Add(lBookName);
            scMain.Size = new Size(351, 201);
            scMain.SplitterDistance = 140;
            scMain.TabIndex = 0;
            // 
            // parrotPictureBox1
            // 
            parrotPictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            parrotPictureBox1.BackColor = Color.Red;
            parrotPictureBox1.ColorLeft = Color.DodgerBlue;
            parrotPictureBox1.ColorRight = Color.DodgerBlue;
            parrotPictureBox1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotPictureBox1.FilterAlpha = 200;
            parrotPictureBox1.FilterEnabled = true;
            parrotPictureBox1.Image = null;
            parrotPictureBox1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPictureBox1.IsElipse = false;
            parrotPictureBox1.IsParallax = false;
            parrotPictureBox1.Location = new Point(12, 23);
            parrotPictureBox1.Name = "parrotPictureBox1";
            parrotPictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox1.Size = new Size(125, 180);
            parrotPictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox1.TabIndex = 0;
            parrotPictureBox1.Text = "parrotPictureBox1";
            parrotPictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // lShelfLocation
            // 
            lShelfLocation.AutoSize = true;
            lShelfLocation.BackColor = Color.Transparent;
            lShelfLocation.Location = new Point(167, 202);
            lShelfLocation.Name = "lShelfLocation";
            lShelfLocation.Size = new Size(66, 25);
            lShelfLocation.TabIndex = 16;
            lShelfLocation.Text = "A4-21";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(13, 202);
            label5.Name = "label5";
            label5.Size = new Size(147, 25);
            label5.TabIndex = 15;
            label5.Text = "Shelf Location :";
            // 
            // lCopyBarcode
            // 
            lCopyBarcode.AutoSize = true;
            lCopyBarcode.BackColor = Color.Transparent;
            lCopyBarcode.Location = new Point(167, 164);
            lCopyBarcode.Name = "lCopyBarcode";
            lCopyBarcode.Size = new Size(79, 25);
            lCopyBarcode.TabIndex = 14;
            lCopyBarcode.Text = "c-xxxxx";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(13, 164);
            label3.Name = "label3";
            label3.Size = new Size(148, 25);
            label3.TabIndex = 13;
            label3.Text = "Copy Barcode :";
            // 
            // lISBN
            // 
            lISBN.AutoSize = true;
            lISBN.BackColor = Color.Transparent;
            lISBN.Location = new Point(88, 126);
            lISBN.Name = "lISBN";
            lISBN.Size = new Size(119, 25);
            lISBN.TabIndex = 12;
            lISBN.Text = "xxx-xxxxxxx";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(13, 126);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 11;
            label1.Text = "ISBN :";
            // 
            // lAuthor
            // 
            lAuthor.AutoSize = true;
            lAuthor.BackColor = Color.Transparent;
            lAuthor.ForeColor = Color.Gray;
            lAuthor.Location = new Point(23, 71);
            lAuthor.Name = "lAuthor";
            lAuthor.Size = new Size(70, 25);
            lAuthor.TabIndex = 9;
            lAuthor.Text = "Author";
            // 
            // lBookName
            // 
            lBookName.AutoSize = true;
            lBookName.BackColor = Color.Transparent;
            lBookName.Font = new Font("Segoe UI", 25F);
            lBookName.ForeColor = Color.Black;
            lBookName.Location = new Point(13, 14);
            lBookName.Name = "lBookName";
            lBookName.Size = new Size(242, 57);
            lBookName.TabIndex = 8;
            lBookName.Text = "Book Name";
            // 
            // ctrlBookCardExtended
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(uiPanel1);
            Name = "ctrlBookCardExtended";
            Size = new Size(357, 207);
            Load += ctrlBookCardExtended_Load;
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
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox1;
        private ReaLTaiizor.Controls.BigLabel lBookName;
        private ReaLTaiizor.Controls.CrownLabel lAuthor;
        private Label label1;
        private Label lShelfLocation;
        private Label label5;
        private Label lCopyBarcode;
        private Label label3;
        private Label lISBN;
    }
}
