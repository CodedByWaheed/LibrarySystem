namespace LibrarySystem.MainScreen.Fines
{
    partial class ctrlFinesCard
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
            btnWaive = new Sunny.UI.UIButton();
            btnPay = new Sunny.UI.UIButton();
            lFinesAmount = new Label();
            lFineReson = new Label();
            label3 = new Label();
            lBookName = new Label();
            label1 = new Label();
            PannelFineStatus = new Sunny.UI.UIPanel();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiPanel1
            // 
            uiPanel1.BackColor = Color.White;
            uiPanel1.Controls.Add(btnWaive);
            uiPanel1.Controls.Add(btnPay);
            uiPanel1.Controls.Add(lFinesAmount);
            uiPanel1.Controls.Add(lFineReson);
            uiPanel1.Controls.Add(label3);
            uiPanel1.Controls.Add(lBookName);
            uiPanel1.Controls.Add(label1);
            uiPanel1.Controls.Add(PannelFineStatus);
            uiPanel1.Dock = DockStyle.Fill;
            uiPanel1.FillColor = Color.White;
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(0, 0);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 15;
            uiPanel1.RectColor = Color.Black;
            uiPanel1.Size = new Size(177, 130);
            uiPanel1.TabIndex = 0;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnWaive
            // 
            btnWaive.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnWaive.FillColor = Color.White;
            btnWaive.Font = new Font("Microsoft Sans Serif", 12F);
            btnWaive.ForeColor = Color.Black;
            btnWaive.ForeDisableColor = Color.Black;
            btnWaive.Location = new Point(68, 79);
            btnWaive.MinimumSize = new Size(1, 1);
            btnWaive.Name = "btnWaive";
            btnWaive.Radius = 20;
            btnWaive.RectColor = Color.Black;
            btnWaive.Size = new Size(103, 44);
            btnWaive.TabIndex = 15;
            btnWaive.Text = "Waive";
            btnWaive.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // btnPay
            // 
            btnPay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPay.Font = new Font("Microsoft Sans Serif", 12F);
            btnPay.Location = new Point(7, 79);
            btnPay.MinimumSize = new Size(1, 1);
            btnPay.Name = "btnPay";
            btnPay.Radius = 20;
            btnPay.Size = new Size(103, 44);
            btnPay.TabIndex = 14;
            btnPay.Text = "Pay";
            btnPay.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // lFinesAmount
            // 
            lFinesAmount.AutoSize = true;
            lFinesAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lFinesAmount.Location = new Point(23, 5);
            lFinesAmount.Name = "lFinesAmount";
            lFinesAmount.Size = new Size(65, 28);
            lFinesAmount.TabIndex = 13;
            lFinesAmount.Text = "00.00";
            // 
            // lFineReson
            // 
            lFineReson.AutoSize = true;
            lFineReson.Font = new Font("Segoe UI", 10.2F);
            lFineReson.Location = new Point(4, 33);
            lFineReson.Name = "lFineReson";
            lFineReson.Size = new Size(92, 23);
            lFineReson.TabIndex = 12;
            lFineReson.Text = "Fine Reson";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(90, 33);
            label3.Name = "label3";
            label3.Size = new Size(17, 23);
            label3.TabIndex = 11;
            label3.Text = "-";
            // 
            // lBookName
            // 
            lBookName.AutoSize = true;
            lBookName.Font = new Font("Segoe UI", 10.2F);
            lBookName.Location = new Point(111, 33);
            lBookName.Name = "lBookName";
            lBookName.Size = new Size(99, 23);
            lBookName.TabIndex = 10;
            lBookName.Text = "Book Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(4, 5);
            label1.Name = "label1";
            label1.Size = new Size(24, 28);
            label1.TabIndex = 9;
            label1.Text = "$";
            // 
            // PannelFineStatus
            // 
            PannelFineStatus.AutoSize = true;
            PannelFineStatus.FillColor = Color.Gold;
            PannelFineStatus.Font = new Font("Microsoft Sans Serif", 12F);
            PannelFineStatus.Location = new Point(4, 61);
            PannelFineStatus.Margin = new Padding(4, 5, 4, 5);
            PannelFineStatus.MinimumSize = new Size(1, 1);
            PannelFineStatus.Name = "PannelFineStatus";
            PannelFineStatus.Radius = 37;
            PannelFineStatus.Size = new Size(85, 43);
            PannelFineStatus.TabIndex = 8;
            PannelFineStatus.Text = "Pending";
            PannelFineStatus.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // ctrlFinesCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(uiPanel1);
            Name = "ctrlFinesCard";
            Size = new Size(177, 130);
            Load += ctrlFinesCard_Load;
            uiPanel1.ResumeLayout(false);
            uiPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIButton btnWaive;
        private Sunny.UI.UIButton btnPay;
        private Label lFinesAmount;
        private Label lFineReson;
        private Label label3;
        private Label lBookName;
        private Label label1;
        private Sunny.UI.UIPanel PannelFineStatus;
    }
}
