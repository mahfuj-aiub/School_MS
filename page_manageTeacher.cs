using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Officer
{
    public partial class page_manageTeacher : UserControl
    {
        public page_manageTeacher()
        {
            InitializeComponent();
        }

        private void page_manageTeacher_Load(object sender, EventArgs e)
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
                DataTable dt = Database.Data(query);
                Teacher_bcdgb.AutoGenerateColumns = false;
                Teacher_bcdgb.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Excute_Query("IF OBJECT_ID('dbo.Test', 'V') IS NOT NULL  DROP VIEW dbo.Test");
                Database.Excute_Query(@" CREATE VIEW dbo.Test AS select teacher_id,first_name+' '+last_name as name,phone,email,address,dob 
                                                   from Teacher,Name where Teacher.name_id=Name.name_id;");
                DataTable dt = Database.Data("Select * from dbo.Test where name like '%" + txtboxName.Text + "%'");
                Teacher_bcdgb.AutoGenerateColumns = false;
                Teacher_bcdgb.DataSource = dt;
                txtboxName.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Teacher_bcdgb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_olvl.Text = Teacher_bcdgb.CurrentRow.Cells[0].Value.ToString();
            string query = "select first_name+' '+last_name as name from Teacher,Name where Teacher.name_id=Name.name_id and teacher_id ='" + ID_olvl.Text + "'";
            try
            {
                DataTable dt = Database.Data(query);
                Name_olvl.Text = dt.Rows[0]["name"].ToString();
              


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_btbtn_Click(object sender, EventArgs e)
        {
            string q = "select l_id from Log_In_Id where teacher_id='" + ID_olvl.Text + "'";
            try
            {
                DataTable dt = Database.Data(q);
                int l_id = Convert.ToInt32(dt.Rows[0]["l_id"].ToString());
                Database.Excute_Query("delete from Log_In where l_id = " + l_id);
                Database.Excute_Query("delete from Log_In_Id where teacher_id='" + ID_olvl.Text + "'");
                dt = Database.Data("select name_id from Teacher where teacher_id = '" + ID_olvl.Text + "'");
                l_id = Convert.ToInt32(dt.Rows[0]["name_id"].ToString());
                Database.Excute_Query("delete from Teacher where teacher_id = '" + ID_olvl.Text + "'");
                Database.Excute_Query("delete from Name where name_id = " + l_id);
                MessageBox.Show(Name_olvl.Text + " Removed");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Name_olvl.Text = ID_olvl.Text = "";
                this.Load_Data_To_Grid();
            }
        }

    }
    
}
