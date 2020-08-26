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
    public partial class page_routine : UserControl
    {
        public page_routine()
        {
            InitializeComponent();
        }

        private void page_routine_Load(object sender, EventArgs e)
        {
            try
            {
                Database.Excute_Query("IF OBJECT_ID('dbo.Routine', 'V') IS NOT NULL  DROP VIEW dbo.Routine");
                Database.Excute_Query(@"create view Routine
                                            as
                                      select time_id,sub_name from Subject,Read_Subject
                                          where Read_Subject.sub_id=Subject.sub_id and stu_id='"+Student_Profile.UserId+"'; ");
                string query = @"Select sub_name,time,day
                                     from Time_Table,Routine
                                   where Time_Table.time_id=Routine.time_id";
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
