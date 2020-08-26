namespace School_MS
{
    partial class Assigned_Subject_To_Teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assigned_Subject_To_Teacher));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Select_class_bdd = new Bunifu.Framework.UI.BunifuDropdown();
            this.Select_subject_bclvl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Select_section_bclvl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Select_section_bdd = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Select_subject_bdd = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Select_teacher_bdd = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Teacher_ID_bdd = new Bunifu.Framework.UI.BunifuDropdown();
            this.Assign_btbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Cancel_btbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Subject_id_bdd = new Bunifu.Framework.UI.BunifuDropdown();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(86)))), ((int)(((byte)(229)))));
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 24);
            this.panel1.TabIndex = 2;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(137, 20);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Assigned Teacher";
            // 
            // Select_class_bdd
            // 
            this.Select_class_bdd.BackColor = System.Drawing.Color.Transparent;
            this.Select_class_bdd.BorderRadius = 3;
            this.Select_class_bdd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_class_bdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Select_class_bdd.Items = new string[0];
            this.Select_class_bdd.Location = new System.Drawing.Point(310, 94);
            this.Select_class_bdd.Margin = new System.Windows.Forms.Padding(4);
            this.Select_class_bdd.Name = "Select_class_bdd";
            this.Select_class_bdd.NomalColor = System.Drawing.Color.SteelBlue;
            this.Select_class_bdd.onHoverColor = System.Drawing.Color.SteelBlue;
            this.Select_class_bdd.selectedIndex = -1;
            this.Select_class_bdd.Size = new System.Drawing.Size(248, 35);
            this.Select_class_bdd.TabIndex = 106;
            this.Select_class_bdd.onItemSelected += new System.EventHandler(this.Select_class_bdd_onItemSelected);
            // 
            // Select_subject_bclvl
            // 
            this.Select_subject_bclvl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Select_subject_bclvl.AutoSize = true;
            this.Select_subject_bclvl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_subject_bclvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.Select_subject_bclvl.Location = new System.Drawing.Point(203, 112);
            this.Select_subject_bclvl.Name = "Select_subject_bclvl";
            this.Select_subject_bclvl.Size = new System.Drawing.Size(77, 17);
            this.Select_subject_bclvl.TabIndex = 107;
            this.Select_subject_bclvl.Text = "Select Class";
            // 
            // Select_section_bclvl
            // 
            this.Select_section_bclvl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Select_section_bclvl.AutoSize = true;
            this.Select_section_bclvl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_section_bclvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.Select_section_bclvl.Location = new System.Drawing.Point(189, 164);
            this.Select_section_bclvl.Name = "Select_section_bclvl";
            this.Select_section_bclvl.Size = new System.Drawing.Size(91, 17);
            this.Select_section_bclvl.TabIndex = 108;
            this.Select_section_bclvl.Text = "Select Section";
            // 
            // Select_section_bdd
            // 
            this.Select_section_bdd.BackColor = System.Drawing.Color.Transparent;
            this.Select_section_bdd.BorderRadius = 3;
            this.Select_section_bdd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_section_bdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Select_section_bdd.Items = new string[0];
            this.Select_section_bdd.Location = new System.Drawing.Point(310, 146);
            this.Select_section_bdd.Margin = new System.Windows.Forms.Padding(4);
            this.Select_section_bdd.Name = "Select_section_bdd";
            this.Select_section_bdd.NomalColor = System.Drawing.Color.SteelBlue;
            this.Select_section_bdd.onHoverColor = System.Drawing.Color.SteelBlue;
            this.Select_section_bdd.selectedIndex = -1;
            this.Select_section_bdd.Size = new System.Drawing.Size(248, 35);
            this.Select_section_bdd.TabIndex = 109;
            this.Select_section_bdd.onItemSelected += new System.EventHandler(this.Select_section_bdd_onItemSelected);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(189, 216);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(91, 17);
            this.bunifuCustomLabel2.TabIndex = 110;
            this.bunifuCustomLabel2.Text = "Select Subject";
            // 
            // Select_subject_bdd
            // 
            this.Select_subject_bdd.BackColor = System.Drawing.Color.Transparent;
            this.Select_subject_bdd.BorderRadius = 3;
            this.Select_subject_bdd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_subject_bdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Select_subject_bdd.Items = new string[0];
            this.Select_subject_bdd.Location = new System.Drawing.Point(310, 198);
            this.Select_subject_bdd.Margin = new System.Windows.Forms.Padding(4);
            this.Select_subject_bdd.Name = "Select_subject_bdd";
            this.Select_subject_bdd.NomalColor = System.Drawing.Color.SteelBlue;
            this.Select_subject_bdd.onHoverColor = System.Drawing.Color.SteelBlue;
            this.Select_subject_bdd.selectedIndex = -1;
            this.Select_subject_bdd.Size = new System.Drawing.Size(248, 35);
            this.Select_subject_bdd.TabIndex = 111;
            this.Select_subject_bdd.onItemSelected += new System.EventHandler(this.Select_subject_bdd_onItemSelected);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(187, 268);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(93, 17);
            this.bunifuCustomLabel3.TabIndex = 112;
            this.bunifuCustomLabel3.Text = "Select Teacher";
            // 
            // Select_teacher_bdd
            // 
            this.Select_teacher_bdd.BackColor = System.Drawing.Color.Transparent;
            this.Select_teacher_bdd.BorderRadius = 3;
            this.Select_teacher_bdd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_teacher_bdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Select_teacher_bdd.Items = new string[0];
            this.Select_teacher_bdd.Location = new System.Drawing.Point(310, 250);
            this.Select_teacher_bdd.Margin = new System.Windows.Forms.Padding(4);
            this.Select_teacher_bdd.Name = "Select_teacher_bdd";
            this.Select_teacher_bdd.NomalColor = System.Drawing.Color.SteelBlue;
            this.Select_teacher_bdd.onHoverColor = System.Drawing.Color.SteelBlue;
            this.Select_teacher_bdd.selectedIndex = -1;
            this.Select_teacher_bdd.Size = new System.Drawing.Size(248, 35);
            this.Select_teacher_bdd.TabIndex = 113;
            this.Select_teacher_bdd.onItemSelected += new System.EventHandler(this.Select_teacher_bdd_onItemSelected);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(209, 320);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(71, 17);
            this.bunifuCustomLabel4.TabIndex = 114;
            this.bunifuCustomLabel4.Text = "Teacher ID";
            // 
            // Teacher_ID_bdd
            // 
            this.Teacher_ID_bdd.BackColor = System.Drawing.Color.Transparent;
            this.Teacher_ID_bdd.BorderRadius = 3;
            this.Teacher_ID_bdd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_ID_bdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Teacher_ID_bdd.Items = new string[0];
            this.Teacher_ID_bdd.Location = new System.Drawing.Point(310, 302);
            this.Teacher_ID_bdd.Margin = new System.Windows.Forms.Padding(4);
            this.Teacher_ID_bdd.Name = "Teacher_ID_bdd";
            this.Teacher_ID_bdd.NomalColor = System.Drawing.Color.SteelBlue;
            this.Teacher_ID_bdd.onHoverColor = System.Drawing.Color.SteelBlue;
            this.Teacher_ID_bdd.selectedIndex = -1;
            this.Teacher_ID_bdd.Size = new System.Drawing.Size(248, 35);
            this.Teacher_ID_bdd.TabIndex = 115;
            this.Teacher_ID_bdd.onItemSelected += new System.EventHandler(this.Teacher_ID_bdd_onItemSelected);
            // 
            // Assign_btbtn
            // 
            this.Assign_btbtn.ActiveBorderThickness = 1;
            this.Assign_btbtn.ActiveCornerRadius = 20;
            this.Assign_btbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(159)))));
            this.Assign_btbtn.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.Assign_btbtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.Assign_btbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Assign_btbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(194)))), ((int)(((byte)(200)))));
            this.Assign_btbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Assign_btbtn.BackgroundImage")));
            this.Assign_btbtn.ButtonText = "Assign";
            this.Assign_btbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Assign_btbtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assign_btbtn.ForeColor = System.Drawing.Color.White;
            this.Assign_btbtn.IdleBorderThickness = 1;
            this.Assign_btbtn.IdleCornerRadius = 20;
            this.Assign_btbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.Assign_btbtn.IdleForecolor = System.Drawing.Color.Transparent;
            this.Assign_btbtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.Assign_btbtn.Location = new System.Drawing.Point(434, 359);
            this.Assign_btbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Assign_btbtn.Name = "Assign_btbtn";
            this.Assign_btbtn.Size = new System.Drawing.Size(124, 39);
            this.Assign_btbtn.TabIndex = 119;
            this.Assign_btbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Assign_btbtn.Click += new System.EventHandler(this.Assign_btbtn_Click);
            // 
            // Cancel_btbtn
            // 
            this.Cancel_btbtn.ActiveBorderThickness = 1;
            this.Cancel_btbtn.ActiveCornerRadius = 20;
            this.Cancel_btbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(159)))));
            this.Cancel_btbtn.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.Cancel_btbtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.Cancel_btbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel_btbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(194)))), ((int)(((byte)(200)))));
            this.Cancel_btbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cancel_btbtn.BackgroundImage")));
            this.Cancel_btbtn.ButtonText = "Cancel";
            this.Cancel_btbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel_btbtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_btbtn.ForeColor = System.Drawing.Color.White;
            this.Cancel_btbtn.IdleBorderThickness = 1;
            this.Cancel_btbtn.IdleCornerRadius = 20;
            this.Cancel_btbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.Cancel_btbtn.IdleForecolor = System.Drawing.Color.Transparent;
            this.Cancel_btbtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.Cancel_btbtn.Location = new System.Drawing.Point(310, 359);
            this.Cancel_btbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Cancel_btbtn.Name = "Cancel_btbtn";
            this.Cancel_btbtn.Size = new System.Drawing.Size(116, 39);
            this.Cancel_btbtn.TabIndex = 120;
            this.Cancel_btbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cancel_btbtn.Click += new System.EventHandler(this.Cancel_btbtn_Click);
            // 
            // Subject_id_bdd
            // 
            this.Subject_id_bdd.BackColor = System.Drawing.Color.Transparent;
            this.Subject_id_bdd.BorderRadius = 3;
            this.Subject_id_bdd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject_id_bdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Subject_id_bdd.Items = new string[0];
            this.Subject_id_bdd.Location = new System.Drawing.Point(566, 198);
            this.Subject_id_bdd.Margin = new System.Windows.Forms.Padding(4);
            this.Subject_id_bdd.Name = "Subject_id_bdd";
            this.Subject_id_bdd.NomalColor = System.Drawing.Color.SteelBlue;
            this.Subject_id_bdd.onHoverColor = System.Drawing.Color.SteelBlue;
            this.Subject_id_bdd.selectedIndex = -1;
            this.Subject_id_bdd.Size = new System.Drawing.Size(112, 35);
            this.Subject_id_bdd.TabIndex = 121;
            this.Subject_id_bdd.Visible = false;
            // 
            // Assigned_Subject_To_Teacher
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(194)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.Subject_id_bdd);
            this.Controls.Add(this.Cancel_btbtn);
            this.Controls.Add(this.Assign_btbtn);
            this.Controls.Add(this.Teacher_ID_bdd);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.Select_teacher_bdd);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.Select_subject_bdd);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.Select_section_bdd);
            this.Controls.Add(this.Select_section_bclvl);
            this.Controls.Add(this.Select_subject_bclvl);
            this.Controls.Add(this.Select_class_bdd);
            this.Controls.Add(this.panel1);
            this.Name = "Assigned_Subject_To_Teacher";
            this.Size = new System.Drawing.Size(834, 534);
            this.Load += new System.EventHandler(this.Assigned_Subject_To_Teacher_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDropdown Select_class_bdd;
        private Bunifu.Framework.UI.BunifuCustomLabel Select_subject_bclvl;
        private Bunifu.Framework.UI.BunifuCustomLabel Select_section_bclvl;
        private Bunifu.Framework.UI.BunifuDropdown Select_section_bdd;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDropdown Select_subject_bdd;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuDropdown Select_teacher_bdd;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuDropdown Teacher_ID_bdd;
        private Bunifu.Framework.UI.BunifuThinButton2 Assign_btbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 Cancel_btbtn;
        private Bunifu.Framework.UI.BunifuDropdown Subject_id_bdd;
    }
}
