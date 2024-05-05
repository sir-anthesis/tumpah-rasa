using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Web;
using TumpahRasa.Pages.Admin;

namespace TumpahRasa.Models
{
    public class Recipe
    {
        public List<RecipeInfoList> ril = new List<RecipeInfoList>();

        public string name, thumbnail, description, created_at;
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
                    AdminMaster.alert = "success";
                    AdminMaster.msg = "Data created success";
                }
                else
                {
                    flag = "failed";
                    AdminMaster.alert = "warning";
                    AdminMaster.msg = "Data created failed";
                }

            }
            catch (Exception ex)
            {
                flag = ex.Message;
                AdminMaster.alert = "danger";
                AdminMaster.msg = flag;
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

        public void ShowRecipe() 
        {
            try
            {
                con.OpenCon();
                string query = "SELECT * FROM tb_recipe";
                SqlCommand com = new SqlCommand(query, con.myConnection);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    RecipeInfoList ri = new RecipeInfoList
                    {
                        id = reader.GetInt32(0),
                        name = reader.GetString(1),
                        thumbnail = reader.GetString(2),
                        rating = reader.GetDouble(6),
                        created_at = reader.GetDateTime(4).ToString("yyyy-MM-dd")
                    };

                    ril.Add(ri);
                }

            }
            catch (Exception ex)
            {
                Default.tt = ("error" + ex);
            }
            finally
            {
                if (con.myConnection.State == ConnectionState.Open)
                {
                    con.myConnection.Close();
                    con.myConnection = null;
                }
            }
        }

        public void GetARecipe(int id) 
        {
            try
            {
                con.OpenCon();
                string query = "SELECT * FROM tb_recipe WHERE id_recipe = @id";
                SqlCommand com = new SqlCommand(query, con.myConnection);
                com.Parameters.AddWithValue("id", id);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    name = reader.GetString(1);
                    thumbnail = reader.GetString(2);
                    description = reader.GetString(3);
                    created_at = reader.GetDateTime(4).ToString("yyyy-MM-dd");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con.myConnection.State == ConnectionState.Open)
                {
                    con.myConnection.Close();
                    con.myConnection = null;
                }
            }
        }

        public string UpdateRecipe(int id)
        {
            try
            {
                con.OpenCon();
                string query = "UPDATE tb_recipe SET name = @name, thumbnail = @thumbnail, description = @description, created_at = @created_at, id_admin = @id_admin WHERE id_recipe = @id_recipe";
                SqlCommand com = new SqlCommand(query, con.myConnection);
                com.Parameters.AddWithValue("name", name);
                com.Parameters.AddWithValue("thumbnail", thumbnail);
                com.Parameters.AddWithValue("description", description);
                com.Parameters.AddWithValue("created_at", DateTime.Now);
                com.Parameters.AddWithValue("id_admin", GlobalVariable.adminId);
                com.Parameters.AddWithValue("id_recipe", id);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    flag = "successed";
                    AdminMaster.alert = "success";
                    AdminMaster.msg = "Data updated success";
                }
                else
                {
                    flag = "failed";
                    AdminMaster.alert = "warning";
                    AdminMaster.msg = "Data created failed";
                }

            }
            catch (Exception ex)
            {
                flag = ex.Message;
                AdminMaster.alert = "danger";
                AdminMaster.msg = "Error : " + flag;
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

    public class RecipeInfoList
    {
        public int id { get; set; }
        public string name { get; set; }
        public string thumbnail { get; set; }
        public double rating { get; set; }
        public string created_at { get; set; }
    }
}