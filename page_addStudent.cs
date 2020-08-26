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

namespace Student_Officer
{
    public partial class page_addStudent : UserControl
    {
        public page_addStudent()
        {
            InitializeComponent();
        }

        private void page_addStudent_Load(object sender, EventArgs e)
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
            a = Database.get_Class_Name("Select cls_name from Class");
            foreach(var i in a)
            {
                Class_cb.Items.Add(i.ToString());
            }
        }

        private void Class_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList a = new ArrayList();
            a = Database.get_Class_Name("Select section from Class where cls_name='" + Class_cb.SelectedItem + "';") ;
            foreach (var i in a)
            {
                Section_cb.Items.Add(i.ToString());
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            txtboxID.Text = txtboxName.Text = "";
            Class_cb.SelectedIndex = Section_cb.SelectedIndex = -1;
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            Database.Excute_Query("insert into Student_Take_Class(stu_id,cls_id) values ");
             string q = @"select cls_id from Class
                              where cls_name='"+Class_cb.SelectedItem+"' and section='" + Section_cb.SelectedItem + "';";
             try
             {
                 DataTable dt = Database.Data(q);
                 q = dt.Rows[0]["cls_id"].ToString();
                Database.Excute_Query("insert into Student_Take_Class(stu_id,cls_id) values('"+txtboxID.Text+"',"+q+");");
                MessageBox.Show("Added");

            }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
            finally
            {
                txtboxID.Text = txtboxName.Text = "";
                Class_cb.SelectedIndex = Section_cb.SelectedIndex = -1;
            }
          

        }
    }
}
