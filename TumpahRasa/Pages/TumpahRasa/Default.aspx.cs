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
        Recipe rc = new Recipe();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Call the ShowClient method to populate cil list
                rc.ShowRecipe();

                // Bind the cil list to the repeater
                JumbotronRepeater.DataSource = rc.ril;
                JumbotronRepeater.DataBind();
                RecipeRepeater.DataSource = rc.ril;
                RecipeRepeater.DataBind();

                Response.Write(tt);
            }
        }
    }
}