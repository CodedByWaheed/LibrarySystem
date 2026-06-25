namespace LibrarySystem.MainScreen.Loans
{
    partial class ctrlFineCardExtended
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
            lMemberName = new Label();
            pbMember = new Sunny.UI.UIAvatar();
            ctrlFinesCard1 = new LibrarySystem.MainScreen.Fines.ctrlFinesCard();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scMain).BeginInit();
            scMain.Panel1.SuspendLayout();
            scMain.Panel2.SuspendLayout();
            scMain.SuspendLayout();
            SuspendLayout();
            // 
            // uiPanel1
            // 
            uiPanel1.BackColor = Color.White;
            uiPanel1.Controls.Add(scMain);
            uiPanel1.Dock = DockStyle.Fill;
            uiPanel1.FillColor = Color.White;
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(0, 0);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 15;
            uiPanel1.RectColor = Color.Black;
            uiPanel1.Size = new Size(192, 190);
            uiPanel1.TabIndex = 1;
            uiPanel1.Text = "uiPanel1";
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // scMain
            // 
            scMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            scMain.FixedPanel = FixedPanel.Panel1;
            scMain.IsSplitterFixed = true;
            scMain.Location = new Point(3, 3);
            scMain.Name = "scMain";
            scMain.Orientation = Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            scMain.Panel1.Controls.Add(lMemberName);
            scMain.Panel1.Controls.Add(pbMember);
            // 
            // scMain.Panel2
            // 
            scMain.Panel2.Controls.Add(ctrlFinesCard1);
            scMain.Size = new Size(186, 184);
            scMain.SplitterDistance = 49;
            scMain.TabIndex = 0;
            // 
            // lMemberName
            // 
            lMemberName.AutoSize = true;
            lMemberName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lMemberName.Location = new Point(61, 15);
            lMemberName.Name = "lMemberName";
            lMemberName.Size = new Size(136, 25);
            lMemberName.TabIndex = 1;
            lMemberName.Text = "MemberName";
            // 
            // pbMember
            // 
            pbMember.AvatarSize = 45;
            pbMember.Font = new Font("Microsoft Sans Serif", 12F);
            pbMember.Location = new Point(3, 1);
            pbMember.MinimumSize = new Size(1, 1);
            pbMember.Name = "pbMember";
            pbMember.Size = new Size(52, 46);
            pbMember.SymbolSize = 33;
            pbMember.TabIndex = 0;
            pbMember.Text = "uiAvatar1";
            // 
            // ctrlFinesCard1
            // 
            ctrlFinesCard1.Border = Fines.ctrlFinesCard.enBorder.unVisibel;
            ctrlFinesCard1.Dock = DockStyle.Fill;
            ctrlFinesCard1.Location = new Point(0, 0);
            ctrlFinesCard1.Name = "ctrlFinesCard1";
            ctrlFinesCard1.Size = new Size(186, 131);
            ctrlFinesCard1.TabIndex = 0;
            // 
            // ctrlFineCardExtended
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(uiPanel1);
            Name = "ctrlFineCardExtended";
            Size = new Size(192, 190);
            uiPanel1.ResumeLayout(false);
            scMain.Panel1.ResumeLayout(false);
            scMain.Panel1.PerformLayout();
            scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scMain).EndInit();
            scMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private SplitContainer scMain;
        private Label lMemberName;
        private Sunny.UI.UIAvatar pbMember;
        private Fines.ctrlFinesCard ctrlFinesCard1;
    }
}
