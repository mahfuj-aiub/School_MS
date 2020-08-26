using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Officer
{
    static class Database
    {
        private static readonly string db_Pack = @"Data Source=MAHFUJ\SQLEXPRESS;Initial Catalog=School;Integrated Security=True";
        public static void Excute_Query(string q)
        {
            SqlConnection con = new SqlConnection(db_Pack);
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            finally
            {
                con.Close();
            }
        }
        public static ArrayList get_Class_Name(string q)
        {


            ArrayList a = new ArrayList();
            SqlConnection con = new SqlConnection(db_Pack);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    a.Add(Reader.GetString(0));
                }
                return a;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return a;
            }
            finally
            {
                con.Close();
            }
        }
        public static DataTable Data(string query)
        {
            SqlConnection con = new SqlConnection(db_Pack);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            return ds.Tables[0];
        }
    }
}
