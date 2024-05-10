using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TumpahRasa.Models;

namespace TumpahRasa.Pages.TumpahRasa
{
    public partial class Default : System.Web.UI.Page
    {
        public static string tt;
        public string msg;
        Recipe rc = new Recipe();
        protected void Page_Load(object sender, EventArgs e)
        {
            msg = "";
            if (!IsPostBack)
            {
                // Call the ShowClient method to populate cil list
                rc.ShowRecipe();

                // Bind the cil list to the repeater
                JumbotronRepeater.DataSource = rc.ril.Take(3);
                JumbotronRepeater.DataBind();
                RecipeRepeater.DataSource = rc.ril;
                RecipeRepeater.DataBind();

                Response.Write(tt);
            }
        }

        protected void BtnLove(object sender, CommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            msg = rc.LoveRecipe(id);

            if (msg != "")
            {
                if (msg == "successed")
                {
                    Response.Write("<script>alert('Added to loved');</script>");
                }
                else if (msg == "failed")
                {
                    Response.Write("<script>alert('Failed added to loved');</script>");
                }
                else
                {
                    Response.Write("<script>alert('" + msg + "');</script>");
                }

                // Redirect to Loved.aspx after 1 seconds (2000 milliseconds)
                Response.Write("<script>setTimeout(function() { window.location.href = 'Loved.aspx'; }, 1000);</script>");
            }
            
        }
    }
}