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
    public partial class Search_Student_Admin : UserControl
    {
        public Search_Student_Admin()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Search_Student_Admin_Load(object sender, EventArgs e)
        {

            this.Intialization();
        }
        private void Intialization()
        {
            DataTable d = Data_Access.Data("Select count(*) as count from Student");
            Count_bclvl.Text = d.Rows[0]["count"].ToString();
            this.Load_Data_To_Grid();
        }
        private void Load_Data_To_Grid()
        {
            try
            {
                Data_Access.Delete_Data("IF OBJECT_ID('dbo.S_Profile', 'V') IS NOT NULL  DROP VIEW dbo.S_Profile");
                Data_Access.Delete_Data(@"create view S_Profile
                                               as
                                          select parent_id,first_name+' '+last_name as name
                                            from Parent,Name
                                            where Parent.name_id=Name.name_id; ");
                string query = @"select stu_id,first_name+' '+last_name as name,phone,S_Profile.name as parent_name,email,dob,address
                                  from dbo.S_Profile,Student,Name
                                 where Student.name_id=Name.name_id and Student.parent_id=dbo.S_Profile.parent_id;";
                DataTable dt = Data_Access.Data(query);
                Student_bcdgv.AutoGenerateColumns = false;
                Student_bcdgv.DataSource = dt;

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
                Data_Access.Delete_Data("IF OBJECT_ID('dbo.S_Profile', 'V') IS NOT NULL  DROP VIEW dbo.S_Profile");
                Data_Access.Delete_Data(@"create view S_Profile
                                               as
                                          select parent_id,first_name+' '+last_name as name
                                            from Parent,Name
                                            where Parent.name_id=Name.name_id; ");
                Data_Access.Delete_Data("IF OBJECT_ID('dbo.S_Search', 'V') IS NOT NULL  DROP VIEW dbo.S_Search;");
                Data_Access.Delete_Data(@"create view S_Search as select stu_id,first_name+' '+last_name as name,phone,S_Profile.name as parent_name,email,dob,address
                                  from dbo.S_Profile,Student,Name
                                 where Student.name_id=Name.name_id and Student.parent_id=dbo.S_Profile.parent_id ;");
                string query = @"select * from S_Search
								 where name like '%" + Input_name_bmtb.Text +"%';";
                DataTable dt = Data_Access.Data(query);
                Student_bcdgv.AutoGenerateColumns = false;
                Student_bcdgv.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Input_name_bmtb.Text = "";
            }
        }

        private void Student_bcdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_blvl.Text = Student_bcdgv.CurrentRow.Cells[0].Value.ToString();
            string q = @"select first_name+' '+last_name as name,S_Profile.name as parent_name,email
                                  from dbo.S_Profile,Student,Name
                                 where Student.name_id=Name.name_id and Student.parent_id=dbo.S_Profile.parent_id and stu_id='"+ID_blvl.Text+"'";
            try
            {
                DataTable dt = Data_Access.Data(q);
               if (dt.Rows.Count > 0)
               {
                    Name_blvl.Text = dt.Rows[0]["name"].ToString();
                    parent_bclvl.Text = dt.Rows[0]["parent_name"].ToString();
                   Email_bclvl.Text = dt.Rows[0]["email"].ToString();
                }      
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Name_blvl_Click(object sender, EventArgs e)
        {

        }

        private void Refresh_btbtn_Click(object sender, EventArgs e)
        {
            Input_name_bmtb.Text = ID_blvl.Text = Name_blvl.Text = Email_bclvl.Text = "";
            this.Intialization();
        }

        private void Delete_btbtn_Click(object sender, EventArgs e)
        {
            string q = "select l_id from Log_In_Id where stu_id='" + ID_blvl.Text + "'";
            try
            {
                DataTable dt = Data_Access.Data(q);
                int l_id = Convert.ToInt32(dt.Rows[0]["l_id"].ToString());
                Data_Access.Delete_Data("delete from Log_In where l_id = " + l_id);
                Data_Access.Delete_Data("delete from Log_In_Id where stu_id='" + ID_blvl.Text + "'");
                dt = Data_Access.Data("select name_id,parent_id from Student where stu_id = '" + ID_blvl.Text + "'");
                l_id = Convert.ToInt32(dt.Rows[0]["name_id"].ToString());
                int p_id = Convert.ToInt32(dt.Rows[0]["parent_id"].ToString());
                Data_Access.Delete_Data("delete from Student where stu_id = '" + ID_blvl.Text + "'");
                Data_Access.Delete_Data("delete from Name where name_id = " + l_id);
                dt = Data_Access.Data("select name_id from Parent where parent_id="+p_id);
                l_id = Convert.ToInt32(dt.Rows[0]["name_id"].ToString());
                Data_Access.Delete_Data("delete from Parent where parent_id = " + p_id);
                Data_Access.Delete_Data("delete from Name where name_id = " + l_id);
                MessageBox.Show(Name_blvl.Text + " Removed");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Input_name_bmtb.Text = Name_blvl.Text = ID_blvl.Text = Email_bclvl.Text =parent_bclvl.Text= "";
                this.Load_Data_To_Grid();
            }
        }
    }
}
