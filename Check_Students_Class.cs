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
    public partial class Check_Students_Class : UserControl
    {
        public Check_Students_Class()
        {
            InitializeComponent();
        }

        private void Check_Students_Class_Load(object sender, EventArgs e)
        {
            this.Initialization();
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

        private void Load_btbtn_Click(object sender, EventArgs e)
        {
            Data_Access.Delete_Data("IF OBJECT_ID('dbo.Class_Student', 'V') IS NOT NULL  DROP VIEW dbo.Class_Student;");
            Data_Access.Delete_Data(@"create view Class_Student
                                        as
                                      Select stu_id from Student_Take_Class,class
                                     where Student_Take_Class.cls_id=Class.cls_id 
                                     and cls_name='" + Select_class_bdd.selectedValue + "' and section='" + Select_section_bdd.selectedValue +"'");
            string query = @"Select Student.stu_id,first_name+' '+last_name as name,email
                             from Class_Student,Name,Student
                               where Student.name_id=Name.name_id and Class_Student.stu_id=Student.stu_id;";
            DataTable dt = Data_Access.Data(query);
            Student_bcdgv.AutoGenerateColumns = false;
            Student_bcdgv.DataSource = dt;
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
            Name_blvl.Text = ID_blvl.Text = "";
        }

        private void Remove_btbtn_Click(object sender, EventArgs e)
        {
            string q = "Select cls_id from Class where cls_name='" + Select_class_bdd.selectedValue + "' and Section='" + Select_section_bdd.selectedValue + "';";
            try
            {
                DataTable dt = Data_Access.Data(q);
                q = dt.Rows[0]["cls_id"].ToString();
                Data_Access.Delete_Data("Delete from Student_Take_Class where cls_id=" + q + "and stu_id ='" + ID_blvl.Text + "';") ;
                MessageBox.Show(Name_blvl.Text + " Removed");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Name_blvl.Text = ID_blvl.Text = "";
            }
        }

        private void Refresh_btbtn_Click(object sender, EventArgs e)
        {
            Data_Access.Delete_Data("IF OBJECT_ID('dbo.Class_Student', 'V') IS NOT NULL  DROP VIEW dbo.Class_Student;");
            Data_Access.Delete_Data(@"create view Class_Student
                                        as
                                      Select stu_id from Student_Take_Class,class
                                     where Student_Take_Class.cls_id=Class.cls_id 
                                     and cls_name='" + Select_class_bdd.selectedValue + "' and section='" + Select_section_bdd.selectedValue + "'");
            string query = @"Select Student.stu_id,first_name+' '+last_name as name,email
                             from Class_Student,Name,Student
                               where Student.name_id=Name.name_id and Class_Student.stu_id=Student.stu_id;";
            DataTable dt = Data_Access.Data(query);
            Student_bcdgv.AutoGenerateColumns = false;
            Student_bcdgv.DataSource = dt;
        }
    }
}
