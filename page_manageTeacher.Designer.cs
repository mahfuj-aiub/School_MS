namespace Student_Officer
{
    partial class page_manageTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(page_manageTeacher));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtboxName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.Refresh_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Search_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Teacher_bcdgb = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_name_lvl = new System.Windows.Forms.Label();
            this.Name_olvl = new System.Windows.Forms.Label();
            this.ID_lvl = new System.Windows.Forms.Label();
            this.ID_olvl = new System.Windows.Forms.Label();
            this.Delete_btbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.Teacher_bcdgb)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxName
            // 
            this.txtboxName.BorderColorFocused = System.Drawing.Color.White;
            this.txtboxName.BorderColorIdle = System.Drawing.Color.White;
            this.txtboxName.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtboxName.BorderThickness = 1;
            this.txtboxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxName.ForeColor = System.Drawing.Color.White;
            this.txtboxName.isPassword = false;
            this.txtboxName.Location = new System.Drawing.Point(117, 33);
            this.txtboxName.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(324, 29);
            this.txtboxName.TabIndex = 13;
            this.txtboxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name :";
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.ActiveBorderThickness = 1;
            this.Refresh_btn.ActiveCornerRadius = 15;
            this.Refresh_btn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.Refresh_btn.ActiveForecolor = System.Drawing.Color.Transparent;
            this.Refresh_btn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.Refresh_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Refresh_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(116)))), ((int)(((byte)(140)))));
            this.Refresh_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Refresh_btn.BackgroundImage")));
            this.Refresh_btn.ButtonText = "Refresh";
            this.Refresh_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refresh_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_btn.ForeColor = System.Drawing.Color.SeaGreen;
            this.Refresh_btn.IdleBorderThickness = 1;
            this.Refresh_btn.IdleCornerRadius = 15;
            this.Refresh_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(169)))));
            this.Refresh_btn.IdleForecolor = System.Drawing.Color.Transparent;
            this.Refresh_btn.IdleLineColor = System.Drawing.Color.Transparent;
            this.Refresh_btn.Location = new System.Drawing.Point(281, 71);
            this.Refresh_btn.Margin = new System.Windows.Forms.Padding(5);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(152, 55);
            this.Refresh_btn.TabIndex = 22;
            this.Refresh_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Search_btn
            // 
            this.Search_btn.ActiveBorderThickness = 1;
            this.Search_btn.ActiveCornerRadius = 15;
            this.Search_btn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.Search_btn.ActiveForecolor = System.Drawing.Color.Transparent;
            this.Search_btn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.Search_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(116)))), ((int)(((byte)(140)))));
            this.Search_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Search_btn.BackgroundImage")));
            this.Search_btn.ButtonText = "Search";
            this.Search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btn.ForeColor = System.Drawing.Color.SeaGreen;
            this.Search_btn.IdleBorderThickness = 1;
            this.Search_btn.IdleCornerRadius = 15;
            this.Search_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(169)))));
            this.Search_btn.IdleForecolor = System.Drawing.Color.Transparent;
            this.Search_btn.IdleLineColor = System.Drawing.Color.Transparent;
            this.Search_btn.Location = new System.Drawing.Point(117, 71);
            this.Search_btn.Margin = new System.Windows.Forms.Padding(5);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(144, 55);
            this.Search_btn.TabIndex = 23;
            this.Search_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
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
            this.Teacher_bcdgb.Location = new System.Drawing.Point(0, 318);
            this.Teacher_bcdgb.Name = "Teacher_bcdgb";
            this.Teacher_bcdgb.ReadOnly = true;
            this.Teacher_bcdgb.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Teacher_bcdgb.Size = new System.Drawing.Size(910, 378);
            this.Teacher_bcdgb.TabIndex = 24;
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
            // Student_name_lvl
            // 
            this.Student_name_lvl.AutoSize = true;
            this.Student_name_lvl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_name_lvl.ForeColor = System.Drawing.Color.White;
            this.Student_name_lvl.Location = new System.Drawing.Point(16, 279);
            this.Student_name_lvl.Name = "Student_name_lvl";
            this.Student_name_lvl.Size = new System.Drawing.Size(121, 21);
            this.Student_name_lvl.TabIndex = 25;
            this.Student_name_lvl.Text = "Teacher Name :";
            // 
            // Name_olvl
            // 
            this.Name_olvl.AutoSize = true;
            this.Name_olvl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_olvl.ForeColor = System.Drawing.Color.White;
            this.Name_olvl.Location = new System.Drawing.Point(138, 279);
            this.Name_olvl.Name = "Name_olvl";
            this.Name_olvl.Size = new System.Drawing.Size(14, 21);
            this.Name_olvl.TabIndex = 26;
            this.Name_olvl.Text = " ";
            // 
            // ID_lvl
            // 
            this.ID_lvl.AutoSize = true;
            this.ID_lvl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_lvl.ForeColor = System.Drawing.Color.White;
            this.ID_lvl.Location = new System.Drawing.Point(383, 279);
            this.ID_lvl.Name = "ID_lvl";
            this.ID_lvl.Size = new System.Drawing.Size(94, 21);
            this.ID_lvl.TabIndex = 27;
            this.ID_lvl.Text = "Teacher ID :";
            // 
            // ID_olvl
            // 
            this.ID_olvl.AutoSize = true;
            this.ID_olvl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_olvl.ForeColor = System.Drawing.Color.White;
            this.ID_olvl.Location = new System.Drawing.Point(512, 279);
            this.ID_olvl.Name = "ID_olvl";
            this.ID_olvl.Size = new System.Drawing.Size(0, 21);
            this.ID_olvl.TabIndex = 28;
            // 
            // Delete_btbtn
            // 
            this.Delete_btbtn.ActiveBorderThickness = 1;
            this.Delete_btbtn.ActiveCornerRadius = 15;
            this.Delete_btbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.Delete_btbtn.ActiveForecolor = System.Drawing.Color.Transparent;
            this.Delete_btbtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.Delete_btbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Delete_btbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(116)))), ((int)(((byte)(140)))));
            this.Delete_btbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete_btbtn.BackgroundImage")));
            this.Delete_btbtn.ButtonText = "Delete";
            this.Delete_btbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_btbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.Delete_btbtn.IdleBorderThickness = 1;
            this.Delete_btbtn.IdleCornerRadius = 15;
            this.Delete_btbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(169)))));
            this.Delete_btbtn.IdleForecolor = System.Drawing.Color.Transparent;
            this.Delete_btbtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.Delete_btbtn.Location = new System.Drawing.Point(767, 255);
            this.Delete_btbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Delete_btbtn.Name = "Delete_btbtn";
            this.Delete_btbtn.Size = new System.Drawing.Size(152, 55);
            this.Delete_btbtn.TabIndex = 29;
            this.Delete_btbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Delete_btbtn.Click += new System.EventHandler(this.Delete_btbtn_Click);
            // 
            // page_manageTeacher
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(116)))), ((int)(((byte)(140)))));
            this.Controls.Add(this.Delete_btbtn);
            this.Controls.Add(this.ID_olvl);
            this.Controls.Add(this.ID_lvl);
            this.Controls.Add(this.Name_olvl);
            this.Controls.Add(this.Student_name_lvl);
            this.Controls.Add(this.Teacher_bcdgb);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.Refresh_btn);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.label1);
            this.Name = "page_manageTeacher";
            this.Size = new System.Drawing.Size(1112, 688);
            this.Load += new System.EventHandler(this.page_manageTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Teacher_bcdgb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMetroTextbox txtboxName;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 Refresh_btn;
        private Bunifu.Framework.UI.BunifuThinButton2 Search_btn;
        private Bunifu.Framework.UI.BunifuCustomDataGrid Teacher_bcdgb;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_col;
        private System.Windows.Forms.Label Student_name_lvl;
        private System.Windows.Forms.Label Name_olvl;
        private System.Windows.Forms.Label ID_lvl;
        private System.Windows.Forms.Label ID_olvl;
        private Bunifu.Framework.UI.BunifuThinButton2 Delete_btbtn;
    }
}
