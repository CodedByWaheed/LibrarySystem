namespace LibrarySystem.LoginScreen
{
    partial class frmLoginScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginScreen));
            airForm1 = new ReaLTaiizor.Forms.AirForm();
            llRegister = new LinkLabel();
            btnLogin = new Sunny.UI.UIButton();
            txtPassword = new Sunny.UI.UITextBox();
            txtEmail = new Sunny.UI.UITextBox();
            label1 = new Label();
            parrotPictureBox1 = new ReaLTaiizor.Controls.ParrotPictureBox();
            airForm1.SuspendLayout();
            SuspendLayout();
            // 
            // airForm1
            // 
            airForm1.BackColor = Color.White;
            airForm1.BorderStyle = FormBorderStyle.None;
            airForm1.Controls.Add(llRegister);
            airForm1.Controls.Add(btnLogin);
            airForm1.Controls.Add(txtPassword);
            airForm1.Controls.Add(txtEmail);
            airForm1.Controls.Add(label1);
            airForm1.Controls.Add(parrotPictureBox1);
            airForm1.Customization = "AAAA/1paWv9ycnL/";
            airForm1.Dock = DockStyle.Fill;
            airForm1.Font = new Font("Segoe UI", 9F);
            airForm1.Image = null;
            airForm1.Location = new Point(0, 0);
            airForm1.MinimumSize = new Size(112, 35);
            airForm1.Movable = true;
            airForm1.Name = "airForm1";
            airForm1.NoRounding = false;
            airForm1.Sizable = false;
            airForm1.Size = new Size(545, 556);
            airForm1.SmartBounds = true;
            airForm1.StartPosition = FormStartPosition.CenterScreen;
            airForm1.TabIndex = 0;
            airForm1.TransparencyKey = Color.Fuchsia;
            airForm1.Transparent = false;
            airForm1.Click += airForm1_Click;
            // 
            // llRegister
            // 
            llRegister.AutoSize = true;
            llRegister.Location = new Point(241, 455);
            llRegister.Name = "llRegister";
            llRegister.Size = new Size(63, 20);
            llRegister.TabIndex = 5;
            llRegister.TabStop = true;
            llRegister.Text = "Register";
            // 
            // btnLogin
            // 
            btnLogin.FillColor = Color.FromArgb(23, 66, 178);
            btnLogin.FillColor2 = Color.FromArgb(23, 66, 178);
            btnLogin.Font = new Font("Microsoft Sans Serif", 12F);
            btnLogin.Location = new Point(83, 399);
            btnLogin.MinimumSize = new Size(1, 1);
            btnLogin.Name = "btnLogin";
            btnLogin.Radius = 15;
            btnLogin.RectColor = Color.FromArgb(23, 66, 178);
            btnLogin.Size = new Size(379, 44);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F);
            txtPassword.Location = new Point(83, 335);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.MinimumSize = new Size(1, 16);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(5);
            txtPassword.Radius = 15;
            txtPassword.RectColor = Color.FromArgb(173, 178, 181);
            txtPassword.ShowText = false;
            txtPassword.Size = new Size(379, 36);
            txtPassword.TabIndex = 3;
            txtPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtPassword.Watermark = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F);
            txtEmail.Location = new Point(83, 284);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.MinimumSize = new Size(1, 16);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(5);
            txtEmail.Radius = 15;
            txtEmail.RectColor = Color.FromArgb(173, 178, 181);
            txtEmail.ShowText = false;
            txtEmail.Size = new Size(379, 36);
            txtEmail.TabIndex = 2;
            txtEmail.TextAlignment = ContentAlignment.MiddleLeft;
            txtEmail.Watermark = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(168, 195);
            label1.Name = "label1";
            label1.Size = new Size(211, 35);
            label1.TabIndex = 1;
            label1.Text = "Central Library";
            // 
            // parrotPictureBox1
            // 
            parrotPictureBox1.ColorLeft = Color.DodgerBlue;
            parrotPictureBox1.ColorRight = Color.DodgerBlue;
            parrotPictureBox1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotPictureBox1.FilterAlpha = 200;
            parrotPictureBox1.FilterEnabled = false;
            parrotPictureBox1.Image = Properties.Resources.open_book512;
            parrotPictureBox1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPictureBox1.IsElipse = false;
            parrotPictureBox1.IsParallax = false;
            parrotPictureBox1.Location = new Point(202, 58);
            parrotPictureBox1.Name = "parrotPictureBox1";
            parrotPictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox1.Size = new Size(142, 127);
            parrotPictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox1.TabIndex = 0;
            parrotPictureBox1.Text = "parrotPictureBox1";
            parrotPictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // frmLoginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 556);
            Controls.Add(airForm1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLoginScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLoginScreen";
            TransparencyKey = Color.Fuchsia;
            airForm1.ResumeLayout(false);
            airForm1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.AirForm airForm1;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox1;
        private Label label1;
        private Sunny.UI.UITextBox txtEmail;
        private Sunny.UI.UIButton btnLogin;
        private Sunny.UI.UITextBox txtPassword;
        private LinkLabel llRegister;
    }
}