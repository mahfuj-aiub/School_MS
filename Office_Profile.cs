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
    public partial class Office_Profile : Form
    {
        public static string userId = "";
        public static string UserId
        {
            get; set;
        }


        public Office_Profile()
        {
            InitializeComponent();
        }
   
        private void btnBack_Click(object sender, EventArgs e)
        {
            office ofi = new office();
            this.Hide();
            DialogResult d = ofi.ShowDialog();
            this.Close();
        }

        private void Office_Profile_Load(object sender, EventArgs e)
        {
            txtbxID.Text = UserId;
            DataTable dt = Database.Data(@"select first_name+' '+last_name as name
                                               from Admin,Name
                                         where Admin.name_id=Name.name_id and admin_id='"+txtbxID.Text+" ';");
            txtbxName.Text = dt.Rows[0]["name"].ToString();
        }
    }
}
