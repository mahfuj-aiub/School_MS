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
    public partial class Search_Teacher_Admin : UserControl
    {
        public Search_Teacher_Admin()
        {
            InitializeComponent();
        }

        private void Search_Teacher_Admin_Load(object sender, EventArgs e)
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
                string query = "select teacher_id,first_name+' '+last_name as name,phone,email,address,dob from Teacher,Name where Teacher.name_id=Name.name_id;";
                DataTable dt = Data_Access.Data(query);
                Teacher_bcdgb.AutoGenerateColumns = false;
                Teacher_bcdgb.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Search_btbtn_Click(object sender, EventArgs e)
        {
                                      
            try
            {
                Data_Access.Delete_Data("IF OBJECT_ID('dbo.Test', 'V') IS NOT NULL  DROP VIEW dbo.Test");
                Data_Access.Delete_Data(@" CREATE VIEW dbo.Test AS select teacher_id,first_name+' '+last_name as name,phone,email,address,dob 
                                                   from Teacher,Name where Teacher.name_id=Name.name_id;");
                DataTable dt = Data_Access.Data("Select * from dbo.Test where name like '%" + Search_name_bmtb.Text + "%'");
                Teacher_bcdgb.AutoGenerateColumns = false;
                Teacher_bcdgb.DataSource = dt;
                Search_name_bmtb.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Refresh_btbtn_Click(object sender, EventArgs e)
        {
            Search_name_bmtb.Text =Name_blvl.Text=ID_blvl.Text=Email_blvl.Text= "";

            this.Load_Data_To_Grid();
        }

        private void Teacher_bcdgb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_blvl.Text = Teacher_bcdgb.CurrentRow.Cells[0].Value.ToString();
            string query = "select first_name+' '+last_name as name ,email from Teacher,Name where Teacher.name_id=Name.name_id and teacher_id ='" + ID_blvl.Text + "'";
            try
            {
                DataTable dt = Data_Access.Data(query);
                Name_blvl.Text = dt.Rows[0]["name"].ToString();
                Email_blvl.Text = dt.Rows[0]["email"].ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_btbtn_Click(object sender, EventArgs e)
        {
            string q = "select l_id from Log_In_Id where teacher_id='" + ID_blvl.Text + "'";
            try
            {
                DataTable dt = Data_Access.Data(q);
                int l_id = Convert.ToInt32(dt.Rows[0]["l_id"].ToString());
                Data_Access.Delete_Data("delete from Log_In where l_id = " + l_id);
                Data_Access.Delete_Data("delete from Log_In_Id where teacher_id='" + ID_blvl.Text + "'");
                dt = Data_Access.Data("select name_id from Teacher where teacher_id = '" + ID_blvl.Text + "'");
                l_id = Convert.ToInt32(dt.Rows[0]["name_id"].ToString());
                Data_Access.Delete_Data("delete from Teacher where teacher_id = '" + ID_blvl.Text + "'");
                Data_Access.Delete_Data("delete from Name where name_id = " + l_id);
                MessageBox.Show(Name_blvl.Text+" Removed");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Search_name_bmtb.Text = Name_blvl.Text = ID_blvl.Text =Email_blvl.Text= "";
                this.Load_Data_To_Grid();
            }
        }
    }
}
