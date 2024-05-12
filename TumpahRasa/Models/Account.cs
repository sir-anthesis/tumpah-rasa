using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using TumpahRasa.Pages.TumpahRasa;

namespace TumpahRasa.Models
{
    public class Account
    {
        public int id_member, id_admin;
        public string name, email, password;

        string flag;

        Connection con = new Connection();

        public string CreateMember() 
        {
            try
            {
                con.OpenCon();
                string query = "INSERT INTO tb_member (name, email, password) VALUES (@name, @email, @password)";
                SqlCommand com = new SqlCommand(query, con.myConnection);
                com.Parameters.AddWithValue("name", name);
                com.Parameters.AddWithValue("email", email);
                com.Parameters.AddWithValue("password", password);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    flag = "successed";
                }
                else
                {
                    flag = "failed";
                }

            }
            catch (Exception ex)
            {
                flag = ex.Message;
            }
            finally
            {
                if (con.myConnection.State == ConnectionState.Open)
                {
                    con.myConnection.Close();
                }
            }
            return flag;
        }
    }
}