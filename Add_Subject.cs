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
    public partial class Add_Subject_Drop_Down : UserControl
    {
        public Add_Subject_Drop_Down()
        {
            InitializeComponent();
        }

        private void Add_Subject_blvl_Load(object sender, EventArgs e)
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
                Select_teacher_bdd.AddItem(i.Value);
                Teacher_id_bdd.AddItem(i.Key);
            }
        }

        private void Refresh_btb_Click(object sender, EventArgs e)
        {
            Subject_name_bmtb.Text = "";
            Day_bdd.selectedIndex = Start_bdd.selectedIndex=End_bdd.selectedIndex=-1;
            Select_teacher_bdd.selectedIndex = -1;
            this.Teacher_drop_down_box_data();
        }

        private void Cancel_btb_Click(object sender, EventArgs e)
        {
            Subject_name_bmtb.Text = "";
            Day_bdd.selectedIndex = Start_bdd.selectedIndex = End_bdd.selectedIndex = -1;
            Select_teacher_bdd.selectedIndex = -1;
        }

        private void Create_btb_Click(object sender, EventArgs e)
        {
            string q = "insert into Time_Table(time,day) values(' " + Start_bdd.Text +" to "+End_bdd.Text+ "','" + Day_bdd.selectedValue+ "'); select scope_identity();";
            int pk = Data_Access.Insert_Into_Table(q);
            q = "insert into Subject(sub_name,teacher_id,time_id) values(' " + Subject_name_bmtb.Text + "','" + Teacher_id_bdd.selectedValue + "','" + pk + "'); select scope_identity();";
            pk = Data_Access.Insert_Into_Table(q);
            MessageBox.Show("Done ");
            Subject_name_bmtb.Text ="";
            Day_bdd.selectedIndex = Start_bdd.selectedIndex = End_bdd.selectedIndex = -1;
            Select_teacher_bdd.selectedIndex = -1;

        }

        private void Select_teacher_bdd_onItemSelected(object sender, EventArgs e)
        {
            Teacher_id_bdd.selectedIndex = Select_teacher_bdd.selectedIndex;
        }

        private void Teacher_id_bdd_onItemSelected(object sender, EventArgs e)
        {
            Select_teacher_bdd.selectedIndex = Teacher_id_bdd.selectedIndex;
        }

        private void Start_bdd_onItemSelected(object sender, EventArgs e)
        {
            End_bdd.selectedIndex = Start_bdd.selectedIndex;
        }

        private void End_bdd_onItemSelected(object sender, EventArgs e)
        {
            Start_bdd.selectedIndex = End_bdd.selectedIndex;
        }
    }
}
