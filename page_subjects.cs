using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Officer
{
    public partial class page_subjects : UserControl
    {
        public page_subjects()
        {
            InitializeComponent();
        }

        private void page_subjects_Load(object sender, EventArgs e)
        {
            try
            {
                Database.Excute_Query("IF OBJECT_ID('dbo.Subject_Teacher', 'V') IS NOT NULL  DROP VIEW dbo.Subject_Teacher");
                Database.Excute_Query(@"create view Subject_Teacher
                                              as
                                     select teacher_id,first_name+' '+last_name as name from Teacher,Name where Teacher.name_id=Name.name_id; ");
                string query = @"Select sub_name,name from Subject,Read_Subject,Subject_Teacher
                                   where Subject.sub_id=Read_Subject.sub_id 
                                     and Subject_Teacher.teacher_id=Subject.teacher_id and stu_id='"+Student_Profile.UserId+"';";
                DataTable dt = Database.Data(query);
                Student_bcdgv.AutoGenerateColumns = false;
                Student_bcdgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
