using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using System.Data;

namespace School_MS
{
    static class Data_Access
    {
        private static readonly string  db_Pack = @"Data Source=MAHFUJ\SQLEXPRESS;Initial Catalog=School;Integrated Security=True";
        public static int Insert_Into_Table(string query)
        {
            SqlConnection con = new SqlConnection(db_Pack);
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                int ret=-2;
                if (Int32.TryParse(cmd.ExecuteScalar().ToString(), out ret))
                {
                    return ret;
                }
                else
                    return ret;

        
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
            finally
            {
                con.Close();
            }

        }
        public static Dictionary<string, string> get_Name(string q)
        {

            Dictionary<string, string> dict = new Dictionary<string, string>();
            SqlConnection con = new SqlConnection(db_Pack);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    // dict.Add(Convert.ToString(Reader["teacher_id"]), Convert.ToString(Reader["Name"]));
                    dict.Add(Reader.GetValue(0).ToString(), Reader.GetString(1));
                }
                return dict;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return dict;
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
        public static void Delete_Data(string q)
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





    }
}
