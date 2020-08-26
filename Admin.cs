using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_MS
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void Admin_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void Log_out_bimb_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void Log_out_bimb_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Log Out", Log_out_bimb);
        }

        private void Home_bimb_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Home", Home_bimb);
        }

        private void Log_out_bimb_Click(object sender, EventArgs e)
        {
            Login_Page l = new Login_Page();
            this.Hide();
            DialogResult d = l.ShowDialog();
            this.Close();
           
           // admin_Home_Page1.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            //  create_Student_Account1.Enabled=false;
            //create_Teacher_Account1.Enabled=false;
            //create_Officer1.Enabled=false;
            admin_Home_Page1.BringToFront();
        }

        private void createStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            create_Student_Account1.BringToFront();
           
        }

        private void createTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            create_Teacher_Account1.BringToFront();
           
        }

        private void createOfficerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            create_Officer1.BringToFront();
            
        }

        private void Home_bimb_Click(object sender, EventArgs e)
        {
            admin_Home_Page1.BringToFront();
        }

        private void addSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_Subject_Drop_Down1.BringToFront();
        }

        private void deleteSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete_Subject1.BringToFront();
        }

        private void createClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            create_Class1.BringToFront();
        }

        private void seacrhOfficerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_Officer1.BringToFront();
        }

        private void searchTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_Teacher_Admin1.BringToFront();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_Student_Admin1.BringToFront();
        }

        private void assignedSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            assigned_Subject_To_Teacher1.BringToFront();
        }

        private void addStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_Students_To_Class1.BringToFront();
        }

        private void checkStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            check_Students_Class1.BringToFront();
        }

        private void addStudentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            add_Subject_To_Students1.BringToFront();
        }
    }
}
