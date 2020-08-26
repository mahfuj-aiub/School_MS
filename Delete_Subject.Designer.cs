namespace School_MS
{
    partial class Delete_Subject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete_Subject));
            this.Subject_bcdgb = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Subject_id_bmtb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Subject_name_bmtb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Delete_btbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Refresh_btbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Search_bmtb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Search_btbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.Subject_bcdgb)).BeginInit();
            this.SuspendLayout();
            // 
            // Subject_bcdgb
            // 
            this.Subject_bcdgb.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Subject_bcdgb.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Subject_bcdgb.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Subject_bcdgb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Subject_bcdgb.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Subject_bcdgb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Subject_bcdgb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Subject_bcdgb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_col,
            this.name_col,
            this.time_col,
            this.day_col});
            this.Subject_bcdgb.DoubleBuffered = true;
            this.Subject_bcdgb.EnableHeadersVisualStyles = false;
            this.Subject_bcdgb.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Subject_bcdgb.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Subject_bcdgb.Location = new System.Drawing.Point(125, 244);
            this.Subject_bcdgb.Name = "Subject_bcdgb";
            this.Subject_bcdgb.ReadOnly = true;
            this.Subject_bcdgb.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Subject_bcdgb.Size = new System.Drawing.Size(639, 287);
            this.Subject_bcdgb.TabIndex = 0;
            this.Subject_bcdgb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Subject_bcdgb_CellContentClick);
            // 
            // id_col
            // 
            this.id_col.DataPropertyName = "sub_id";
            this.id_col.HeaderText = "Subject ID";
            this.id_col.Name = "id_col";
            this.id_col.ReadOnly = true;
            // 
            // name_col
            // 
            this.name_col.DataPropertyName = "sub_name";
            this.name_col.HeaderText = "Subject Name";
            this.name_col.Name = "name_col";
            this.name_col.ReadOnly = true;
            this.name_col.Width = 200;
            // 
            // time_col
            // 
            this.time_col.DataPropertyName = "time";
            this.time_col.HeaderText = "Time";
            this.time_col.Name = "time_col";
            this.time_col.ReadOnly = true;
            this.time_col.Width = 200;
            // 
            // day_col
            // 
            this.day_col.DataPropertyName = "day";
            this.day_col.HeaderText = "Day";
            this.day_col.Name = "day_col";
            this.day_col.ReadOnly = true;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(121, 41);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(144, 23);
            this.bunifuCustomLabel5.TabIndex = 103;
            this.bunifuCustomLabel5.Text = "Delete Subject";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(145, 127);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(76, 17);
            this.bunifuCustomLabel2.TabIndex = 106;
            this.bunifuCustomLabel2.Text = "Subject ID :";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(122, 180);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(99, 17);
            this.bunifuCustomLabel3.TabIndex = 107;
            this.bunifuCustomLabel3.Text = "Subject Name :";
            // 
            // Subject_id_bmtb
            // 
            this.Subject_id_bmtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Subject_id_bmtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Subject_id_bmtb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject_id_bmtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.Subject_id_bmtb.HintForeColor = System.Drawing.Color.Empty;
            this.Subject_id_bmtb.HintText = "";
            this.Subject_id_bmtb.isPassword = false;
            this.Subject_id_bmtb.LineFocusedColor = System.Drawing.Color.Transparent;
            this.Subject_id_bmtb.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Subject_id_bmtb.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.Subject_id_bmtb.LineThickness = 2;
            this.Subject_id_bmtb.Location = new System.Drawing.Point(243, 109);
            this.Subject_id_bmtb.Margin = new System.Windows.Forms.Padding(4);
            this.Subject_id_bmtb.Name = "Subject_id_bmtb";
            this.Subject_id_bmtb.Size = new System.Drawing.Size(262, 35);
            this.Subject_id_bmtb.TabIndex = 108;
            this.Subject_id_bmtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Subject_name_bmtb
            // 
            this.Subject_name_bmtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Subject_name_bmtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Subject_name_bmtb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject_name_bmtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.Subject_name_bmtb.HintForeColor = System.Drawing.Color.Empty;
            this.Subject_name_bmtb.HintText = "";
            this.Subject_name_bmtb.isPassword = false;
            this.Subject_name_bmtb.LineFocusedColor = System.Drawing.Color.Transparent;
            this.Subject_name_bmtb.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Subject_name_bmtb.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.Subject_name_bmtb.LineThickness = 2;
            this.Subject_name_bmtb.Location = new System.Drawing.Point(243, 162);
            this.Subject_name_bmtb.Margin = new System.Windows.Forms.Padding(4);
            this.Subject_name_bmtb.Name = "Subject_name_bmtb";
            this.Subject_name_bmtb.Size = new System.Drawing.Size(262, 35);
            this.Subject_name_bmtb.TabIndex = 109;
            this.Subject_name_bmtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.Delete_btbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(194)))), ((int)(((byte)(200)))));
            this.Delete_btbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete_btbtn.BackgroundImage")));
            this.Delete_btbtn.ButtonText = "Delete";
            this.Delete_btbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_btbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btbtn.ForeColor = System.Drawing.Color.White;
            this.Delete_btbtn.IdleBorderThickness = 1;
            this.Delete_btbtn.IdleCornerRadius = 20;
            this.Delete_btbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.Delete_btbtn.IdleForecolor = System.Drawing.Color.Transparent;
            this.Delete_btbtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.Delete_btbtn.Location = new System.Drawing.Point(542, 140);
            this.Delete_btbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Delete_btbtn.Name = "Delete_btbtn";
            this.Delete_btbtn.Size = new System.Drawing.Size(90, 43);
            this.Delete_btbtn.TabIndex = 117;
            this.Delete_btbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Delete_btbtn.Click += new System.EventHandler(this.Delete_btbtn_Click);
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
            this.Refresh_btbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_btbtn.ForeColor = System.Drawing.Color.White;
            this.Refresh_btbtn.IdleBorderThickness = 1;
            this.Refresh_btbtn.IdleCornerRadius = 20;
            this.Refresh_btbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.Refresh_btbtn.IdleForecolor = System.Drawing.Color.Transparent;
            this.Refresh_btbtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.Refresh_btbtn.Location = new System.Drawing.Point(657, 140);
            this.Refresh_btbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Refresh_btbtn.Name = "Refresh_btbtn";
            this.Refresh_btbtn.Size = new System.Drawing.Size(97, 43);
            this.Refresh_btbtn.TabIndex = 118;
            this.Refresh_btbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Refresh_btbtn.Click += new System.EventHandler(this.Refresh_btbtn_Click);
            // 
            // Search_bmtb
            // 
            this.Search_bmtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_bmtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Search_bmtb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_bmtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.Search_bmtb.HintForeColor = System.Drawing.Color.Empty;
            this.Search_bmtb.HintText = "Enter Subject Name";
            this.Search_bmtb.isPassword = false;
            this.Search_bmtb.LineFocusedColor = System.Drawing.Color.Transparent;
            this.Search_bmtb.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Search_bmtb.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.Search_bmtb.LineThickness = 2;
            this.Search_bmtb.Location = new System.Drawing.Point(542, 29);
            this.Search_bmtb.Margin = new System.Windows.Forms.Padding(4);
            this.Search_bmtb.Name = "Search_bmtb";
            this.Search_bmtb.Size = new System.Drawing.Size(222, 35);
            this.Search_bmtb.TabIndex = 119;
            this.Search_bmtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Search_btbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btbtn.ForeColor = System.Drawing.Color.White;
            this.Search_btbtn.IdleBorderThickness = 1;
            this.Search_btbtn.IdleCornerRadius = 20;
            this.Search_btbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.Search_btbtn.IdleForecolor = System.Drawing.Color.Transparent;
            this.Search_btbtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.Search_btbtn.Location = new System.Drawing.Point(773, 29);
            this.Search_btbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Search_btbtn.Name = "Search_btbtn";
            this.Search_btbtn.Size = new System.Drawing.Size(59, 35);
            this.Search_btbtn.TabIndex = 120;
            this.Search_btbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Search_btbtn.Click += new System.EventHandler(this.Search_btbtn_Click);
            // 
            // Delete_Subject
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(194)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.Search_btbtn);
            this.Controls.Add(this.Search_bmtb);
            this.Controls.Add(this.Refresh_btbtn);
            this.Controls.Add(this.Delete_btbtn);
            this.Controls.Add(this.Subject_name_bmtb);
            this.Controls.Add(this.Subject_id_bmtb);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.Subject_bcdgb);
            this.Name = "Delete_Subject";
            this.Size = new System.Drawing.Size(834, 534);
            this.Load += new System.EventHandler(this.Delete_Subject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Subject_bcdgb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid Subject_bcdgb;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn day_col;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Subject_id_bmtb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Subject_name_bmtb;
        private Bunifu.Framework.UI.BunifuThinButton2 Delete_btbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 Refresh_btbtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Search_bmtb;
        private Bunifu.Framework.UI.BunifuThinButton2 Search_btbtn;
    }
}
