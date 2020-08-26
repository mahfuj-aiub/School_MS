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
    public partial class office_Settings : Form
    {
        public office_Settings()
        {
            InitializeComponent();
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            office ofi1 = new office();
            this.Hide();
            DialogResult d = ofi1.ShowDialog();
            this.Close();

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            txtbxCurrentPass.Text = txtbxConfirmPass.Text = txtbxNewPass.Text = "";
            office ofi2 = new office();
            this.Hide();
            DialogResult d = ofi2.ShowDialog();
            this.Close();
        }

        private void ButtonChngPass_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Database.Data(@"select l_id from Log_In_Id where admin_id='" + Office_Profile.UserId + "';");
                string str = dt.Rows[0]["l_id"].ToString();
                dt = Database.Data("select password from Log_In where l_id=" + str + ";");
                string pass = dt.Rows[0]["password"].ToString();
              
                if (txtbxCurrentPass.Text.Equals(pass.Trim()))
                {
                    if (txtbxConfirmPass.Text.Equals(txtbxNewPass.Text))
                    {
                        Database.Excute_Query("update Log_In set password='" + txtbxNewPass.Text + "' where l_id=" + str);
                    }
                    else
                        Mismatch_lbl.Visible = true;

                }
                else
                {
                    MessageBox.Show("You entered a wrong password");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Mismatch_lbl.Visible = false;
                txtbxCurrentPass.Text = txtbxConfirmPass.Text = txtbxNewPass.Text = "";
            }
           
        }
    }
}
