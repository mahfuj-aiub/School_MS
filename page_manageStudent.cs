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
    public partial class page_manageStudent : UserControl
    {
        public page_manageStudent()
        {
            InitializeComponent();
        }

        private void page_manageStudent_Load(object sender, EventArgs e)
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
                Database.Excute_Query("IF OBJECT_ID('dbo.S_Profile', 'V') IS NOT NULL  DROP VIEW dbo.S_Profile");
                Database.Excute_Query(@"create view S_Profile
                                               as
                                          select parent_id,first_name+' '+last_name as name
                                            from Parent,Name
                                            where Parent.name_id=Name.name_id; ");
                string query = @"select stu_id,first_name+' '+last_name as name,phone,S_Profile.name as parent_name,email,dob,address
                                  from dbo.S_Profile,Student,Name
                                 where Student.name_id=Name.name_id and Student.parent_id=dbo.S_Profile.parent_id;";
                DataTable dt = Database.Data(query);
                Student_bcdgv.AutoGenerateColumns = false;
                Student_bcdgv.DataSource = dt;

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
                Database.Excute_Query("IF OBJECT_ID('dbo.S_Profile', 'V') IS NOT NULL  DROP VIEW dbo.S_Profile");
                Database.Excute_Query(@"create view S_Profile
                                               as
                                          select parent_id,first_name+' '+last_name as name
                                            from Parent,Name
                                            where Parent.name_id=Name.name_id; ");
                Database.Excute_Query("IF OBJECT_ID('dbo.S_Search', 'V') IS NOT NULL  DROP VIEW dbo.S_Search;");
                Database.Excute_Query(@"create view S_Search as select stu_id,first_name+' '+last_name as name,phone,S_Profile.name as parent_name,email,dob,address
                                  from dbo.S_Profile,Student,Name
                                 where Student.name_id=Name.name_id and Student.parent_id=dbo.S_Profile.parent_id ;");
                string query = @"select * from S_Search
								 where name like '%" + txtboxName.Text + "%';";
                DataTable dt = Database.Data(query);
                Student_bcdgv.AutoGenerateColumns = false;
                Student_bcdgv.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtboxName.Text = "";
            }
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            this.Intialization();
            txtboxName.Text = "";
        }

        private void Student_bcdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_olvl.Text = Student_bcdgv.CurrentRow.Cells[0].Value.ToString();
            string q = @"select first_name+' '+last_name as name
                                  from Student,Name
                                 where Student.name_id=Name.name_id  and stu_id='" + ID_olvl.Text + "'";
            try
            {
                DataTable dt = Database.Data(q);
                
                    Student_name_olvl.Text = dt.Rows[0]["name"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Delete_btbtn_Click(object sender, EventArgs e)
        {
            string q = "select l_id from Log_In_Id where stu_id='" + ID_olvl.Text + "'";
            try
            {
                DataTable dt = Database.Data(q);
                int l_id = Convert.ToInt32(dt.Rows[0]["l_id"].ToString());
                Database.Excute_Query("delete from Log_In where l_id = " + l_id);
                Database.Excute_Query("delete from Log_In_Id where stu_id='" + ID_olvl.Text + "'");
                dt = Database.Data("select name_id,parent_id from Student where stu_id = '" + ID_olvl.Text + "'");
                l_id = Convert.ToInt32(dt.Rows[0]["name_id"].ToString());
                int p_id = Convert.ToInt32(dt.Rows[0]["parent_id"].ToString());
                Database.Excute_Query("delete from Student where stu_id = '" + ID_olvl.Text + "'");
                Database.Excute_Query("delete from Name where name_id = " + l_id);
                dt = Database.Data("select name_id from Parent where parent_id=" + p_id);
                l_id = Convert.ToInt32(dt.Rows[0]["name_id"].ToString());
                Database.Excute_Query("delete from Parent where parent_id = " + p_id);
                Database.Excute_Query("delete from Name where name_id = " + l_id);
                MessageBox.Show(Student_name_olvl.Text + " Removed");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
               Student_name_olvl.Text = ID_olvl.Text="";
                this.Load_Data_To_Grid();
            }
        }
    }
}
