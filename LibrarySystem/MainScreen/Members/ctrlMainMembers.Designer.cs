namespace LibrarySystem.MainScreen.Members
{
    partial class ctrlMainMembers
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            fpBook = new Sunny.UI.UIFlowLayoutPanel();
            uiDataGridView1 = new Sunny.UI.UIDataGridView();
            cmsMembers = new Sunny.UI.UIContextMenuStrip(components);
            updateToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            tbSearch = new Sunny.UI.UITextBox();
            scMain = new SplitContainer();
            btnAddNew = new Sunny.UI.UIButton();
            label1 = new Label();
            fpBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
            cmsMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scMain).BeginInit();
            scMain.Panel1.SuspendLayout();
            scMain.Panel2.SuspendLayout();
            scMain.SuspendLayout();
            SuspendLayout();
            // 
            // fpBook
            // 
            fpBook.Controls.Add(label1);
            fpBook.Controls.Add(uiDataGridView1);
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
            // 
            // uiDataGridView1
            // 
            uiDataGridView1.AllowUserToAddRows = false;
            uiDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            uiDataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiDataGridView1.BackgroundColor = Color.White;
            uiDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            uiDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            uiDataGridView1.ContextMenuStrip = cmsMembers;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            uiDataGridView1.EnableHeadersVisualStyles = false;
            uiDataGridView1.Font = new Font("Microsoft Sans Serif", 12F);
            uiDataGridView1.GridColor = Color.FromArgb(80, 160, 255);
            uiDataGridView1.Location = new Point(16, 5);
            uiDataGridView1.Name = "uiDataGridView1";
            uiDataGridView1.ReadOnly = true;
            uiDataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            uiDataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            uiDataGridView1.SelectedIndex = -1;
            uiDataGridView1.Size = new Size(769, 270);
            uiDataGridView1.StripeOddColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.TabIndex = 3;
            // 
            // cmsMembers
            // 
            cmsMembers.BackColor = Color.FromArgb(243, 249, 255);
            cmsMembers.Font = new Font("Microsoft Sans Serif", 12F);
            cmsMembers.ImageScalingSize = new Size(20, 20);
            cmsMembers.Items.AddRange(new ToolStripItem[] { updateToolStripMenuItem, deleteToolStripMenuItem });
            cmsMembers.Name = "cmsMembers";
            cmsMembers.Size = new Size(148, 64);
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(147, 30);
            updateToolStripMenuItem.Text = "Update";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(147, 30);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Microsoft Sans Serif", 12F);
            tbSearch.Icon = Properties.Resources.search;
            tbSearch.Location = new Point(16, 19);
            tbSearch.Margin = new Padding(4, 5, 4, 5);
            tbSearch.MinimumSize = new Size(1, 16);
            tbSearch.Name = "tbSearch";
            tbSearch.Padding = new Padding(5);
            tbSearch.Radius = 10;
            tbSearch.RectColor = Color.Black;
            tbSearch.ShowText = false;
            tbSearch.Size = new Size(619, 36);
            tbSearch.SymbolRotate = 100;
            tbSearch.TabIndex = 5;
            tbSearch.TextAlignment = ContentAlignment.MiddleLeft;
            tbSearch.Watermark = "Search ...";
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
            scMain.Panel1.Controls.Add(btnAddNew);
            scMain.Panel1.Controls.Add(tbSearch);
            // 
            // scMain.Panel2
            // 
            scMain.Panel2.Controls.Add(fpBook);
            scMain.Size = new Size(796, 409);
            scMain.SplitterDistance = 74;
            scMain.TabIndex = 1;
            // 
            // btnAddNew
            // 
            btnAddNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNew.Font = new Font("Microsoft Sans Serif", 12F);
            btnAddNew.Location = new Point(664, 19);
            btnAddNew.MinimumSize = new Size(1, 1);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Radius = 20;
            btnAddNew.Size = new Size(121, 37);
            btnAddNew.TabIndex = 6;
            btnAddNew.Text = "New";
            btnAddNew.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 293);
            label1.Name = "label1";
            label1.Size = new Size(139, 22);
            label1.TabIndex = 4;
            label1.Text = "Total Members :";
            // 
            // ctrlMainMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(scMain);
            Name = "ctrlMainMembers";
            Size = new Size(796, 409);
            Load += ctrlMainCard_Load;
            fpBook.ResumeLayout(false);
            fpBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).EndInit();
            cmsMembers.ResumeLayout(false);
            scMain.Panel1.ResumeLayout(false);
            scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scMain).EndInit();
            scMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIFlowLayoutPanel fpBook;
        private Sunny.UI.UITextBox tbSearch;
        private SplitContainer scMain;
        private Sunny.UI.UIButton btnAddNew;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UIContextMenuStrip cmsMembers;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Label label1;
    }
}
