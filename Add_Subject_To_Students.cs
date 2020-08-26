using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace School_MS
{
    public partial class Add_Subject_To_Students : UserControl
    {
        public Add_Subject_To_Students()
        {
            InitializeComponent();
        }
        private void Load_Classes()
        {
            string q = "select sub_id,sub_name from Subject";
            Dictionary<string, string> d = new Dictionary<string, string>();
            d = Data_Access.get_Name(q);
            foreach (KeyValuePair<string, string> i in d)
            {
                Select_subject_bdd.AddItem(i.Value);
                Select_id_bdd.AddItem(i.Key);
            }
            try
            {
                string query = @"select stu_id,first_name+' '+last_name as name,email
                                  from Student,Name
                                 where Student.name_id=Name.name_id ;";
                DataTable dt = Data_Access.Data(query);
                Student_bcdgv.AutoGenerateColumns = false;
                Student_bcdgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Add_Subject_To_Students_Load(object sender, EventArgs e)
        {
            this.Intialiazation();
        }
        private void Intialiazation()
        {
            this.Load_Classes();
        }

        private void Search_btbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Data_Access.Delete_Data("IF OBJECT_ID('dbo.S_Search', 'V') IS NOT NULL  DROP VIEW dbo.S_Search;");
                Data_Access.Delete_Data(@"create view S_Search as select stu_id,first_name+' '+last_name as name,email
                                  from Student,Name
                                 where Student.name_id=Name.name_id ;");
                string query = @"select * from S_Search
								 where name like '%" + Input_name_bmtb.Text + "%';";
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
            string q = @"select first_name+' '+last_name as name
                                  from Student,Name
                                 where Student.name_id=Name.name_id  and stu_id='" + ID_blvl.Text + "'";
            try
            {
                DataTable dt = Data_Access.Data(q);

                Name_blvl.Text = dt.Rows[0]["name"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cancel_btbtn_Click(object sender, EventArgs e)
        {
            Select_subject_bdd.selectedIndex = Select_id_bdd.selectedIndex = -1;
            Name_blvl.Text = ID_blvl.Text = "";
        }

        private void Refresh_btbtn_Click(object sender, EventArgs e)
        {
            this.Load_Classes();
            Name_blvl.Text = ID_blvl.Text = Input_name_bmtb.Text="";
        }

        private void Assign_btbtn_Click(object sender, EventArgs e)
        {
            Data_Access.Delete_Data("insert into [dbo].[Read_Subject] (sub_id,stu_id) values("+Select_id_bdd.selectedValue+",'"+ID_blvl.Text+"');");
            MessageBox.Show(Name_blvl.Text+" Added");
            Name_blvl.Text = ID_blvl.Text = "";
            Select_subject_bdd.selectedIndex = -1;
            this.Intialiazation();
        }

        private void Select_subject_bdd_onItemSelected(object sender, EventArgs e)
        {
            Select_id_bdd.selectedIndex = Select_subject_bdd.selectedIndex;
        }
    }
}
