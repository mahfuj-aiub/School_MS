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
    public partial class office : Form
    {
        public office()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            page_addStudent.BringToFront();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            page_manageStudent.BringToFront();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            page_manageTeacher.BringToFront();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            office_Settings os = new office_Settings();
            this.Hide();
            DialogResult d = os.ShowDialog();
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Office_Profile op = new Office_Profile();
            this.Hide();
            DialogResult d = op.ShowDialog();
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
           // Login lg = new Login();
            
            //lg.Show();
            this.Close();
        }
    }
}
