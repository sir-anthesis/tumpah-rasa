using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using TumpahRasa.Pages.TumpahRasa;
using System.Collections;
using System.Runtime.Remoting.Messaging;

namespace TumpahRasa.Models
{
    public class Account
    {
        public int id_member, id_admin;
        public string username, email, password;

        string flag;

        Connection con = new Connection();

        public string CreateMember() 
        {
            try
            {
                con.OpenCon();
                string query = "INSERT INTO tb_member (name, email, password) VALUES (@name, @email, @password)";
                SqlCommand com = new SqlCommand(query, con.myConnection);
                com.Parameters.AddWithValue("name", username);
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

        public string doLogin()
        {
            ArrayList data = new ArrayList();
            try
            {
                con.OpenCon();
                string query = "SELECT * FROM tb_member WHERE name = @usn AND password = @pass";
                SqlCommand com = new SqlCommand(query, con.myConnection);
                com.Parameters.AddWithValue("@usn", username);
                com.Parameters.AddWithValue("@pass", password);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    data.Add(dr[1].ToString());
                    data.Add(dr[3].ToString());
                    dr.Close();
                    flag = "member";
                }
                else
                {
                    dr.Close();
                    string query2 = "SELECT * FROM tb_admin WHERE name = @usn AND password = @pass";
                    SqlCommand com2 = new SqlCommand(query2, con.myConnection);
                    com2.Parameters.AddWithValue("@usn", username);
                    com2.Parameters.AddWithValue("@pass", password);
                    SqlDataReader dr2 = com2.ExecuteReader();
                    if (dr2.Read())
                    {
                        data.Add(dr2[1].ToString());
                        data.Add(dr2[3].ToString());
                        dr2.Close();
                        flag = "admin";
                    }
                    else
                    {
                        dr2.Close();
                        flag = "login failed";
                    }
                }
            }
            catch (Exception ex)
            {
                flag = "Err : " + ex;
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