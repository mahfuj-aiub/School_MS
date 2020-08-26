namespace Student_Officer
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabelError = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabelLogin_As = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDropdownLoginAs = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuThinButtonLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuMaterialTextboxPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabelPassword = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuMaterialTextboxUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabelid = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabelLogin = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 862);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.bunifuCustomLabelError);
            this.panel2.Controls.Add(this.bunifuCustomLabelLogin_As);
            this.panel2.Controls.Add(this.bunifuDropdownLoginAs);
            this.panel2.Controls.Add(this.bunifuThinButtonLogin);
            this.panel2.Controls.Add(this.bunifuMaterialTextboxPassword);
            this.panel2.Controls.Add(this.bunifuCustomLabelPassword);
            this.panel2.Controls.Add(this.bunifuMaterialTextboxUserName);
            this.panel2.Controls.Add(this.bunifuCustomLabelid);
            this.panel2.Controls.Add(this.bunifuCustomLabelLogin);
            this.panel2.Location = new System.Drawing.Point(640, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 669);
            this.panel2.TabIndex = 28;
            // 
            // bunifuCustomLabelError
            // 
            this.bunifuCustomLabelError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabelError.AutoSize = true;
            this.bunifuCustomLabelError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabelError.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabelError.ForeColor = System.Drawing.Color.Red;
            this.bunifuCustomLabelError.Location = new System.Drawing.Point(97, 521);
            this.bunifuCustomLabelError.Name = "bunifuCustomLabelError";
            this.bunifuCustomLabelError.Size = new System.Drawing.Size(228, 19);
            this.bunifuCustomLabelError.TabIndex = 30;
            this.bunifuCustomLabelError.Text = "Invalid User Name or Password !!";
            this.bunifuCustomLabelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuCustomLabelError.Visible = false;
            // 
            // bunifuCustomLabelLogin_As
            // 
            this.bunifuCustomLabelLogin_As.AutoSize = true;
            this.bunifuCustomLabelLogin_As.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabelLogin_As.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabelLogin_As.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.bunifuCustomLabelLogin_As.Location = new System.Drawing.Point(62, 407);
            this.bunifuCustomLabelLogin_As.Name = "bunifuCustomLabelLogin_As";
            this.bunifuCustomLabelLogin_As.Size = new System.Drawing.Size(86, 22);
            this.bunifuCustomLabelLogin_As.TabIndex = 28;
            this.bunifuCustomLabelLogin_As.Text = "Login As";
            // 
            // bunifuDropdownLoginAs
            // 
            this.bunifuDropdownLoginAs.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdownLoginAs.BorderRadius = 5;
            this.bunifuDropdownLoginAs.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDropdownLoginAs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(194)))), ((int)(((byte)(200)))));
            this.bunifuDropdownLoginAs.Items = new string[] {
        "Student",
        "Teacher",
        "Admin",
        "Official"};
            this.bunifuDropdownLoginAs.Location = new System.Drawing.Point(67, 452);
            this.bunifuDropdownLoginAs.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuDropdownLoginAs.Name = "bunifuDropdownLoginAs";
            this.bunifuDropdownLoginAs.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.bunifuDropdownLoginAs.onHoverColor = System.Drawing.Color.RoyalBlue;
            this.bunifuDropdownLoginAs.selectedIndex = 0;
            this.bunifuDropdownLoginAs.Size = new System.Drawing.Size(330, 50);
            this.bunifuDropdownLoginAs.TabIndex = 27;
            // 
            // bunifuThinButtonLogin
            // 
            this.bunifuThinButtonLogin.ActiveBorderThickness = 1;
            this.bunifuThinButtonLogin.ActiveCornerRadius = 20;
            this.bunifuThinButtonLogin.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.bunifuThinButtonLogin.ActiveForecolor = System.Drawing.Color.Gainsboro;
            this.bunifuThinButtonLogin.ActiveLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButtonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(194)))), ((int)(((byte)(200)))));
            this.bunifuThinButtonLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButtonLogin.BackgroundImage")));
            this.bunifuThinButtonLogin.ButtonText = "Login";
            this.bunifuThinButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButtonLogin.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButtonLogin.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButtonLogin.IdleBorderThickness = 1;
            this.bunifuThinButtonLogin.IdleCornerRadius = 20;
            this.bunifuThinButtonLogin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.bunifuThinButtonLogin.IdleForecolor = System.Drawing.Color.Transparent;
            this.bunifuThinButtonLogin.IdleLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButtonLogin.Location = new System.Drawing.Point(133, 566);
            this.bunifuThinButtonLogin.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButtonLogin.Name = "bunifuThinButtonLogin";
            this.bunifuThinButtonLogin.Size = new System.Drawing.Size(200, 55);
            this.bunifuThinButtonLogin.TabIndex = 26;
            this.bunifuThinButtonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButtonLogin.Click += new System.EventHandler(this.bunifuThinButtonLogin_Click);
            // 
            // bunifuMaterialTextboxPassword
            // 
            this.bunifuMaterialTextboxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextboxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.bunifuMaterialTextboxPassword.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxPassword.HintText = "";
            this.bunifuMaterialTextboxPassword.isPassword = true;
            this.bunifuMaterialTextboxPassword.LineFocusedColor = System.Drawing.Color.Transparent;
            this.bunifuMaterialTextboxPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.bunifuMaterialTextboxPassword.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.bunifuMaterialTextboxPassword.LineThickness = 3;
            this.bunifuMaterialTextboxPassword.Location = new System.Drawing.Point(60, 356);
            this.bunifuMaterialTextboxPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuMaterialTextboxPassword.Name = "bunifuMaterialTextboxPassword";
            this.bunifuMaterialTextboxPassword.Size = new System.Drawing.Size(337, 30);
            this.bunifuMaterialTextboxPassword.TabIndex = 25;
            this.bunifuMaterialTextboxPassword.Text = "password";
            this.bunifuMaterialTextboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabelPassword
            // 
            this.bunifuCustomLabelPassword.AutoSize = true;
            this.bunifuCustomLabelPassword.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.bunifuCustomLabelPassword.Location = new System.Drawing.Point(60, 310);
            this.bunifuCustomLabelPassword.Name = "bunifuCustomLabelPassword";
            this.bunifuCustomLabelPassword.Size = new System.Drawing.Size(95, 22);
            this.bunifuCustomLabelPassword.TabIndex = 24;
            this.bunifuCustomLabelPassword.Text = "Password";
            // 
            // bunifuMaterialTextboxUserName
            // 
            this.bunifuMaterialTextboxUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextboxUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.bunifuMaterialTextboxUserName.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxUserName.HintText = "Full Name";
            this.bunifuMaterialTextboxUserName.isPassword = false;
            this.bunifuMaterialTextboxUserName.LineFocusedColor = System.Drawing.Color.Transparent;
            this.bunifuMaterialTextboxUserName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.bunifuMaterialTextboxUserName.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.bunifuMaterialTextboxUserName.LineThickness = 3;
            this.bunifuMaterialTextboxUserName.Location = new System.Drawing.Point(60, 251);
            this.bunifuMaterialTextboxUserName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuMaterialTextboxUserName.Name = "bunifuMaterialTextboxUserName";
            this.bunifuMaterialTextboxUserName.Size = new System.Drawing.Size(337, 30);
            this.bunifuMaterialTextboxUserName.TabIndex = 23;
            this.bunifuMaterialTextboxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabelid
            // 
            this.bunifuCustomLabelid.AutoSize = true;
            this.bunifuCustomLabelid.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabelid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.bunifuCustomLabelid.Location = new System.Drawing.Point(60, 205);
            this.bunifuCustomLabelid.Name = "bunifuCustomLabelid";
            this.bunifuCustomLabelid.Size = new System.Drawing.Size(29, 22);
            this.bunifuCustomLabelid.TabIndex = 22;
            this.bunifuCustomLabelid.Text = "ID";
            // 
            // bunifuCustomLabelLogin
            // 
            this.bunifuCustomLabelLogin.AutoSize = true;
            this.bunifuCustomLabelLogin.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.bunifuCustomLabelLogin.Location = new System.Drawing.Point(159, 95);
            this.bunifuCustomLabelLogin.Name = "bunifuCustomLabelLogin";
            this.bunifuCustomLabelLogin.Size = new System.Drawing.Size(125, 28);
            this.bunifuCustomLabelLogin.TabIndex = 21;
            this.bunifuCustomLabelLogin.Text = "Login First";
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(194)))), ((int)(((byte)(200)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1152, 858);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1168, 897);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login First";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButtonLogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabelPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxUserName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabelid;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabelLogin;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabelLogin_As;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdownLoginAs;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabelError;
    }
}

