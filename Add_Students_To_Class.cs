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
    public partial class Add_Students_To_Class : UserControl
    {
        public Add_Students_To_Class()
        {
            InitializeComponent();
        }


        private void Initialization()
        {
            this.Load_Classes();
        }
        private void Load_Classes()
        {

            ArrayList a = new ArrayList();
            a = Data_Access.get_Class_Name("select cls_name from Class");

            foreach (var i in a)
            {
                Select_class_bdd.AddItem(i.ToString());

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

        private void Add_Students_To_Class_Load(object sender, EventArgs e)
        {
            this.Initialization();
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

        private void Select_class_bdd_onItemSelected(object sender, EventArgs e)
        {
            ArrayList a = new ArrayList();
            a = Data_Access.get_Class_Name("select section from Class where cls_name= '" + Select_class_bdd.selectedValue + "'");

            foreach (var i in a)
            {
                Select_section_bdd.AddItem(i.ToString());

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
            Select_class_bdd.selectedIndex = Select_section_bdd.selectedIndex = -1;
            Name_blvl.Text = ID_blvl.Text = "";
        }

        private void Refresh_btbtn_Click(object sender, EventArgs e)
        {
            this.Initialization();
            Select_class_bdd.selectedIndex = Select_section_bdd.selectedIndex = -1;
            Name_blvl.Text = ID_blvl.Text = "";

        }

        private void Assign_btbtn_Click(object sender, EventArgs e)
        {
            string q = "Select cls_id from Class where cls_name='" + Select_class_bdd.selectedValue + "' and Section='" + Select_section_bdd.selectedValue + "';";
            try
            {
                DataTable dt = Data_Access.Data(q);
                q = dt.Rows[0]["cls_id"].ToString();
                Data_Access.Delete_Data("insert into Student_Take_Class(stu_id,cls_id) values('" + ID_blvl.Text + "','" + q + "');") ;
                MessageBox.Show(Name_blvl.Text+" Inserted");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Initialization();
                Select_class_bdd.selectedIndex = Select_section_bdd.selectedIndex = -1;
                Name_blvl.Text = ID_blvl.Text = "";

            }
        }
    }
}
