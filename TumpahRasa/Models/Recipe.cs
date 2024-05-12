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
        public double rating;

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
                }
            }
            return flag;
        }

        public void ShowRecipe() 
        {
            try
            {
                con.OpenCon();
                string query = "SELECT * FROM tb_recipe ORDER BY created_at DESC";
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
                    created_at = reader.GetDateTime(4).ToString("dd-MMMM-yyyy");
                    rating = reader.GetDouble(6);
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
                }
            }
        }

        public string UpdateRecipe(int id)
        {
            try
            {
                con.OpenCon();
                string query = "UPDATE tb_recipe SET name = @name, description = @description, created_at = @created_at, id_admin = @id_admin WHERE id_recipe = @id_recipe";
                SqlCommand com = new SqlCommand(query, con.myConnection);
                com.Parameters.AddWithValue("name", name);
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
                }
            }
            return flag;
        }

        public void GetThumbnail(int id) 
        {
            try
            {
                con.OpenCon();
                string query = "SELECT thumbnail FROM tb_recipe WHERE id_recipe = @id";
                SqlCommand com = new SqlCommand(query, con.myConnection);
                com.Parameters.AddWithValue("id", id);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    EditThumb.old_thumb = reader.GetString(0);
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
                }
            }
        }

        public string UpdateThumb(int id) 
        {
            try
            {
                con.OpenCon();
                string query = "UPDATE tb_recipe SET thumbnail = @thumb WHERE id_recipe = @id_recipe";
                SqlCommand com = new SqlCommand(query, con.myConnection);
                com.Parameters.AddWithValue("thumb", thumbnail);
                com.Parameters.AddWithValue("id_recipe", id);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    flag = "successed";
                    AdminMaster.alert = "success";
                    AdminMaster.msg = "Thumbnail updated success";
                }
                else
                {
                    flag = "failed";
                    AdminMaster.alert = "warning";
                    AdminMaster.msg = "Thumbnail updated failed";
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
                }
            }
            return flag;
        }

        public string LoveRecipe(int id) 
        {
            try
            {
                con.OpenCon();
                string query = "INSERT INTO tb_loved (id_member, id_recipe, loved_at) VALUES (@id_member, @id_recipe, @loved_at)";
                SqlCommand com = new SqlCommand(query, con.myConnection);
                com.Parameters.AddWithValue("id_member", GlobalVariable.memberId);
                com.Parameters.AddWithValue("id_recipe", id);
                com.Parameters.AddWithValue("loved_at", DateTime.Now);
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

        public void ShowLove(int id) 
        {
            try
            {
                con.OpenCon();
                string query = "SELECT r.id_recipe, r.name, r.thumbnail, r.rating FROM tb_loved AS l JOIN tb_recipe AS r ON l.id_recipe = r.id_recipe WHERE l.id_member = @id";
                SqlCommand com = new SqlCommand(query, con.myConnection);
                com.Parameters.AddWithValue("id", id);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    RecipeInfoList ri = new RecipeInfoList
                    {
                        id = reader.GetInt32(0),
                        name = reader.GetString(1),
                        thumbnail = reader.GetString(2),
                        rating = reader.GetDouble(3),
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
                }
            }
        }

        public string DeleteRecipe (int id) 
        {
            try
            {
                con.OpenCon();
                string query = "DELETE FROM tb_recipe WHERE id_recipe = @id";
                SqlCommand com = new SqlCommand(query, con.myConnection);
                com.Parameters.AddWithValue("id", id);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    flag = "successed";
                    AdminMaster.alert = "success";
                    AdminMaster.msg = "Data deleted success";
                }
                else
                {
                    flag = "failed";
                    AdminMaster.alert = "warning";
                    AdminMaster.msg = "Data deleted failed";
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