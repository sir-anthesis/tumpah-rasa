using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TumpahRasa.Models;

namespace TumpahRasa.Pages.Admin
{
    public partial class Default : System.Web.UI.Page
    {
        public static string tt;

        Recipe rc = new Recipe();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AdminMaster.msg = "";
                AdminMaster.alert = "";

                // Call the ShowClient method to populate cil list
                rc.ShowRecipe();

                // Bind the cil list to the repeater
                RecipeRepeater.DataSource = rc.ril;
                RecipeRepeater.DataBind();

                Response.Write(tt);
            }
        }

        protected void Delete_Click(object sender, EventArgs e) 
        {
            Button button = (Button)sender;
            int id = Convert.ToInt32(button.CommandArgument);

            Response.Write("<script> confirm('Are you sure you want to delete this recipe?') </script>");

            string msg = rc.DeleteRecipe(id);

            // Redirect to Loved.aspx after 2 seconds
            Response.Write("<script>setTimeout(function() { window.location.href = 'Default.aspx'; }, 2000);</script>");

        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            GlobalVariable.adminId = 0;
            Response.Redirect("~/Pages/TumpahRasa/Login.aspx");
        }
    }
}