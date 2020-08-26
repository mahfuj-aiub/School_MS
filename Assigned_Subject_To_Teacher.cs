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
    public partial class Assigned_Subject_To_Teacher : UserControl
    {
        public Assigned_Subject_To_Teacher()
        {
            InitializeComponent();
        }

        private void Assigned_Subject_To_Teacher_Load(object sender, EventArgs e)
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
            string query = "select teacher_id,first_name+' '+last_name as Name from Teacher,Name where Teacher.name_id=Name.name_id;";
            Dictionary<string, string> d = new Dictionary<string, string>();
            d = Data_Access.get_Name(query);
            foreach (KeyValuePair<string, string> i in d)
            {
                Select_teacher_bdd.AddItem(i.Value);
                Teacher_ID_bdd.AddItem(i.Key);
            }
        }

        private void Select_class_bdd_onItemSelected(object sender, EventArgs e)
        {
            ArrayList a = new ArrayList();
            a = Data_Access.get_Class_Name("select section from Class where cls_name= '"+Select_class_bdd.selectedValue+"'");

            foreach (var i in a)
            {
                Select_section_bdd.AddItem(i.ToString());

            }
        }

        private void Select_section_bdd_onItemSelected(object sender, EventArgs e)
        {
            Data_Access.Delete_Data("IF OBJECT_ID('dbo.Find_Subject', 'V') IS NOT NULL  DROP VIEW dbo.Find_Subject");
            Data_Access.Delete_Data(@"Create view Find_Subject
                                          as
                                      select sub_id,sub_name,Teacher_assigned_class.teacher_id as teacher_id,cls_id 
                                     from Subject,Teacher_assigned_class
                                     where Subject.teacher_id=Teacher_assigned_class.teacher_id; ");
           
            string q = @"select sub_id,sub_name
                          from Find_Subject,Class
                       where Find_Subject.cls_id=Class.cls_id and cls_name = '"+Select_class_bdd.selectedValue+ "' and section = '"+Select_section_bdd.selectedValue+"';";
            Dictionary<string, string> d = new Dictionary<string, string>();
            d = Data_Access.get_Name(q);
            foreach (KeyValuePair<string, string> i in d)
            {
                Select_subject_bdd.AddItem(i.Value);
                Subject_id_bdd.AddItem(i.Key);
            }


        }

        private void Cancel_btbtn_Click(object sender, EventArgs e)
        {
            this.Initialization();
            Select_section_bdd.selectedIndex = Select_subject_bdd.selectedIndex = -1;
        }

        private void Assign_btbtn_Click(object sender, EventArgs e)
        {
            Data_Access.Delete_Data("update Subject set teacher_id='" + Teacher_ID_bdd.selectedValue + "' where sub_id=" + Subject_id_bdd.selectedValue);
            MessageBox.Show("Value Updated");
            this.Initialization();
            Select_section_bdd.selectedIndex = Select_subject_bdd.selectedIndex = -1;

        }

        private void Select_teacher_bdd_onItemSelected(object sender, EventArgs e)
        {
            Teacher_ID_bdd.selectedIndex = Select_teacher_bdd.selectedIndex;
        }

        private void Teacher_ID_bdd_onItemSelected(object sender, EventArgs e)
        {
            Select_teacher_bdd.selectedIndex = Teacher_ID_bdd.selectedIndex;
        }

        private void Select_subject_bdd_onItemSelected(object sender, EventArgs e)
        {
            Subject_id_bdd.selectedIndex = Select_subject_bdd.selectedIndex;
        }
    }
}
