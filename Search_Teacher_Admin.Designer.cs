namespace School_MS
{
    partial class Search_Teacher_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Teacher_Admin));
            this.Teacher_bcdgb = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search_name_bmtb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Search_btbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Refresh_btbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Teacher_name_bclvl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Teacher_id_blvl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Teacher_mail_blvl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Name_blvl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ID_blvl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Email_blvl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Delete_btbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.Teacher_bcdgb)).BeginInit();
            this.SuspendLayout();
            // 
            // Teacher_bcdgb
            // 
            this.Teacher_bcdgb.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Teacher_bcdgb.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Teacher_bcdgb.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Teacher_bcdgb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Teacher_bcdgb.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Teacher_bcdgb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Teacher_bcdgb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Teacher_bcdgb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_col,
            this.name_col,
            this.Phone_col,
            this.mail_col,
            this.dob_col,
            this.Address_col});
            this.Teacher_bcdgb.DoubleBuffered = true;
            this.Teacher_bcdgb.EnableHeadersVisualStyles = false;
            this.Teacher_bcdgb.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Teacher_bcdgb.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Teacher_bcdgb.Location = new System.Drawing.Point(0, 270);
            this.Teacher_bcdgb.Name = "Teacher_bcdgb";
            this.Teacher_bcdgb.ReadOnly = true;
            this.Teacher_bcdgb.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Teacher_bcdgb.Size = new System.Drawing.Size(834, 264);
            this.Teacher_bcdgb.TabIndex = 1;
            this.Teacher_bcdgb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Teacher_bcdgb_CellContentClick);
            // 
            // id_col
            // 
            this.id_col.DataPropertyName = "teacher_id";
            this.id_col.HeaderText = "Teacher ID";
            this.id_col.Name = "id_col";
            this.id_col.ReadOnly = true;
            // 
            // name_col
            // 
            this.name_col.DataPropertyName = "name";
            this.name_col.HeaderText = "Name";
            this.name_col.Name = "name_col";
            this.name_col.ReadOnly = true;
            this.name_col.Width = 150;
            // 
            // Phone_col
            // 
            this.Phone_col.DataPropertyName = "phone";
            this.Phone_col.HeaderText = "Phone";
            this.Phone_col.Name = "Phone_col";
            this.Phone_col.ReadOnly = true;
            this.Phone_col.Width = 120;
            // 
            // mail_col
            // 
            this.mail_col.DataPropertyName = "email";
            this.mail_col.HeaderText = "Email";
            this.mail_col.Name = "mail_col";
            this.mail_col.ReadOnly = true;
            this.mail_col.Width = 170;
            // 
            // dob_col
            // 
            this.dob_col.DataPropertyName = "dob";
            this.dob_col.HeaderText = "Date Of Birth";
            this.dob_col.Name = "dob_col";
            this.dob_col.ReadOnly = true;
            this.dob_col.Width = 130;
            // 
            // Address_col
            // 
            this.Address_col.DataPropertyName = "address";
            this.Address_col.HeaderText = "Address";
            this.Address_col.Name = "Address_col";
            this.Address_col.ReadOnly = true;
            this.Address_col.Width = 200;
            // 
            // Search_name_bmtb
            // 
            this.Search_name_bmtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_name_bmtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Search_name_bmtb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_name_bmtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.Search_name_bmtb.HintForeColor = System.Drawing.Color.Empty;
            this.Search_name_bmtb.HintText = "Insert Name";
            this.Search_name_bmtb.isPassword = false;
            this.Search_name_bmtb.LineFocusedColor = System.Drawing.Color.Transparent;
            this.Search_name_bmtb.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Search_name_bmtb.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.Search_name_bmtb.LineThickness = 3;
            this.Search_name_bmtb.Location = new System.Drawing.Point(4, 5);
            this.Search_name_bmtb.Margin = new System.Windows.Forms.Padding(4);
            this.Search_name_bmtb.Name = "Search_name_bmtb";
            this.Search_name_bmtb.Size = new System.Drawing.Size(211, 33);
            this.Search_name_bmtb.TabIndex = 103;
            this.Search_name_bmtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Search_btbtn.Location = new System.Drawing.Point(224, 5);
            this.Search_btbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Search_btbtn.Name = "Search_btbtn";
            this.Search_btbtn.Size = new System.Drawing.Size(81, 35);
            this.Search_btbtn.TabIndex = 121;
            this.Search_btbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Search_btbtn.Click += new System.EventHandler(this.Search_btbtn_Click);
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
            this.Refresh_btbtn.Location = new System.Drawing.Point(325, 5);
            this.Refresh_btbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Refresh_btbtn.Name = "Refresh_btbtn";
            this.Refresh_btbtn.Size = new System.Drawing.Size(81, 35);
            this.Refresh_btbtn.TabIndex = 123;
            this.Refresh_btbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Refresh_btbtn.Click += new System.EventHandler(this.Refresh_btbtn_Click);
            // 
            // Teacher_name_bclvl
            // 
            this.Teacher_name_bclvl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Teacher_name_bclvl.AutoSize = true;
            this.Teacher_name_bclvl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_name_bclvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.Teacher_name_bclvl.Location = new System.Drawing.Point(233, 110);
            this.Teacher_name_bclvl.Name = "Teacher_name_bclvl";
            this.Teacher_name_bclvl.Size = new System.Drawing.Size(101, 17);
            this.Teacher_name_bclvl.TabIndex = 124;
            this.Teacher_name_bclvl.Text = "Teacher Name :";
            // 
            // Teacher_id_blvl
            // 
            this.Teacher_id_blvl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Teacher_id_blvl.AutoSize = true;
            this.Teacher_id_blvl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_id_blvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.Teacher_id_blvl.Location = new System.Drawing.Point(236, 160);
            this.Teacher_id_blvl.Name = "Teacher_id_blvl";
            this.Teacher_id_blvl.Size = new System.Drawing.Size(98, 17);
            this.Teacher_id_blvl.TabIndex = 125;
            this.Teacher_id_blvl.Text = "Teacher ID      :";
            // 
            // Teacher_mail_blvl
            // 
            this.Teacher_mail_blvl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Teacher_mail_blvl.AutoSize = true;
            this.Teacher_mail_blvl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_mail_blvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.Teacher_mail_blvl.Location = new System.Drawing.Point(237, 210);
            this.Teacher_mail_blvl.Name = "Teacher_mail_blvl";
            this.Teacher_mail_blvl.Size = new System.Drawing.Size(97, 17);
            this.Teacher_mail_blvl.TabIndex = 126;
            this.Teacher_mail_blvl.Text = "Teacher Email :";
            // 
            // Name_blvl
            // 
            this.Name_blvl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Name_blvl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_blvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Name_blvl.Location = new System.Drawing.Point(350, 101);
            this.Name_blvl.Name = "Name_blvl";
            this.Name_blvl.Size = new System.Drawing.Size(306, 35);
            this.Name_blvl.TabIndex = 127;
            this.Name_blvl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ID_blvl
            // 
            this.ID_blvl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ID_blvl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_blvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.ID_blvl.Location = new System.Drawing.Point(350, 151);
            this.ID_blvl.Name = "ID_blvl";
            this.ID_blvl.Size = new System.Drawing.Size(306, 35);
            this.ID_blvl.TabIndex = 128;
            this.ID_blvl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Email_blvl
            // 
            this.Email_blvl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Email_blvl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_blvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Email_blvl.Location = new System.Drawing.Point(350, 201);
            this.Email_blvl.Name = "Email_blvl";
            this.Email_blvl.Size = new System.Drawing.Size(306, 35);
            this.Email_blvl.TabIndex = 129;
            this.Email_blvl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Delete_btbtn
            // 
            this.Delete_btbtn.ActiveBorderThickness = 1;
            this.Delete_btbtn.ActiveCornerRadius = 20;
            this.Delete_btbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(159)))));
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
            this.Delete_btbtn.Location = new System.Drawing.Point(427, 5);
            this.Delete_btbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Delete_btbtn.Name = "Delete_btbtn";
            this.Delete_btbtn.Size = new System.Drawing.Size(81, 35);
            this.Delete_btbtn.TabIndex = 130;
            this.Delete_btbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Delete_btbtn.Click += new System.EventHandler(this.Delete_btbtn_Click);
            // 
            // Search_Teacher_Admin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(194)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.Delete_btbtn);
            this.Controls.Add(this.Email_blvl);
            this.Controls.Add(this.ID_blvl);
            this.Controls.Add(this.Name_blvl);
            this.Controls.Add(this.Teacher_mail_blvl);
            this.Controls.Add(this.Teacher_id_blvl);
            this.Controls.Add(this.Teacher_name_bclvl);
            this.Controls.Add(this.Refresh_btbtn);
            this.Controls.Add(this.Search_btbtn);
            this.Controls.Add(this.Search_name_bmtb);
            this.Controls.Add(this.Teacher_bcdgb);
            this.Name = "Search_Teacher_Admin";
            this.Size = new System.Drawing.Size(834, 534);
            this.Load += new System.EventHandler(this.Search_Teacher_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Teacher_bcdgb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid Teacher_bcdgb;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_col;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Search_name_bmtb;
        private Bunifu.Framework.UI.BunifuThinButton2 Search_btbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 Refresh_btbtn;
        private Bunifu.Framework.UI.BunifuCustomLabel Teacher_name_bclvl;
        private Bunifu.Framework.UI.BunifuCustomLabel Teacher_id_blvl;
        private Bunifu.Framework.UI.BunifuCustomLabel Teacher_mail_blvl;
        private Bunifu.Framework.UI.BunifuCustomLabel Name_blvl;
        private Bunifu.Framework.UI.BunifuCustomLabel ID_blvl;
        private Bunifu.Framework.UI.BunifuCustomLabel Email_blvl;
        private Bunifu.Framework.UI.BunifuThinButton2 Delete_btbtn;
    }
}
