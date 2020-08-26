namespace Student_Officer
{
    partial class page_result
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblresult = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Student_bcdgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Sub_name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.res_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Student_bcdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(47)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.lblresult);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 64);
            this.panel1.TabIndex = 0;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.ForeColor = System.Drawing.Color.White;
            this.lblresult.Location = new System.Drawing.Point(22, 14);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(70, 30);
            this.lblresult.TabIndex = 0;
            this.lblresult.Text = "Result";
            // 
            // Student_bcdgv
            // 
            this.Student_bcdgv.AllowUserToAddRows = false;
            this.Student_bcdgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Student_bcdgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Student_bcdgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Student_bcdgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(90)))), ((int)(((byte)(218)))));
            this.Student_bcdgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Student_bcdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Student_bcdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Student_bcdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Student_bcdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sub_name_col,
            this.res_col});
            this.Student_bcdgv.DoubleBuffered = true;
            this.Student_bcdgv.EnableHeadersVisualStyles = false;
            this.Student_bcdgv.HeaderBgColor = System.Drawing.Color.Gainsboro;
            this.Student_bcdgv.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(58)))));
            this.Student_bcdgv.Location = new System.Drawing.Point(184, 99);
            this.Student_bcdgv.Name = "Student_bcdgv";
            this.Student_bcdgv.ReadOnly = true;
            this.Student_bcdgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Student_bcdgv.Size = new System.Drawing.Size(441, 594);
            this.Student_bcdgv.TabIndex = 51;
            // 
            // Sub_name_col
            // 
            this.Sub_name_col.DataPropertyName = "sub_name";
            this.Sub_name_col.HeaderText = "Subject Name";
            this.Sub_name_col.Name = "Sub_name_col";
            this.Sub_name_col.ReadOnly = true;
            this.Sub_name_col.Width = 250;
            // 
            // res_col
            // 
            this.res_col.DataPropertyName = "result";
            this.res_col.HeaderText = "Grade";
            this.res_col.Name = "res_col";
            this.res_col.ReadOnly = true;
            this.res_col.Width = 150;
            // 
            // page_result
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(81)))), ((int)(((byte)(136)))));
            this.Controls.Add(this.Student_bcdgv);
            this.Controls.Add(this.panel1);
            this.Name = "page_result";
            this.Size = new System.Drawing.Size(813, 804);
            this.Load += new System.EventHandler(this.page_result_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Student_bcdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblresult;
        private Bunifu.Framework.UI.BunifuCustomDataGrid Student_bcdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub_name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn res_col;
    }
}
