namespace School_MS
{
    partial class Search_Officer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Officer));
            this.Officers_bclvl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Officer_bdgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search_name_bmtb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Search_btbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Officer_name_bclvl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Officer_id_blvl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Name_blvl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ID_blvl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.Officer_bdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Officers_bclvl
            // 
            this.Officers_bclvl.AutoSize = true;
            this.Officers_bclvl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Officers_bclvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Officers_bclvl.Location = new System.Drawing.Point(381, 0);
            this.Officers_bclvl.Name = "Officers_bclvl";
            this.Officers_bclvl.Size = new System.Drawing.Size(115, 32);
            this.Officers_bclvl.TabIndex = 2;
            this.Officers_bclvl.Text = "Officers";
            // 
            // Officer_bdgv
            // 
            this.Officer_bdgv.AllowUserToAddRows = false;
            this.Officer_bdgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Officer_bdgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Officer_bdgv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Officer_bdgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Officer_bdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Officer_bdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Officer_bdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Officer_bdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_col,
            this.name_col});
            this.Officer_bdgv.DoubleBuffered = true;
            this.Officer_bdgv.EnableHeadersVisualStyles = false;
            this.Officer_bdgv.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Officer_bdgv.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Officer_bdgv.Location = new System.Drawing.Point(241, 142);
            this.Officer_bdgv.Name = "Officer_bdgv";
            this.Officer_bdgv.ReadOnly = true;
            this.Officer_bdgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Officer_bdgv.Size = new System.Drawing.Size(339, 297);
            this.Officer_bdgv.TabIndex = 3;
            this.Officer_bdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Officer_bdgv_CellContentClick);
            // 
            // id_col
            // 
            this.id_col.DataPropertyName = "admin_id";
            this.id_col.HeaderText = "Admin ID";
            this.id_col.Name = "id_col";
            this.id_col.ReadOnly = true;
            this.id_col.Width = 150;
            // 
            // name_col
            // 
            this.name_col.DataPropertyName = "name";
            this.name_col.HeaderText = "Name";
            this.name_col.Name = "name_col";
            this.name_col.ReadOnly = true;
            this.name_col.Width = 150;
            // 
            // Search_name_bmtb
            // 
            this.Search_name_bmtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_name_bmtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Search_name_bmtb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_name_bmtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.Search_name_bmtb.HintForeColor = System.Drawing.Color.Empty;
            this.Search_name_bmtb.HintText = "Insert Name";
            this.Search_name_bmtb.isPassword = false;
            this.Search_name_bmtb.LineFocusedColor = System.Drawing.Color.Transparent;
            this.Search_name_bmtb.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Search_name_bmtb.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.Search_name_bmtb.LineThickness = 2;
            this.Search_name_bmtb.Location = new System.Drawing.Point(524, 28);
            this.Search_name_bmtb.Margin = new System.Windows.Forms.Padding(4);
            this.Search_name_bmtb.Name = "Search_name_bmtb";
            this.Search_name_bmtb.Size = new System.Drawing.Size(211, 34);
            this.Search_name_bmtb.TabIndex = 102;
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
            this.Search_btbtn.Location = new System.Drawing.Point(740, 28);
            this.Search_btbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Search_btbtn.Name = "Search_btbtn";
            this.Search_btbtn.Size = new System.Drawing.Size(87, 36);
            this.Search_btbtn.TabIndex = 120;
            this.Search_btbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Search_btbtn.Click += new System.EventHandler(this.Search_btbtn_Click);
            this.Search_btbtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Search_btbtn_MouseClick);
            // 
            // Officer_name_bclvl
            // 
            this.Officer_name_bclvl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Officer_name_bclvl.AutoSize = true;
            this.Officer_name_bclvl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Officer_name_bclvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.Officer_name_bclvl.Location = new System.Drawing.Point(11, 47);
            this.Officer_name_bclvl.Name = "Officer_name_bclvl";
            this.Officer_name_bclvl.Size = new System.Drawing.Size(94, 17);
            this.Officer_name_bclvl.TabIndex = 121;
            this.Officer_name_bclvl.Text = "Officer Name :";
            // 
            // Officer_id_blvl
            // 
            this.Officer_id_blvl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Officer_id_blvl.AutoSize = true;
            this.Officer_id_blvl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Officer_id_blvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.Officer_id_blvl.Location = new System.Drawing.Point(14, 97);
            this.Officer_id_blvl.Name = "Officer_id_blvl";
            this.Officer_id_blvl.Size = new System.Drawing.Size(91, 17);
            this.Officer_id_blvl.TabIndex = 122;
            this.Officer_id_blvl.Text = "Officer ID      :";
            // 
            // Name_blvl
            // 
            this.Name_blvl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Name_blvl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_blvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Name_blvl.Location = new System.Drawing.Point(136, 38);
            this.Name_blvl.Name = "Name_blvl";
            this.Name_blvl.Size = new System.Drawing.Size(196, 35);
            this.Name_blvl.TabIndex = 123;
            this.Name_blvl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ID_blvl
            // 
            this.ID_blvl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ID_blvl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_blvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.ID_blvl.Location = new System.Drawing.Point(136, 88);
            this.ID_blvl.Name = "ID_blvl";
            this.ID_blvl.Size = new System.Drawing.Size(196, 34);
            this.ID_blvl.TabIndex = 124;
            this.ID_blvl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(159)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(194)))), ((int)(((byte)(200)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Delete";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.Location = new System.Drawing.Point(285, 466);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(91, 51);
            this.bunifuThinButton21.TabIndex = 125;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(159)))));
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(194)))), ((int)(((byte)(200)))));
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Refresh";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.Location = new System.Drawing.Point(441, 466);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(85, 51);
            this.bunifuThinButton22.TabIndex = 126;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // Search_Officer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(194)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.ID_blvl);
            this.Controls.Add(this.Name_blvl);
            this.Controls.Add(this.Officer_id_blvl);
            this.Controls.Add(this.Officer_name_bclvl);
            this.Controls.Add(this.Search_btbtn);
            this.Controls.Add(this.Search_name_bmtb);
            this.Controls.Add(this.Officer_bdgv);
            this.Controls.Add(this.Officers_bclvl);
            this.Name = "Search_Officer";
            this.Size = new System.Drawing.Size(834, 534);
            this.Load += new System.EventHandler(this.Search_Officer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Officer_bdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel Officers_bclvl;
        private Bunifu.Framework.UI.BunifuCustomDataGrid Officer_bdgv;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Search_name_bmtb;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_col;
        private Bunifu.Framework.UI.BunifuThinButton2 Search_btbtn;
        private Bunifu.Framework.UI.BunifuCustomLabel Officer_name_bclvl;
        private Bunifu.Framework.UI.BunifuCustomLabel Officer_id_blvl;
        private Bunifu.Framework.UI.BunifuCustomLabel Name_blvl;
        private Bunifu.Framework.UI.BunifuCustomLabel ID_blvl;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
    }
}
