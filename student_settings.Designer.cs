namespace Student_Officer
{
    partial class student_settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student_settings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcurrent_pass = new System.Windows.Forms.Label();
            this.lblnew_pass = new System.Windows.Forms.Label();
            this.lblconfirm_pass = new System.Windows.Forms.Label();
            this.txtbxCurrentPass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtbxNewPass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtbxConfirmPass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ButtonChngPass = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Mismatch_lvl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(169)))));
            this.panel1.Controls.Add(this.btnBack1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 65);
            this.panel1.TabIndex = 0;
            // 
            // btnBack1
            // 
            this.btnBack1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack1.BackColor = System.Drawing.Color.Transparent;
            this.btnBack1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack1.Image = ((System.Drawing.Image)(resources.GetObject("btnBack1.Image")));
            this.btnBack1.ImageActive = null;
            this.btnBack1.Location = new System.Drawing.Point(1109, 15);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(31, 35);
            this.btnBack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack1.TabIndex = 12;
            this.btnBack1.TabStop = false;
            this.btnBack1.Zoom = 10;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Change Password ";
            // 
            // lblcurrent_pass
            // 
            this.lblcurrent_pass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblcurrent_pass.AutoSize = true;
            this.lblcurrent_pass.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcurrent_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(169)))));
            this.lblcurrent_pass.Location = new System.Drawing.Point(252, 294);
            this.lblcurrent_pass.Name = "lblcurrent_pass";
            this.lblcurrent_pass.Size = new System.Drawing.Size(195, 30);
            this.lblcurrent_pass.TabIndex = 2;
            this.lblcurrent_pass.Text = "Currrent Password ";
            // 
            // lblnew_pass
            // 
            this.lblnew_pass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblnew_pass.AutoSize = true;
            this.lblnew_pass.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnew_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(169)))));
            this.lblnew_pass.Location = new System.Drawing.Point(289, 361);
            this.lblnew_pass.Name = "lblnew_pass";
            this.lblnew_pass.Size = new System.Drawing.Size(158, 30);
            this.lblnew_pass.TabIndex = 3;
            this.lblnew_pass.Text = "New Password ";
            // 
            // lblconfirm_pass
            // 
            this.lblconfirm_pass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblconfirm_pass.AutoSize = true;
            this.lblconfirm_pass.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfirm_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(169)))));
            this.lblconfirm_pass.Location = new System.Drawing.Point(255, 428);
            this.lblconfirm_pass.Name = "lblconfirm_pass";
            this.lblconfirm_pass.Size = new System.Drawing.Size(192, 30);
            this.lblconfirm_pass.TabIndex = 4;
            this.lblconfirm_pass.Text = "Confirm Password ";
            // 
            // txtbxCurrentPass
            // 
            this.txtbxCurrentPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtbxCurrentPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtbxCurrentPass.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(169)))));
            this.txtbxCurrentPass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(169)))));
            this.txtbxCurrentPass.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(169)))));
            this.txtbxCurrentPass.BorderThickness = 2;
            this.txtbxCurrentPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxCurrentPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxCurrentPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbxCurrentPass.isPassword = false;
            this.txtbxCurrentPass.Location = new System.Drawing.Point(475, 287);
            this.txtbxCurrentPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxCurrentPass.Name = "txtbxCurrentPass";
            this.txtbxCurrentPass.Size = new System.Drawing.Size(408, 37);
            this.txtbxCurrentPass.TabIndex = 5;
            this.txtbxCurrentPass.Text = "current password";
            this.txtbxCurrentPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtbxNewPass
            // 
            this.txtbxNewPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtbxNewPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtbxNewPass.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(169)))));
            this.txtbxNewPass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(169)))));
            this.txtbxNewPass.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(169)))));
            this.txtbxNewPass.BorderThickness = 2;
            this.txtbxNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxNewPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbxNewPass.isPassword = false;
            this.txtbxNewPass.Location = new System.Drawing.Point(475, 354);
            this.txtbxNewPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxNewPass.Name = "txtbxNewPass";
            this.txtbxNewPass.Size = new System.Drawing.Size(408, 37);
            this.txtbxNewPass.TabIndex = 6;
            this.txtbxNewPass.Text = "new password";
            this.txtbxNewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtbxConfirmPass
            // 
            this.txtbxConfirmPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtbxConfirmPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtbxConfirmPass.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(169)))));
            this.txtbxConfirmPass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(169)))));
            this.txtbxConfirmPass.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(169)))));
            this.txtbxConfirmPass.BorderThickness = 2;
            this.txtbxConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxConfirmPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxConfirmPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbxConfirmPass.isPassword = false;
            this.txtbxConfirmPass.Location = new System.Drawing.Point(475, 421);
            this.txtbxConfirmPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxConfirmPass.Name = "txtbxConfirmPass";
            this.txtbxConfirmPass.Size = new System.Drawing.Size(408, 37);
            this.txtbxConfirmPass.TabIndex = 7;
            this.txtbxConfirmPass.Text = "confirm password";
            this.txtbxConfirmPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ButtonChngPass
            // 
            this.ButtonChngPass.ActiveBorderThickness = 1;
            this.ButtonChngPass.ActiveCornerRadius = 15;
            this.ButtonChngPass.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.ButtonChngPass.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonChngPass.ActiveLineColor = System.Drawing.Color.Transparent;
            this.ButtonChngPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonChngPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ButtonChngPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonChngPass.BackgroundImage")));
            this.ButtonChngPass.ButtonText = "Change Password";
            this.ButtonChngPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonChngPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonChngPass.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonChngPass.IdleBorderThickness = 1;
            this.ButtonChngPass.IdleCornerRadius = 15;
            this.ButtonChngPass.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(169)))));
            this.ButtonChngPass.IdleForecolor = System.Drawing.Color.Transparent;
            this.ButtonChngPass.IdleLineColor = System.Drawing.Color.Transparent;
            this.ButtonChngPass.Location = new System.Drawing.Point(475, 496);
            this.ButtonChngPass.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonChngPass.Name = "ButtonChngPass";
            this.ButtonChngPass.Size = new System.Drawing.Size(193, 55);
            this.ButtonChngPass.TabIndex = 9;
            this.ButtonChngPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonChngPass.Click += new System.EventHandler(this.ButtonChngPass_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.ActiveBorderThickness = 1;
            this.ButtonCancel.ActiveCornerRadius = 15;
            this.ButtonCancel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.ButtonCancel.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonCancel.ActiveLineColor = System.Drawing.Color.Transparent;
            this.ButtonCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ButtonCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonCancel.BackgroundImage")));
            this.ButtonCancel.ButtonText = "Cancel";
            this.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonCancel.IdleBorderThickness = 1;
            this.ButtonCancel.IdleCornerRadius = 15;
            this.ButtonCancel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(169)))));
            this.ButtonCancel.IdleForecolor = System.Drawing.Color.Transparent;
            this.ButtonCancel.IdleLineColor = System.Drawing.Color.Transparent;
            this.ButtonCancel.Location = new System.Drawing.Point(690, 496);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(193, 55);
            this.ButtonCancel.TabIndex = 10;
            this.ButtonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // Mismatch_lvl
            // 
            this.Mismatch_lvl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Mismatch_lvl.AutoSize = true;
            this.Mismatch_lvl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mismatch_lvl.ForeColor = System.Drawing.Color.Red;
            this.Mismatch_lvl.Location = new System.Drawing.Point(586, 463);
            this.Mismatch_lvl.Name = "Mismatch_lvl";
            this.Mismatch_lvl.Size = new System.Drawing.Size(162, 13);
            this.Mismatch_lvl.TabIndex = 11;
            this.Mismatch_lvl.Text = "password does not matched !!";
            this.Mismatch_lvl.Visible = false;
            // 
            // student_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1152, 858);
            this.Controls.Add(this.Mismatch_lvl);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonChngPass);
            this.Controls.Add(this.txtbxConfirmPass);
            this.Controls.Add(this.txtbxNewPass);
            this.Controls.Add(this.txtbxCurrentPass);
            this.Controls.Add(this.lblconfirm_pass);
            this.Controls.Add(this.lblnew_pass);
            this.Controls.Add(this.lblcurrent_pass);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1168, 897);
            this.Name = "student_settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "student_settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcurrent_pass;
        private System.Windows.Forms.Label lblnew_pass;
        private System.Windows.Forms.Label lblconfirm_pass;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtbxCurrentPass;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtbxNewPass;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtbxConfirmPass;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonChngPass;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonCancel;
        private System.Windows.Forms.Label Mismatch_lvl;
        private Bunifu.Framework.UI.BunifuImageButton btnBack1;
    }
}