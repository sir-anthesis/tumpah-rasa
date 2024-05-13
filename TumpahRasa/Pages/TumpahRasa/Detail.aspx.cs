using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TumpahRasa.Models;

namespace TumpahRasa.Pages.TumpahRasa
{
    public partial class Detail : System.Web.UI.Page
    {
        public int id;
        public string name;
        public string thumbnail;
        public string created_at;
        public double rating;
        public string description;
        public static string tt;

        Recipe rc = new Recipe();
        Comment cm = new Comment();

        protected void Page_Load(object sender, EventArgs e)
        {
            // Showing the Detail Recipe
            if (Request.QueryString["id"] != null)
            {
                // Get the value of the 'id' parameter
                id = Convert.ToInt32(Request.QueryString["id"]);

                rc.GetARecipe(id);
                name = rc.name;
                thumbnail = rc.thumbnail;
                created_at = rc.created_at;
                rating = rc.rating;

                string raw_description = rc.description;
                description = HttpUtility.HtmlDecode(raw_description);
                DescLiteral.Text = description;
            }

            // Showing the Others Recipe
            rc.ShowRecipe();
            OthersRepeater.DataSource = rc.ril.Take(5);
            OthersRepeater.DataBind();

            // Sowing comments
            cm.ShowComment(id);
            CommentRepeater.DataSource = cm.cil;
            CommentRepeater.DataBind();

            Response.Write(tt);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string alert;
            int rate = Convert.ToInt32(Request.Form["rate"]);
            string comment = Request.Form["cmnt"];

            cm.rate_insert = rate;
            cm.comment = comment;
            if (cm.InsertComment(id) == "successed")
            {
                alert = "alert('" + TumphRasa.msg + "');";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", alert, true);

                // Redirect to Loved.aspx after 1 seconds
                Response.Write("<script>setTimeout(function() { window.location.href = 'Detail.aspx?id=" + id + "'; }, 1000);</script>");
            }
            else if (cm.InsertComment(id) == "failed")
            {
                alert = "alert('" + TumphRasa.msg + "');";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", alert, true);

                // Redirect to Loved.aspx after 1 seconds
                Response.Write("<script>setTimeout(function() { window.location.href = 'Detail.aspx?id=" + id + "'; }, 1000);</script>");
            }
            else
            {
                Response.Write(TumphRasa.msg);
            }
        }
    }
}