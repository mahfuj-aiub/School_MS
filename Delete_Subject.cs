using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_MS
{
    public partial class Delete_Subject : UserControl
    {
        public Delete_Subject()
        {
            InitializeComponent();
        }

        private void Delete_Subject_Load(object sender, EventArgs e)
        {
            this.Intialization();
        }
        private void Intialization()
        {
            this.Load_Data_To_Grid();
        }
        private void Load_Data_To_Grid()
        {
            try
            {
                string query = "select sub_id,sub_name,[time],[day] from Subject,Time_Table where Subject.time_id=Time_Table.time_id;";
                DataTable dt = Data_Access.Data(query);
                Subject_bcdgb.AutoGenerateColumns = false;
                Subject_bcdgb.DataSource = dt;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Search_btbtn_Click(object sender, EventArgs e)
        {
            string query = "select sub_id,sub_name,[time],[day] from Subject,Time_Table where Subject.time_id=Time_Table.time_id and sub_name like '%"+Search_bmtb.Text+"%'";
            try
            {
                DataTable dt = Data_Access.Data(query);
                Subject_bcdgb.AutoGenerateColumns = false;
                Subject_bcdgb.DataSource = dt;
                Search_bmtb.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Delete_btbtn_Click(object sender, EventArgs e)
        {
            string q = "delete from Subject where sub_id="+Subject_id_bmtb.Text;
            Data_Access.Delete_Data(q);
            Subject_id_bmtb.Text = Subject_name_bmtb.Text = Search_bmtb.Text = "";
            this.Load_Data_To_Grid();

        }

        private void Subject_bcdgb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Subject_id_bmtb.Text= Subject_bcdgb.CurrentRow.Cells[0].Value.ToString(); 
            string query = "select sub_name from Subject where sub_id="+ Subject_id_bmtb.Text;
            try
            {
                DataTable dt = Data_Access.Data(query);
                Subject_name_bmtb.Text = dt.Rows[0]["sub_name"].ToString();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Refresh_btbtn_Click(object sender, EventArgs e)
        {
            Subject_id_bmtb.Text = Subject_name_bmtb.Text = Search_bmtb.Text = "";
            this.Load_Data_To_Grid();
        }
    }
}
