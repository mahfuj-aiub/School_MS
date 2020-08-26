namespace School_MS
{
    partial class Search_Student_Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Student_Admin));
            this.Student_bcdgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ID_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Count_bclvl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Input_name_bmtb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Sname_bclvl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Sparent_bclvl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.S_email_bclvl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Search_btbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Name_blvl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.parent_bclvl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Email_bclvl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ID_blvl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.S_Id_bclvl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Refresh_btbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Delete_btbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.Student_bcdgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Student_bcdgv
            // 
            this.Student_bcdgv.AllowUserToAddRows = false;
            this.Student_bcdgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Student_bcdgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.Student_bcdgv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Student_bcdgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Student_bcdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Student_bcdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.Student_bcdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Student_bcdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_col,
            this.Name_col,
            this.P_name_col,
            this.phone_col,
            this.mail_col,
            this.dob_col,
            this.add_col});
            this.Student_bcdgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Student_bcdgv.DoubleBuffered = true;
            this.Student_bcdgv.EnableHeadersVisualStyles = false;
            this.Student_bcdgv.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Student_bcdgv.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Student_bcdgv.Location = new System.Drawing.Point(0, 265);
            this.Student_bcdgv.Name = "Student_bcdgv";
            this.Student_bcdgv.ReadOnly = true;
            this.Student_bcdgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Student_bcdgv.Size = new System.Drawing.Size(834, 269);
            this.Student_bcdgv.TabIndex = 0;
            this.Student_bcdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Student_bcdgv_CellContentClick);
            // 
            // ID_col
            // 
            this.ID_col.DataPropertyName = "stu_id";
            this.ID_col.HeaderText = "Student ID";
            this.ID_col.Name = "ID_col";
            this.ID_col.ReadOnly = true;
            // 
            // Name_col
            // 
            this.Name_col.DataPropertyName = "name";
            this.Name_col.HeaderText = "Student Name";
            this.Name_col.Name = "Name_col";
            this.Name_col.ReadOnly = true;
            this.Name_col.Width = 150;
            // 
            // P_name_col
            // 
            this.P_name_col.DataPropertyName = "parent_name";
            this.P_name_col.HeaderText = "Parent_Name";
            this.P_name_col.Name = "P_name_col";
            this.P_name_col.ReadOnly = true;
            this.P_name_col.Width = 150;
            // 
            // phone_col
            // 
            this.phone_col.DataPropertyName = "phone";
            this.phone_col.HeaderText = "Phone";
            this.phone_col.Name = "phone_col";
            this.phone_col.ReadOnly = true;
            this.phone_col.Width = 120;
            // 
            // mail_col
            // 
            this.mail_col.DataPropertyName = "email";
            this.mail_col.HeaderText = "Email";
            this.mail_col.Name = "mail_col";
            this.mail_col.ReadOnly = true;
            this.mail_col.Width = 150;
            // 
            // dob_col
            // 
            this.dob_col.DataPropertyName = "dob";
            this.dob_col.HeaderText = "Date of Birth";
            this.dob_col.Name = "dob_col";
            this.dob_col.ReadOnly = true;
            // 
            // add_col
            // 
            this.add_col.DataPropertyName = "address";
            this.add_col.HeaderText = "Address";
            this.add_col.Name = "add_col";
            this.add_col.ReadOnly = true;
            this.add_col.Width = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(86)))), ((int)(((byte)(229)))));
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 24);
            this.panel1.TabIndex = 1;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(70, 20);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Students";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(667, 27);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(109, 20);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Total Student :";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // Count_bclvl
            // 
            this.Count_bclvl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Count_bclvl.Location = new System.Drawing.Point(782, 27);
            this.Count_bclvl.Name = "Count_bclvl";
            this.Count_bclvl.Size = new System.Drawing.Size(52, 20);
            this.Count_bclvl.TabIndex = 4;
            this.Count_bclvl.Text = "500";
            this.Count_bclvl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Input_name_bmtb
            // 
            this.Input_name_bmtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Input_name_bmtb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_name_bmtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Input_name_bmtb.HintForeColor = System.Drawing.Color.Empty;
            this.Input_name_bmtb.HintText = "Input Name";
            this.Input_name_bmtb.isPassword = false;
            this.Input_name_bmtb.LineFocusedColor = System.Drawing.Color.Transparent;
            this.Input_name_bmtb.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Input_name_bmtb.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.Input_name_bmtb.LineThickness = 3;
            this.Input_name_bmtb.Location = new System.Drawing.Point(7, 27);
            this.Input_name_bmtb.Margin = new System.Windows.Forms.Padding(4);
            this.Input_name_bmtb.Name = "Input_name_bmtb";
            this.Input_name_bmtb.Size = new System.Drawing.Size(199, 31);
            this.Input_name_bmtb.TabIndex = 5;
            this.Input_name_bmtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Sname_bclvl
            // 
            this.Sname_bclvl.AutoSize = true;
            this.Sname_bclvl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sname_bclvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Sname_bclvl.Location = new System.Drawing.Point(220, 137);
            this.Sname_bclvl.Name = "Sname_bclvl";
            this.Sname_bclvl.Size = new System.Drawing.Size(47, 16);
            this.Sname_bclvl.TabIndex = 7;
            this.Sname_bclvl.Text = "Name";
            // 
            // Sparent_bclvl
            // 
            this.Sparent_bclvl.AutoSize = true;
            this.Sparent_bclvl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sparent_bclvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Sparent_bclvl.Location = new System.Drawing.Point(218, 178);
            this.Sparent_bclvl.Name = "Sparent_bclvl";
            this.Sparent_bclvl.Size = new System.Drawing.Size(49, 16);
            this.Sparent_bclvl.TabIndex = 8;
            this.Sparent_bclvl.Text = "Parent";
            // 
            // S_email_bclvl
            // 
            this.S_email_bclvl.AutoSize = true;
            this.S_email_bclvl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_email_bclvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.S_email_bclvl.Location = new System.Drawing.Point(223, 222);
            this.S_email_bclvl.Name = "S_email_bclvl";
            this.S_email_bclvl.Size = new System.Drawing.Size(44, 16);
            this.S_email_bclvl.TabIndex = 9;
            this.S_email_bclvl.Text = "Email";
            this.S_email_bclvl.UseMnemonic = false;
            // 
            // Search_btbtn
            // 
            this.Search_btbtn.ActiveBorderThickness = 1;
            this.Search_btbtn.ActiveCornerRadius = 20;
            this.Search_btbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(159)))));
            this.Search_btbtn.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.Search_btbtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.Search_btbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_btbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(194)))), ((int)(((byte)(200)))));
            this.Search_btbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Search_btbtn.BackgroundImage")));
            this.Search_btbtn.ButtonText = "Search";
            this.Search_btbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_btbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btbtn.ForeColor = System.Drawing.Color.White;
            this.Search_btbtn.IdleBorderThickness = 1;
            this.Search_btbtn.IdleCornerRadius = 20;
            this.Search_btbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.Search_btbtn.IdleForecolor = System.Drawing.Color.Transparent;
            this.Search_btbtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.Search_btbtn.Location = new System.Drawing.Point(215, 27);
            this.Search_btbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Search_btbtn.Name = "Search_btbtn";
            this.Search_btbtn.Size = new System.Drawing.Size(81, 35);
            this.Search_btbtn.TabIndex = 121;
            this.Search_btbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Search_btbtn.Click += new System.EventHandler(this.Search_btbtn_Click);
            // 
            // Name_blvl
            // 
            this.Name_blvl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Name_blvl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_blvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Name_blvl.Location = new System.Drawing.Point(303, 129);
            this.Name_blvl.Name = "Name_blvl";
            this.Name_blvl.Size = new System.Drawing.Size(286, 30);
            this.Name_blvl.TabIndex = 128;
            this.Name_blvl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Name_blvl.Click += new System.EventHandler(this.Name_blvl_Click);
            // 
            // parent_bclvl
            // 
            this.parent_bclvl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parent_bclvl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parent_bclvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.parent_bclvl.Location = new System.Drawing.Point(303, 172);
            this.parent_bclvl.Name = "parent_bclvl";
            this.parent_bclvl.Size = new System.Drawing.Size(286, 26);
            this.parent_bclvl.TabIndex = 129;
            this.parent_bclvl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Email_bclvl
            // 
            this.Email_bclvl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Email_bclvl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_bclvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Email_bclvl.Location = new System.Drawing.Point(303, 212);
            this.Email_bclvl.Name = "Email_bclvl";
            this.Email_bclvl.Size = new System.Drawing.Size(286, 34);
            this.Email_bclvl.TabIndex = 130;
            this.Email_bclvl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ID_blvl
            // 
            this.ID_blvl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ID_blvl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_blvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.ID_blvl.Location = new System.Drawing.Point(303, 85);
            this.ID_blvl.Name = "ID_blvl";
            this.ID_blvl.Size = new System.Drawing.Size(286, 30);
            this.ID_blvl.TabIndex = 131;
            this.ID_blvl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // S_Id_bclvl
            // 
            this.S_Id_bclvl.AutoSize = true;
            this.S_Id_bclvl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_Id_bclvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.S_Id_bclvl.Location = new System.Drawing.Point(246, 93);
            this.S_Id_bclvl.Name = "S_Id_bclvl";
            this.S_Id_bclvl.Size = new System.Drawing.Size(21, 16);
            this.S_Id_bclvl.TabIndex = 132;
            this.S_Id_bclvl.Text = "ID";
            // 
            // Refresh_btbtn
            // 
            this.Refresh_btbtn.ActiveBorderThickness = 1;
            this.Refresh_btbtn.ActiveCornerRadius = 20;
            this.Refresh_btbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(159)))));
            this.Refresh_btbtn.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.Refresh_btbtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.Refresh_btbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Refresh_btbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(194)))), ((int)(((byte)(200)))));
            this.Refresh_btbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Refresh_btbtn.BackgroundImage")));
            this.Refresh_btbtn.ButtonText = "Refresh";
            this.Refresh_btbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refresh_btbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_btbtn.ForeColor = System.Drawing.Color.White;
            this.Refresh_btbtn.IdleBorderThickness = 1;
            this.Refresh_btbtn.IdleCornerRadius = 20;
            this.Refresh_btbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.Refresh_btbtn.IdleForecolor = System.Drawing.Color.Transparent;
            this.Refresh_btbtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.Refresh_btbtn.Location = new System.Drawing.Point(306, 27);
            this.Refresh_btbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Refresh_btbtn.Name = "Refresh_btbtn";
            this.Refresh_btbtn.Size = new System.Drawing.Size(81, 35);
            this.Refresh_btbtn.TabIndex = 133;
            this.Refresh_btbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Refresh_btbtn.Click += new System.EventHandler(this.Refresh_btbtn_Click);
            // 
            // Delete_btbtn
            // 
            this.Delete_btbtn.ActiveBorderThickness = 1;
            this.Delete_btbtn.ActiveCornerRadius = 20;
            this.Delete_btbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Delete_btbtn.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.Delete_btbtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.Delete_btbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_btbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(194)))), ((int)(((byte)(200)))));
            this.Delete_btbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete_btbtn.BackgroundImage")));
            this.Delete_btbtn.ButtonText = "Delete";
            this.Delete_btbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_btbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btbtn.ForeColor = System.Drawing.Color.White;
            this.Delete_btbtn.IdleBorderThickness = 1;
            this.Delete_btbtn.IdleCornerRadius = 20;
            this.Delete_btbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.Delete_btbtn.IdleForecolor = System.Drawing.Color.Transparent;
            this.Delete_btbtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.Delete_btbtn.Location = new System.Drawing.Point(397, 27);
            this.Delete_btbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Delete_btbtn.Name = "Delete_btbtn";
            this.Delete_btbtn.Size = new System.Drawing.Size(81, 35);
            this.Delete_btbtn.TabIndex = 134;
            this.Delete_btbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Delete_btbtn.Click += new System.EventHandler(this.Delete_btbtn_Click);
            // 
            // Search_Student_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(194)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.Delete_btbtn);
            this.Controls.Add(this.Refresh_btbtn);
            this.Controls.Add(this.S_Id_bclvl);
            this.Controls.Add(this.ID_blvl);
            this.Controls.Add(this.Email_bclvl);
            this.Controls.Add(this.parent_bclvl);
            this.Controls.Add(this.Name_blvl);
            this.Controls.Add(this.Search_btbtn);
            this.Controls.Add(this.S_email_bclvl);
            this.Controls.Add(this.Sparent_bclvl);
            this.Controls.Add(this.Sname_bclvl);
            this.Controls.Add(this.Input_name_bmtb);
            this.Controls.Add(this.Count_bclvl);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Student_bcdgv);
            this.Name = "Search_Student_Admin";
            this.Size = new System.Drawing.Size(834, 534);
            this.Load += new System.EventHandler(this.Search_Student_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Student_bcdgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid Student_bcdgv;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel Count_bclvl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Input_name_bmtb;
        private Bunifu.Framework.UI.BunifuCustomLabel Sname_bclvl;
        private Bunifu.Framework.UI.BunifuCustomLabel Sparent_bclvl;
        private Bunifu.Framework.UI.BunifuCustomLabel S_email_bclvl;
        private Bunifu.Framework.UI.BunifuThinButton2 Search_btbtn;
        private Bunifu.Framework.UI.BunifuCustomLabel Name_blvl;
        private Bunifu.Framework.UI.BunifuCustomLabel parent_bclvl;
        private Bunifu.Framework.UI.BunifuCustomLabel Email_bclvl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn add_col;
        private Bunifu.Framework.UI.BunifuCustomLabel ID_blvl;
        private Bunifu.Framework.UI.BunifuCustomLabel S_Id_bclvl;
        private Bunifu.Framework.UI.BunifuThinButton2 Refresh_btbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 Delete_btbtn;
    }
}
