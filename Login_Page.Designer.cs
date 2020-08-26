namespace School_MS
{
    partial class Login_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Page));
            this.panel1 = new System.Windows.Forms.Panel();
            this.slide_Show_Log_In_Page1 = new School_MS.Slide_Show_Log_In_Page();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Password_cb = new Bunifu.Framework.UI.BunifuCheckbox();
            this.Login_bb = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Password_bmtb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Password_blvl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Id_bmtb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Id_blvl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.login_first_blvl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.slide_Show_Log_In_Page1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 749);
            this.panel1.TabIndex = 0;
            // 
            // slide_Show_Log_In_Page1
            // 
            this.slide_Show_Log_In_Page1.AutoScroll = true;
            this.slide_Show_Log_In_Page1.AutoSize = true;
            this.slide_Show_Log_In_Page1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slide_Show_Log_In_Page1.Location = new System.Drawing.Point(0, 0);
            this.slide_Show_Log_In_Page1.Name = "slide_Show_Log_In_Page1";
            this.slide_Show_Log_In_Page1.Size = new System.Drawing.Size(504, 749);
            this.slide_Show_Log_In_Page1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(504, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(648, 749);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bunifuCustomLabel2);
            this.panel3.Controls.Add(this.bunifuCustomLabel1);
            this.panel3.Controls.Add(this.Password_cb);
            this.panel3.Controls.Add(this.Login_bb);
            this.panel3.Controls.Add(this.Password_bmtb);
            this.panel3.Controls.Add(this.Password_blvl);
            this.panel3.Controls.Add(this.Id_bmtb);
            this.panel3.Controls.Add(this.Id_blvl);
            this.panel3.Controls.Add(this.login_first_blvl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(6, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(642, 749);
            this.panel3.TabIndex = 2;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(249, 544);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(169, 17);
            this.bunifuCustomLabel2.TabIndex = 30;
            this.bunifuCustomLabel2.Text = "Invalid User Id or Password!!";
            this.bunifuCustomLabel2.Visible = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(269, 490);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(123, 20);
            this.bunifuCustomLabel1.TabIndex = 29;
            this.bunifuCustomLabel1.Text = "Show Password";
            // 
            // Password_cb
            // 
            this.Password_cb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Password_cb.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Password_cb.Checked = true;
            this.Password_cb.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Password_cb.ForeColor = System.Drawing.Color.White;
            this.Password_cb.Location = new System.Drawing.Point(229, 490);
            this.Password_cb.Name = "Password_cb";
            this.Password_cb.Size = new System.Drawing.Size(20, 20);
            this.Password_cb.TabIndex = 28;
            // 
            // Login_bb
            // 
            this.Login_bb.ActiveBorderThickness = 1;
            this.Login_bb.ActiveCornerRadius = 20;
            this.Login_bb.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.Login_bb.ActiveForecolor = System.Drawing.Color.Gainsboro;
            this.Login_bb.ActiveLineColor = System.Drawing.Color.Transparent;
            this.Login_bb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(194)))), ((int)(((byte)(200)))));
            this.Login_bb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login_bb.BackgroundImage")));
            this.Login_bb.ButtonText = "Login";
            this.Login_bb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_bb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_bb.ForeColor = System.Drawing.Color.White;
            this.Login_bb.IdleBorderThickness = 1;
            this.Login_bb.IdleCornerRadius = 20;
            this.Login_bb.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Login_bb.IdleForecolor = System.Drawing.Color.Transparent;
            this.Login_bb.IdleLineColor = System.Drawing.Color.Transparent;
            this.Login_bb.Location = new System.Drawing.Point(229, 566);
            this.Login_bb.Margin = new System.Windows.Forms.Padding(5);
            this.Login_bb.Name = "Login_bb";
            this.Login_bb.Size = new System.Drawing.Size(200, 55);
            this.Login_bb.TabIndex = 27;
            this.Login_bb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Login_bb.Click += new System.EventHandler(this.Login_bb_Click);
            // 
            // Password_bmtb
            // 
            this.Password_bmtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_bmtb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_bmtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Password_bmtb.HintForeColor = System.Drawing.Color.Empty;
            this.Password_bmtb.HintText = "";
            this.Password_bmtb.isPassword = true;
            this.Password_bmtb.LineFocusedColor = System.Drawing.Color.Transparent;
            this.Password_bmtb.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Password_bmtb.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.Password_bmtb.LineThickness = 3;
            this.Password_bmtb.Location = new System.Drawing.Point(198, 425);
            this.Password_bmtb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Password_bmtb.Name = "Password_bmtb";
            this.Password_bmtb.Size = new System.Drawing.Size(266, 30);
            this.Password_bmtb.TabIndex = 26;
            this.Password_bmtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Password_blvl
            // 
            this.Password_blvl.AutoSize = true;
            this.Password_blvl.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_blvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Password_blvl.Location = new System.Drawing.Point(198, 372);
            this.Password_blvl.Name = "Password_blvl";
            this.Password_blvl.Size = new System.Drawing.Size(95, 22);
            this.Password_blvl.TabIndex = 25;
            this.Password_blvl.Text = "Password";
            // 
            // Id_bmtb
            // 
            this.Id_bmtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Id_bmtb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_bmtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Id_bmtb.HintForeColor = System.Drawing.Color.Empty;
            this.Id_bmtb.HintText = "";
            this.Id_bmtb.isPassword = false;
            this.Id_bmtb.LineFocusedColor = System.Drawing.Color.Transparent;
            this.Id_bmtb.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Id_bmtb.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.Id_bmtb.LineThickness = 3;
            this.Id_bmtb.Location = new System.Drawing.Point(198, 316);
            this.Id_bmtb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Id_bmtb.Name = "Id_bmtb";
            this.Id_bmtb.Size = new System.Drawing.Size(266, 30);
            this.Id_bmtb.TabIndex = 24;
            this.Id_bmtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Id_blvl
            // 
            this.Id_blvl.AutoSize = true;
            this.Id_blvl.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_blvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Id_blvl.Location = new System.Drawing.Point(198, 274);
            this.Id_blvl.Name = "Id_blvl";
            this.Id_blvl.Size = new System.Drawing.Size(29, 22);
            this.Id_blvl.TabIndex = 23;
            this.Id_blvl.Text = "ID";
            // 
            // login_first_blvl
            // 
            this.login_first_blvl.AutoSize = true;
            this.login_first_blvl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_first_blvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.login_first_blvl.Location = new System.Drawing.Point(247, 199);
            this.login_first_blvl.Name = "login_first_blvl";
            this.login_first_blvl.Size = new System.Drawing.Size(125, 28);
            this.login_first_blvl.TabIndex = 22;
            this.login_first_blvl.Text = "Login First";
            // 
            // Login_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(194)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1152, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Login_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Slide_Show_Log_In_Page slide_Show_Log_In_Page1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCheckbox Password_cb;
        private Bunifu.Framework.UI.BunifuThinButton2 Login_bb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Password_bmtb;
        private Bunifu.Framework.UI.BunifuCustomLabel Password_blvl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Id_bmtb;
        private Bunifu.Framework.UI.BunifuCustomLabel Id_blvl;
        private Bunifu.Framework.UI.BunifuCustomLabel login_first_blvl;
    }
}