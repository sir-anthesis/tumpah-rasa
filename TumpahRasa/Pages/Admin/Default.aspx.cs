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
                // Call the ShowClient method to populate cil list
                rc.ShowRecipe();

                // Bind the cil list to the repeater
                RecipeRepeater.DataSource = rc.ril;
                RecipeRepeater.DataBind();

                Response.Write(tt);
            }
        }

        protected void Edit_Click(object sender, EventArgs e) 
        {
            Button button = (Button)sender;
            int id_recipe = Convert.ToInt32(button.CommandArgument);
            GlobalVariable.recipe_selected = id_recipe;
            Response.Redirect("Edit.aspx");
        }
    }
}