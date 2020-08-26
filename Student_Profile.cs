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
    public partial class Student_Profile : Form
    {
        private static string userId = "";
        public static string UserId
        {
            get;set;
        }
        public Student_Profile()
        {
            InitializeComponent();
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            Student_initiant_page sip2 = new Student_initiant_page();
            this.Hide();
            DialogResult d = sip2.ShowDialog();
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Student_Profile_Load(object sender, EventArgs e)
        {
            try
            {
                Database.Excute_Query("IF OBJECT_ID('dbo.S_Profile', 'V') IS NOT NULL  DROP VIEW dbo.S_Profile");
                Database.Excute_Query(@"create view S_Profile
                                               as
                                          select parent_id,first_name+' '+last_name as name
                                            from Parent,Name
                                            where Parent.name_id=Name.name_id; ");
                string query = @"select stu_id,first_name+' '+last_name as name,phone,S_Profile.name as parent_name,email,dob,address
                                  from dbo.S_Profile,Student,Name
                                 where Student.name_id=Name.name_id and Student.parent_id=dbo.S_Profile.parent_id and stu_id='"+UserId+"';";
                DataTable dt = Database.Data(query);
                if (dt.Rows.Count > 0)
                {
                    ID_pic_tb.Text = dt.Rows[0]["stu_id"].ToString();
                    ID_tb.Text = dt.Rows[0]["stu_id"].ToString();
                    Name_pic_tb.Text = dt.Rows[0]["name"].ToString();
                    Name_tb.Text = dt.Rows[0]["name"].ToString();
                    Welcome_name_blvl.Text = dt.Rows[0]["name"].ToString();
                    Phone_tb.Text = dt.Rows[0]["phone"].ToString();
                    Email_tb.Text = dt.Rows[0]["email"].ToString();
                    Parent_tb.Text = dt.Rows[0]["parent_name"].ToString();
                    Dob_tb.Text = dt.Rows[0]["dob"].ToString();
                    Address_tb.Text = dt.Rows[0]["address"].ToString();
                }
                dt = Database.Data(@"select cls_name,section from Class,Student_Take_Class
                                    where Class.cls_id=Student_Take_Class.cls_id and stu_id='" + ID_tb.Text + "';");
                if (dt.Rows.Count > 0)
                {
                    Class_tb.Text= dt.Rows[0]["cls_name"].ToString();
                    Section_tb.Text= dt.Rows[0]["section"].ToString();

                }
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
