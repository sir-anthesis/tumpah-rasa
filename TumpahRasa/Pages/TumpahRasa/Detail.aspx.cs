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
        public string test = "asdasd";
        public string name;
        public string thumbnail;
        public string created_at;
        public float rating;
        public string description;


        Recipe rc = new Recipe();
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check if the 'id' parameter exists in the query string
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
        }
    }
}