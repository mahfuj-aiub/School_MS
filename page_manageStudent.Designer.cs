namespace Student_Officer
{
    partial class page_manageStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(page_manageStudent));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtboxName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.Search_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Refresh_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Student_bcdgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ID_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_name_lvl = new System.Windows.Forms.Label();
            this.Student_name_olvl = new System.Windows.Forms.Label();
            this.ID_lvl = new System.Windows.Forms.Label();
            this.ID_olvl = new System.Windows.Forms.Label();
            this.Delete_btbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.Student_bcdgv)).BeginInit();
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
            this.txtboxName.Location = new System.Drawing.Point(131, 33);
            this.txtboxName.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(324, 29);
            this.txtboxName.TabIndex = 17;
            this.txtboxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name :";
            // 
            // Search_btn
            // 
            this.Search_btn.ActiveBorderThickness = 1;
            this.Search_btn.ActiveCornerRadius = 15;
            this.Search_btn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.Search_btn.ActiveForecolor = System.Drawing.Color.Transparent;
            this.Search_btn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.Search_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(163)))), ((int)(((byte)(178)))));
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
            this.Search_btn.Location = new System.Drawing.Point(131, 89);
            this.Search_btn.Margin = new System.Windows.Forms.Padding(5);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(152, 55);
            this.Search_btn.TabIndex = 20;
            this.Search_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.ActiveBorderThickness = 1;
            this.Refresh_btn.ActiveCornerRadius = 15;
            this.Refresh_btn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.Refresh_btn.ActiveForecolor = System.Drawing.Color.Transparent;
            this.Refresh_btn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.Refresh_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Refresh_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(163)))), ((int)(((byte)(178)))));
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
            this.Refresh_btn.Location = new System.Drawing.Point(303, 89);
            this.Refresh_btn.Margin = new System.Windows.Forms.Padding(5);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(152, 55);
            this.Refresh_btn.TabIndex = 21;
            this.Refresh_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // Student_bcdgv
            // 
            this.Student_bcdgv.AllowUserToAddRows = false;
            this.Student_bcdgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Student_bcdgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Student_bcdgv.BackgroundColor = System.Drawing.Color.White;
            this.Student_bcdgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Student_bcdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Student_bcdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Student_bcdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Student_bcdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_col,
            this.Name_col,
            this.P_name_col,
            this.phone_col,
            this.mail_col,
            this.dob_col,
            this.add_col});
            this.Student_bcdgv.DoubleBuffered = true;
            this.Student_bcdgv.EnableHeadersVisualStyles = false;
            this.Student_bcdgv.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Student_bcdgv.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Student_bcdgv.Location = new System.Drawing.Point(0, 262);
            this.Student_bcdgv.Name = "Student_bcdgv";
            this.Student_bcdgv.ReadOnly = true;
            this.Student_bcdgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Student_bcdgv.Size = new System.Drawing.Size(1110, 401);
            this.Student_bcdgv.TabIndex = 22;
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
            this.Name_col.Width = 200;
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
            this.dob_col.Width = 150;
            // 
            // add_col
            // 
            this.add_col.DataPropertyName = "address";
            this.add_col.HeaderText = "Address";
            this.add_col.Name = "add_col";
            this.add_col.ReadOnly = true;
            this.add_col.Width = 200;
            // 
            // Student_name_lvl
            // 
            this.Student_name_lvl.AutoSize = true;
            this.Student_name_lvl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_name_lvl.ForeColor = System.Drawing.Color.White;
            this.Student_name_lvl.Location = new System.Drawing.Point(24, 224);
            this.Student_name_lvl.Name = "Student_name_lvl";
            this.Student_name_lvl.Size = new System.Drawing.Size(123, 21);
            this.Student_name_lvl.TabIndex = 23;
            this.Student_name_lvl.Text = "Student Name :";
            // 
            // Student_name_olvl
            // 
            this.Student_name_olvl.AutoSize = true;
            this.Student_name_olvl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_name_olvl.ForeColor = System.Drawing.Color.White;
            this.Student_name_olvl.Location = new System.Drawing.Point(160, 224);
            this.Student_name_olvl.Name = "Student_name_olvl";
            this.Student_name_olvl.Size = new System.Drawing.Size(0, 21);
            this.Student_name_olvl.TabIndex = 24;
            // 
            // ID_lvl
            // 
            this.ID_lvl.AutoSize = true;
            this.ID_lvl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_lvl.ForeColor = System.Drawing.Color.White;
            this.ID_lvl.Location = new System.Drawing.Point(392, 224);
            this.ID_lvl.Name = "ID_lvl";
            this.ID_lvl.Size = new System.Drawing.Size(96, 21);
            this.ID_lvl.TabIndex = 25;
            this.ID_lvl.Text = "Student ID :";
            // 
            // ID_olvl
            // 
            this.ID_olvl.AutoSize = true;
            this.ID_olvl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_olvl.ForeColor = System.Drawing.Color.White;
            this.ID_olvl.Location = new System.Drawing.Point(521, 224);
            this.ID_olvl.Name = "ID_olvl";
            this.ID_olvl.Size = new System.Drawing.Size(0, 21);
            this.ID_olvl.TabIndex = 26;
            // 
            // Delete_btbtn
            // 
            this.Delete_btbtn.ActiveBorderThickness = 1;
            this.Delete_btbtn.ActiveCornerRadius = 15;
            this.Delete_btbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.Delete_btbtn.ActiveForecolor = System.Drawing.Color.Transparent;
            this.Delete_btbtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.Delete_btbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Delete_btbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(163)))), ((int)(((byte)(178)))));
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
            this.Delete_btbtn.Location = new System.Drawing.Point(865, 199);
            this.Delete_btbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Delete_btbtn.Name = "Delete_btbtn";
            this.Delete_btbtn.Size = new System.Drawing.Size(152, 55);
            this.Delete_btbtn.TabIndex = 27;
            this.Delete_btbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Delete_btbtn.Click += new System.EventHandler(this.Delete_btbtn_Click);
            // 
            // page_manageStudent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(163)))), ((int)(((byte)(178)))));
            this.Controls.Add(this.Delete_btbtn);
            this.Controls.Add(this.ID_olvl);
            this.Controls.Add(this.ID_lvl);
            this.Controls.Add(this.Student_name_olvl);
            this.Controls.Add(this.Student_name_lvl);
            this.Controls.Add(this.Student_bcdgv);
            this.Controls.Add(this.Refresh_btn);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.label1);
            this.Name = "page_manageStudent";
            this.Size = new System.Drawing.Size(1129, 688);
            this.Load += new System.EventHandler(this.page_manageStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Student_bcdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMetroTextbox txtboxName;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 Search_btn;
        private Bunifu.Framework.UI.BunifuThinButton2 Refresh_btn;
        private Bunifu.Framework.UI.BunifuCustomDataGrid Student_bcdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn add_col;
        private System.Windows.Forms.Label Student_name_lvl;
        private System.Windows.Forms.Label Student_name_olvl;
        private System.Windows.Forms.Label ID_lvl;
        private System.Windows.Forms.Label ID_olvl;
        private Bunifu.Framework.UI.BunifuThinButton2 Delete_btbtn;
    }
}
