namespace School_MS
{
    partial class Add_Subject_To_Students
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Subject_To_Students));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Select_subject_bdd = new Bunifu.Framework.UI.BunifuDropdown();
            this.Student_bcdgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ID_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Input_name_bmtb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Search_btbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Select_student_bclvl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Select_section_bclvl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Name_blvl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ID_blvl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Assign_btbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Cancel_btbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Refresh_btbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Select_id_bdd = new Bunifu.Framework.UI.BunifuDropdown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Student_bcdgv)).BeginInit();
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
            this.panel1.TabIndex = 4;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(210, 20);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Assigned Subject To Student";
            // 
            // Select_subject_bdd
            // 
            this.Select_subject_bdd.BackColor = System.Drawing.Color.Transparent;
            this.Select_subject_bdd.BorderRadius = 3;
            this.Select_subject_bdd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_subject_bdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Select_subject_bdd.Items = new string[0];
            this.Select_subject_bdd.Location = new System.Drawing.Point(113, 128);
            this.Select_subject_bdd.Margin = new System.Windows.Forms.Padding(4);
            this.Select_subject_bdd.Name = "Select_subject_bdd";
            this.Select_subject_bdd.NomalColor = System.Drawing.Color.SteelBlue;
            this.Select_subject_bdd.onHoverColor = System.Drawing.Color.SteelBlue;
            this.Select_subject_bdd.selectedIndex = -1;
            this.Select_subject_bdd.Size = new System.Drawing.Size(235, 35);
            this.Select_subject_bdd.TabIndex = 128;
            this.Select_subject_bdd.onItemSelected += new System.EventHandler(this.Select_subject_bdd_onItemSelected);
            // 
            // Student_bcdgv
            // 
            this.Student_bcdgv.AllowUserToAddRows = false;
            this.Student_bcdgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Student_bcdgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Student_bcdgv.BackgroundColor = System.Drawing.Color.White;
            this.Student_bcdgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Student_bcdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Student_bcdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Student_bcdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Student_bcdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_col,
            this.Name_col,
            this.mail_col});
            this.Student_bcdgv.DoubleBuffered = true;
            this.Student_bcdgv.EnableHeadersVisualStyles = false;
            this.Student_bcdgv.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Student_bcdgv.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Student_bcdgv.Location = new System.Drawing.Point(203, 264);
            this.Student_bcdgv.Name = "Student_bcdgv";
            this.Student_bcdgv.ReadOnly = true;
            this.Student_bcdgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Student_bcdgv.Size = new System.Drawing.Size(439, 190);
            this.Student_bcdgv.TabIndex = 129;
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
            // mail_col
            // 
            this.mail_col.DataPropertyName = "email";
            this.mail_col.HeaderText = "Email";
            this.mail_col.Name = "mail_col";
            this.mail_col.ReadOnly = true;
            this.mail_col.Width = 150;
            // 
            // Input_name_bmtb
            // 
            this.Input_name_bmtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Input_name_bmtb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Input_name_bmtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Input_name_bmtb.HintForeColor = System.Drawing.Color.Empty;
            this.Input_name_bmtb.HintText = "Input Name";
            this.Input_name_bmtb.isPassword = false;
            this.Input_name_bmtb.LineFocusedColor = System.Drawing.Color.Transparent;
            this.Input_name_bmtb.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Input_name_bmtb.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.Input_name_bmtb.LineThickness = 3;
            this.Input_name_bmtb.Location = new System.Drawing.Point(7, 31);
            this.Input_name_bmtb.Margin = new System.Windows.Forms.Padding(4);
            this.Input_name_bmtb.Name = "Input_name_bmtb";
            this.Input_name_bmtb.Size = new System.Drawing.Size(199, 34);
            this.Input_name_bmtb.TabIndex = 130;
            this.Input_name_bmtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Search_btbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(194)))), ((int)(((byte)(200)))));
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
            this.Search_btbtn.Location = new System.Drawing.Point(203, 32);
            this.Search_btbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Search_btbtn.Name = "Search_btbtn";
            this.Search_btbtn.Size = new System.Drawing.Size(81, 34);
            this.Search_btbtn.TabIndex = 131;
            this.Search_btbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Search_btbtn.Click += new System.EventHandler(this.Search_btbtn_Click);
            // 
            // Select_student_bclvl
            // 
            this.Select_student_bclvl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Select_student_bclvl.AutoSize = true;
            this.Select_student_bclvl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_student_bclvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.Select_student_bclvl.Location = new System.Drawing.Point(364, 244);
            this.Select_student_bclvl.Name = "Select_student_bclvl";
            this.Select_student_bclvl.Size = new System.Drawing.Size(95, 17);
            this.Select_student_bclvl.TabIndex = 132;
            this.Select_student_bclvl.Text = "Select Student";
            // 
            // Select_section_bclvl
            // 
            this.Select_section_bclvl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Select_section_bclvl.AutoSize = true;
            this.Select_section_bclvl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_section_bclvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.Select_section_bclvl.Location = new System.Drawing.Point(15, 146);
            this.Select_section_bclvl.Name = "Select_section_bclvl";
            this.Select_section_bclvl.Size = new System.Drawing.Size(91, 17);
            this.Select_section_bclvl.TabIndex = 133;
            this.Select_section_bclvl.Text = "Select Subject";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(50, 183);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(56, 17);
            this.bunifuCustomLabel2.TabIndex = 134;
            this.bunifuCustomLabel2.Text = "Student";
            // 
            // Name_blvl
            // 
            this.Name_blvl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Name_blvl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_blvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Name_blvl.Location = new System.Drawing.Point(113, 176);
            this.Name_blvl.Name = "Name_blvl";
            this.Name_blvl.Size = new System.Drawing.Size(235, 30);
            this.Name_blvl.TabIndex = 135;
            this.Name_blvl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(85, 226);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(21, 17);
            this.bunifuCustomLabel3.TabIndex = 136;
            this.bunifuCustomLabel3.Text = "ID";
            // 
            // ID_blvl
            // 
            this.ID_blvl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ID_blvl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_blvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.ID_blvl.Location = new System.Drawing.Point(113, 219);
            this.ID_blvl.Name = "ID_blvl";
            this.ID_blvl.Size = new System.Drawing.Size(235, 30);
            this.ID_blvl.TabIndex = 137;
            this.ID_blvl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.Assign_btbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(194)))), ((int)(((byte)(200)))));
            this.Assign_btbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Assign_btbtn.BackgroundImage")));
            this.Assign_btbtn.ButtonText = "Assign";
            this.Assign_btbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Assign_btbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assign_btbtn.ForeColor = System.Drawing.Color.White;
            this.Assign_btbtn.IdleBorderThickness = 1;
            this.Assign_btbtn.IdleCornerRadius = 20;
            this.Assign_btbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.Assign_btbtn.IdleForecolor = System.Drawing.Color.Transparent;
            this.Assign_btbtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.Assign_btbtn.Location = new System.Drawing.Point(446, 471);
            this.Assign_btbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Assign_btbtn.Name = "Assign_btbtn";
            this.Assign_btbtn.Size = new System.Drawing.Size(90, 43);
            this.Assign_btbtn.TabIndex = 138;
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
            this.Cancel_btbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(194)))), ((int)(((byte)(200)))));
            this.Cancel_btbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cancel_btbtn.BackgroundImage")));
            this.Cancel_btbtn.ButtonText = "Cancel";
            this.Cancel_btbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel_btbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_btbtn.ForeColor = System.Drawing.Color.White;
            this.Cancel_btbtn.IdleBorderThickness = 1;
            this.Cancel_btbtn.IdleCornerRadius = 20;
            this.Cancel_btbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.Cancel_btbtn.IdleForecolor = System.Drawing.Color.Transparent;
            this.Cancel_btbtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.Cancel_btbtn.Location = new System.Drawing.Point(315, 471);
            this.Cancel_btbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Cancel_btbtn.Name = "Cancel_btbtn";
            this.Cancel_btbtn.Size = new System.Drawing.Size(92, 43);
            this.Cancel_btbtn.TabIndex = 139;
            this.Cancel_btbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cancel_btbtn.Click += new System.EventHandler(this.Cancel_btbtn_Click);
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
            this.Refresh_btbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(194)))), ((int)(((byte)(200)))));
            this.Refresh_btbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Refresh_btbtn.BackgroundImage")));
            this.Refresh_btbtn.ButtonText = "Refresh";
            this.Refresh_btbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refresh_btbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_btbtn.ForeColor = System.Drawing.Color.White;
            this.Refresh_btbtn.IdleBorderThickness = 1;
            this.Refresh_btbtn.IdleCornerRadius = 20;
            this.Refresh_btbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.Refresh_btbtn.IdleForecolor = System.Drawing.Color.Transparent;
            this.Refresh_btbtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.Refresh_btbtn.Location = new System.Drawing.Point(294, 31);
            this.Refresh_btbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Refresh_btbtn.Name = "Refresh_btbtn";
            this.Refresh_btbtn.Size = new System.Drawing.Size(85, 34);
            this.Refresh_btbtn.TabIndex = 140;
            this.Refresh_btbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Refresh_btbtn.Click += new System.EventHandler(this.Refresh_btbtn_Click);
            // 
            // Select_id_bdd
            // 
            this.Select_id_bdd.BackColor = System.Drawing.Color.Transparent;
            this.Select_id_bdd.BorderRadius = 3;
            this.Select_id_bdd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_id_bdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Select_id_bdd.Items = new string[0];
            this.Select_id_bdd.Location = new System.Drawing.Point(113, 85);
            this.Select_id_bdd.Margin = new System.Windows.Forms.Padding(4);
            this.Select_id_bdd.Name = "Select_id_bdd";
            this.Select_id_bdd.NomalColor = System.Drawing.Color.SteelBlue;
            this.Select_id_bdd.onHoverColor = System.Drawing.Color.SteelBlue;
            this.Select_id_bdd.selectedIndex = -1;
            this.Select_id_bdd.Size = new System.Drawing.Size(83, 35);
            this.Select_id_bdd.TabIndex = 141;
            this.Select_id_bdd.Visible = false;
            // 
            // Add_Subject_To_Students
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(194)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.Select_id_bdd);
            this.Controls.Add(this.Refresh_btbtn);
            this.Controls.Add(this.Cancel_btbtn);
            this.Controls.Add(this.Assign_btbtn);
            this.Controls.Add(this.ID_blvl);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.Name_blvl);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.Select_section_bclvl);
            this.Controls.Add(this.Select_student_bclvl);
            this.Controls.Add(this.Search_btbtn);
            this.Controls.Add(this.Input_name_bmtb);
            this.Controls.Add(this.Student_bcdgv);
            this.Controls.Add(this.Select_subject_bdd);
            this.Controls.Add(this.panel1);
            this.Name = "Add_Subject_To_Students";
            this.Size = new System.Drawing.Size(834, 534);
            this.Load += new System.EventHandler(this.Add_Subject_To_Students_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Student_bcdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDropdown Select_subject_bdd;
        private Bunifu.Framework.UI.BunifuCustomDataGrid Student_bcdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail_col;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Input_name_bmtb;
        private Bunifu.Framework.UI.BunifuThinButton2 Search_btbtn;
        private Bunifu.Framework.UI.BunifuCustomLabel Select_student_bclvl;
        private Bunifu.Framework.UI.BunifuCustomLabel Select_section_bclvl;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel Name_blvl;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel ID_blvl;
        private Bunifu.Framework.UI.BunifuThinButton2 Assign_btbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 Cancel_btbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 Refresh_btbtn;
        private Bunifu.Framework.UI.BunifuDropdown Select_id_bdd;
    }
}
