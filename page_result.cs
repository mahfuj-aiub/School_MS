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
    public partial class page_result : UserControl
    {

        public page_result()
        {
            InitializeComponent();
        }

        private void page_result_Load(object sender, EventArgs e)
        {
            try
            {
                string query = @"Select sub_name,result
                             from Subject,Read_Subject 
                            where Subject.sub_id=Read_Subject.sub_id and stu_id='"+Student_Profile.UserId+"';";
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
