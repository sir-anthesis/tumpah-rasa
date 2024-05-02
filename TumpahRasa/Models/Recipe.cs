using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace TumpahRasa.Models
{
    public class Recipe
    {
        public string name, thumbnail, description;
        public float rating;

        string flag;

        Connection con = new Connection();

        public string InsertRecipe() 
        {
            try
            {
                con.OpenCon();
                string query = "INSERT INTO tb_recipe (name, thumbnail, description, created_at, id_admin, rating) VALUES (@name, @thumbnail, @description, @created_at, @id_admin, @rating)";
                SqlCommand com = new SqlCommand(query, con.myConnection);
                com.Parameters.AddWithValue("name", name);
                com.Parameters.AddWithValue("thumbnail", thumbnail);
                com.Parameters.AddWithValue("description", description);
                com.Parameters.AddWithValue("created_at", DateTime.Now);
                com.Parameters.AddWithValue("id_admin", GlobalVariable.adminId);
                com.Parameters.AddWithValue("rating", 0);
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
                Console.WriteLine(flag);
            }
            finally
            {
                if (con.myConnection.State == ConnectionState.Open)
                {
                    con.myConnection.Close();
                    con.myConnection = null;
                }
            }
            return flag;
        }
    }
}