using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Officer;

namespace School_MS
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        private void Password_bmtb_OnValueChanged(object sender, EventArgs e)
        {
           
        }

        private void Password_cb_OnChange(object sender, EventArgs e)
        {
            Password_bmtb.isPassword = true;
            if (Password_cb.Checked == true)
            {
                Password_bmtb.isPassword = false;
            }
            else
                Password_bmtb.isPassword = true;
        }

        private void Login_bb_Click(object sender, EventArgs e)
        {
             bool errorLabel = false;
            if (Id_bmtb.Text.Equals("admin") && Password_bmtb.Text.Equals("admin"))
            {
                errorLabel = true;
                Admin a = new Admin();
                this.Hide();
                DialogResult d = a.ShowDialog();
                this.Close();
               
            }
            else
            {
                DataTable dt = Data_Access.Data(@"select l_id from Log_In_Id 
                                  where stu_id='" + Id_bmtb.Text + "' or teacher_id='" + Id_bmtb.Text + "' or admin_id='" + Id_bmtb.Text + "'");
                string temp_id = "";
                try
                {
                    temp_id = dt.Rows[0]["l_id"].ToString();
                }
                catch (Exception )
                {
                   // MessageBox.Show("Invalid ID");
                }
                try
                {
                    dt = Data_Access.Data("select role from Log_In where password='" + Password_bmtb.Text + "' and l_id=" + temp_id);
                    string role = dt.Rows[0]["role"].ToString().Trim();

                    if (role.Equals("Student"))
                    {
                        errorLabel = true;
                        Student_Officer.Student_Profile.UserId = Id_bmtb.Text;
                        Student_Officer.Student_initiant_page s = new Student_Officer.Student_initiant_page();
                        this.Hide();
                        DialogResult d = s.ShowDialog();
                        this.Close();
                    }
                    else if (role.Equals("Officer"))
                    {
                        errorLabel = true;
                        Student_Officer.Office_Profile.UserId = Id_bmtb.Text;
                        Student_Officer.office o = new Student_Officer.office();
                        this.Hide();
                        DialogResult d = o.ShowDialog();
                        this.Close();
                    }
                    else if (role.Equals("Teacher"))
                    {
                        errorLabel = true;
                        TeacherPart.Teacher_Profile.UserId = Id_bmtb.Text;
                        TeacherPart.Teacher t = new TeacherPart.Teacher();
                        this.Hide();
                        DialogResult d = t.ShowDialog();
                        this.Close();


                    }
                    
                }
                catch (Exception )
                {
                   // MessageBox.Show("Invalid Password");
                }

            }
            if (errorLabel == false)
            {
                bunifuCustomLabel2.Visible = true;
            }
           
        
                Password_bmtb.Text = Id_bmtb.Text = "";
          
           
           
        }
    }
}
