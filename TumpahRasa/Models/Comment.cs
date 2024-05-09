using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using TumpahRasa.Pages.Admin;
using TumpahRasa.Pages.TumpahRasa;

namespace TumpahRasa.Models
{
    public class Comment
    {
        public List<CommentList> cil = new List<CommentList>();

        public string comment, name;
        public int rate_insert;

        string flag;

        Connection con = new Connection();

        public string InsertComment(int id) 
        {
            try
            {
                con.OpenCon();
                string query = "INSERT INTO tb_comment (id_member, id_recipe, comment, rating, created_at) VALUES (@id_member, @id_recipe, @comment, @rating, @created_at)";
                SqlCommand com = new SqlCommand(query, con.myConnection);
                com.Parameters.AddWithValue("id_member", GlobalVariable.memberId);
                com.Parameters.AddWithValue("id_recipe", id);
                com.Parameters.AddWithValue("comment", comment);
                com.Parameters.AddWithValue("rating", rate_insert);
                com.Parameters.AddWithValue("created_at", DateTime.Now);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    flag = "successed";
                    TumphRasa.msg = "Comment added success";
                }
                else
                {
                    flag = "failed";
                    TumphRasa.msg = "Comment added failed";
                }

            }
            catch (Exception ex)
            {
                flag = ex.Message;
                TumphRasa.msg = flag;
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

        public void ShowComment(int id)
        {
            try
            {
                con.OpenCon();
                string query = "SELECT C.id_comment, M.name AS member_name, C.comment, C.rating, C.created_at FROM tb_comment AS C INNER JOIN tb_member AS M ON C.id_member = M.id_member WHERE C.id_recipe = @id ORDER BY C.created_at DESC";
                SqlCommand com = new SqlCommand(query, con.myConnection);
                com.Parameters.AddWithValue("id", id);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    CommentList cl = new CommentList
                    {
                        name = reader.GetString(1),
                        comment = reader.GetString(2),
                        rate = reader.GetInt32(3)
                    };
                    cil.Add(cl);
                }

            }
            catch (Exception ex)
            {
                Detail.tt = "er : " + ex;
            }
            finally
            {
                if (con.myConnection.State == ConnectionState.Open)
                {
                    con.myConnection.Close();
                }
            }
        }
    }

    public class CommentList
    {
        public int id { get; set; }
        public string name { get; set; }
        public string comment { get; set; }
        public int rate { get; set; }
    }
}