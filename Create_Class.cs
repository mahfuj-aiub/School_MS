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
    public partial class Create_Class : UserControl
    {
        public Create_Class()
        {
            InitializeComponent();
        }

        private void Create_Class_Load(object sender, EventArgs e)
        {
            this.Initialization();
        }
        private void Initialization()
        {
            this.Teacher_drop_down_box_data();
        }
        private void Teacher_drop_down_box_data()
        {
            string query = "select teacher_id,first_name+' '+last_name as Name from Teacher,Name where Teacher.name_id=Name.name_id;";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict = Data_Access.get_Name(query);
            foreach (KeyValuePair<string, string> i in dict)
            {
                Class_teacher_bdd.AddItem(i.Value);
                Class_teacher_id_bdd.AddItem(i.Key);
            }
        }

        private void Class_teacher_bdd_onItemSelected(object sender, EventArgs e)
        {
            Class_teacher_id_bdd.selectedIndex = Class_teacher_bdd.selectedIndex;
        }

        private void Class_teacher_id_bdd_onItemSelected(object sender, EventArgs e)
        {
            Class_teacher_bdd.selectedIndex = Class_teacher_id_bdd.selectedIndex;
        }

        private void Cancel_btbtn_Click(object sender, EventArgs e)
        {
            Class_name_bmtb.Text = "";
            Section_name_bdd.selectedIndex = Class_teacher_bdd.selectedIndex = Class_teacher_id_bdd.selectedIndex = 0;
 
        }

        private void Refresh_btbtn_Click(object sender, EventArgs e)
        {
            this.Initialization();
            Class_name_bmtb.Text = "";
            Section_name_bdd.selectedIndex = Class_teacher_bdd.selectedIndex = Class_teacher_id_bdd.selectedIndex = 0;
        }

        private void Create_btbtn_Click(object sender, EventArgs e)
        {
            string q = "insert into Class(cls_name,section) values('" + Class_name_bmtb.Text + "','" + Section_name_bdd.selectedValue + "');  select scope_identity()";
            int pk = Data_Access.Insert_Into_Table(q);
            q = "insert into Teacher_assigned_class(teacher_id,cls_id) values('" + Class_teacher_id_bdd.selectedValue + "','" + pk + "');select scope_identity()";
            pk = Data_Access.Insert_Into_Table(q);
            MessageBox.Show("Class Created");
            Class_name_bmtb.Text = "";
            Section_name_bdd.selectedIndex = Class_teacher_bdd.selectedIndex = Class_teacher_id_bdd.selectedIndex = 0;
        }
    }
}
