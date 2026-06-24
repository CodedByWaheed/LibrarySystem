namespace LibrarySystem.MainScreen.Books
{
    partial class ctrlMainBook
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
            uiComboBox1 = new Sunny.UI.UIComboBox();
            swtchAvailablty = new Sunny.UI.UISwitch();
            label2 = new Label();
            uiTextBox2 = new Sunny.UI.UITextBox();
            fpBook = new Sunny.UI.UIFlowLayoutPanel();
            uiPanel1 = new Sunny.UI.UIPanel();
            parrotPictureBox1 = new ReaLTaiizor.Controls.ParrotPictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)scMain).BeginInit();
            scMain.Panel1.SuspendLayout();
            scMain.Panel2.SuspendLayout();
            scMain.SuspendLayout();
            fpBook.SuspendLayout();
            uiPanel1.SuspendLayout();
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
            scMain.Panel1.Controls.Add(uiComboBox1);
            scMain.Panel1.Controls.Add(swtchAvailablty);
            scMain.Panel1.Controls.Add(label2);
            scMain.Panel1.Controls.Add(uiTextBox2);
            // 
            // scMain.Panel2
            // 
            scMain.Panel2.Controls.Add(fpBook);
            scMain.Panel2.Paint += scMain_Panel2_Paint;
            scMain.Size = new Size(796, 409);
            scMain.SplitterDistance = 74;
            scMain.TabIndex = 0;
            // 
            // uiComboBox1
            // 
            uiComboBox1.DataSource = null;
            uiComboBox1.FillColor = Color.White;
            uiComboBox1.Font = new Font("Microsoft Sans Serif", 12F);
            uiComboBox1.ItemHoverColor = Color.FromArgb(155, 200, 255);
            uiComboBox1.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            uiComboBox1.Location = new Point(493, 19);
            uiComboBox1.Margin = new Padding(4, 5, 4, 5);
            uiComboBox1.MinimumSize = new Size(63, 0);
            uiComboBox1.Name = "uiComboBox1";
            uiComboBox1.Padding = new Padding(0, 0, 30, 2);
            uiComboBox1.Radius = 10;
            uiComboBox1.RectColor = Color.Black;
            uiComboBox1.Size = new Size(160, 36);
            uiComboBox1.Style = Sunny.UI.UIStyle.Custom;
            uiComboBox1.StyleDropDown = Sunny.UI.UIStyle.Custom;
            uiComboBox1.SymbolSize = 24;
            uiComboBox1.TabIndex = 6;
            uiComboBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiComboBox1.Watermark = "Gategory";
            // 
            // swtchAvailablty
            // 
            swtchAvailablty.ActiveText = "";
            swtchAvailablty.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            swtchAvailablty.Font = new Font("Microsoft Sans Serif", 12F);
            swtchAvailablty.InActiveText = "";
            swtchAvailablty.Location = new Point(734, 24);
            swtchAvailablty.MinimumSize = new Size(1, 1);
            swtchAvailablty.Name = "swtchAvailablty";
            swtchAvailablty.Size = new Size(50, 27);
            swtchAvailablty.TabIndex = 25;
            swtchAvailablty.Text = "uiSwitch1";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(617, 22);
            label2.Name = "label2";
            label2.Size = new Size(121, 31);
            label2.TabIndex = 26;
            label2.Text = "Availablity";
            // 
            // uiTextBox2
            // 
            uiTextBox2.Font = new Font("Microsoft Sans Serif", 12F);
            uiTextBox2.Icon = Properties.Resources.search;
            uiTextBox2.Location = new Point(16, 19);
            uiTextBox2.Margin = new Padding(4, 5, 4, 5);
            uiTextBox2.MinimumSize = new Size(1, 16);
            uiTextBox2.Name = "uiTextBox2";
            uiTextBox2.Padding = new Padding(5);
            uiTextBox2.Radius = 10;
            uiTextBox2.RectColor = Color.Black;
            uiTextBox2.ShowText = false;
            uiTextBox2.Size = new Size(447, 36);
            uiTextBox2.SymbolRotate = 100;
            uiTextBox2.TabIndex = 5;
            uiTextBox2.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox2.Watermark = "Search by Author , ISBN , Title ...";
            // 
            // fpBook
            // 
            fpBook.Controls.Add(uiPanel1);
            fpBook.Dock = DockStyle.Fill;
            fpBook.FillColor = SystemColors.Control;
            fpBook.Font = new Font("Microsoft Sans Serif", 12F);
            fpBook.Location = new Point(0, 0);
            fpBook.Margin = new Padding(4, 5, 4, 5);
            fpBook.MinimumSize = new Size(1, 1);
            fpBook.Name = "fpBook";
            fpBook.Padding = new Padding(2);
            fpBook.RectColor = Color.White;
            fpBook.ShowText = false;
            fpBook.Size = new Size(796, 331);
            fpBook.TabIndex = 1;
            fpBook.Text = "uiFlowLayoutPanel1";
            fpBook.TextAlignment = ContentAlignment.MiddleCenter;
            fpBook.Click += fpBook_Click;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(parrotPictureBox1);
            uiPanel1.Controls.Add(label1);
            uiPanel1.Cursor = Cursors.Hand;
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(6, 0);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 10;
            uiPanel1.RectColor = Color.Black;
            uiPanel1.Size = new Size(166, 208);
            uiPanel1.TabIndex = 24;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // parrotPictureBox1
            // 
            parrotPictureBox1.BackColor = Color.White;
            parrotPictureBox1.ColorLeft = Color.DodgerBlue;
            parrotPictureBox1.ColorRight = Color.DodgerBlue;
            parrotPictureBox1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotPictureBox1.FilterAlpha = 200;
            parrotPictureBox1.FilterEnabled = false;
            parrotPictureBox1.Image = Properties.Resources.plus;
            parrotPictureBox1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPictureBox1.IsElipse = false;
            parrotPictureBox1.IsParallax = false;
            parrotPictureBox1.Location = new Point(60, 82);
            parrotPictureBox1.Name = "parrotPictureBox1";
            parrotPictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox1.Size = new Size(46, 44);
            parrotPictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox1.TabIndex = 0;
            parrotPictureBox1.Text = "parrotPictureBox1";
            parrotPictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(12, 123);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 1;
            label1.Text = "Add New Book";
            // 
            // ctrlMainBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(scMain);
            Name = "ctrlMainBook";
            Size = new Size(796, 409);
            scMain.Panel1.ResumeLayout(false);
            scMain.Panel1.PerformLayout();
            scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scMain).EndInit();
            scMain.ResumeLayout(false);
            fpBook.ResumeLayout(false);
            uiPanel1.ResumeLayout(false);
            uiPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer scMain;
        private Sunny.UI.UITextBox uiTextBox2;
        private ReaLTaiizor.Controls.MaterialSwitch swtchAvailability;
        private ReaLTaiizor.Controls.MaterialSwitch swtchAvailable;
        private Sunny.UI.UIFlowLayoutPanel fpBook;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UIPanel uiPanel1;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox1;
        private Label label1;
        private Sunny.UI.UISwitch swtchAvailablty;
        private Label label2;
    }
}
