using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Officer
{
    public partial class Student_initiant_page : Form
    {
        public Student_initiant_page()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(SideMenu.Width >= 339)
            {
                Logo.Location = new Point(10, 70);
                Logo.Size = new Size(30, 30);
                SideMenu.Width = 70 ;
            }

            else
            {
                Logo.Location = new Point(93, 44);
                Logo.Size = new Size(124, 101);
                SideMenu.Width = 339;
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Student_Profile sp = new Student_Profile();
            this.Hide();
            DialogResult d = sp.ShowDialog();
            this.Close();
        }

        private void btnRoutine_Click(object sender, EventArgs e)
        {
            page_routine.BringToFront();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            page_result.BringToFront();

        }

        private void btnsubjects_Click(object sender, EventArgs e)
        {
            page_subjects.BringToFront();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            student_settings ss = new student_settings();
            this.Hide();
            DialogResult d = ss.ShowDialog();
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
