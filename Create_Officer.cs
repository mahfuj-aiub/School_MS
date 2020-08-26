using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_MS
{
    public partial class Create_Officer : UserControl
    {
        public Create_Officer()
        {
            InitializeComponent();
        }

        private void bunifuThinButtonSignup_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (!Validation_Check.check_Name_Pattern(bunifuMaterialTextboxUserName.Text))
            {
                flag = false;
                bunifuMaterialTextboxUserName.Text = "";
                MessageBox.Show("Insert Valid Name");
            }
            if (!Validation_Check.check_Name_Pattern(bunifuMaterialTextbox1.Text))
            {
                flag = false;
                bunifuMaterialTextbox1.Text = "";
                MessageBox.Show("Insert Valid Name");
            }
            if (flag == true)
            {
                string q = "insert into Name(first_name,last_name) values('" + bunifuMaterialTextboxUserName.Text + "','" + bunifuMaterialTextbox1.Text + "'); select scope_identity()";

                int pk = Data_Access.Insert_Into_Table(q);
                q = "insert into Admin(admin_id,name_id) values('" + bunifuMaterialTextboxID.Text + "','" + pk + "');  select scope_identity()";
                pk = Data_Access.Insert_Into_Table(q);
                q = "insert into Log_In_Id(admin_id) values('" + bunifuMaterialTextboxID.Text + "');select scope_identity()";
                pk = Data_Access.Insert_Into_Table(q);
                q = "insert into Log_In(l_id,password,role) values('" + pk + "','" + bunifuMaterialTextbox2.Text + "','Officer'); select scope_identity()";
                pk = Data_Access.Insert_Into_Table(q);

                MessageBox.Show("Registered");
                bunifuMaterialTextbox1.Text = bunifuMaterialTextbox2.Text = bunifuMaterialTextboxID.Text = bunifuMaterialTextboxUserName.Text = "";
            }
            else
                MessageBox.Show("Registration Failed");
           


        }

        private void Create_Officer_Load(object sender, EventArgs e)
        {

            bunifuMaterialTextboxID.Text = Generate_Random_Value.generate_Official_Id();
            bunifuMaterialTextbox2.Text = Generate_Random_Value.generate_Password().ToString();

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Generate_Random_Value.Increment_Officer_Id();
            bunifuMaterialTextboxID.Text = Generate_Random_Value.generate_Official_Id();
            bunifuMaterialTextbox2.Text = Generate_Random_Value.generate_Password().ToString();
            bunifuMaterialTextbox1.Text = bunifuMaterialTextboxUserName.Text= "";
        }
    }
}
