using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TumpahRasa.Models;

namespace TumpahRasa.Pages.Admin
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Create a new instance of the Client class
                Recipe rc = new Recipe();

                // Call the GetAClient method to populate the Client object with data
                rc.GetARecipe(GlobalVariable.admin_recipe_selected);

                // RegisterStartupScript to execute JavaScript to set input values
                string script = string.Format(
                  @"<script>
                      $(document).ready(function () {{
                          $('#name').val('{0}');
                          $('#summernote').summernote();
                          var content = '{1}';
                          $('#summernote').summernote('code', decodeHtml(content));
                      }});

                      // Function to decode HTML entities
                      function decodeHtml(html) {{
                          var txt = document.createElement('textarea');
                          txt.innerHTML = html;
                          return txt.value;
                      }}
                    </script>",
                    rc.name, rc.description);

                if (!ClientScript.IsStartupScriptRegistered("SetInputValues"))
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "SetInputValues", script);
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = Request.Form["name"];
            string description = Request.Form["description"];

            HttpPostedFile postedFile = Request.Files["thumb"];
            string fileName = Path.GetFileName(postedFile.FileName);
            string uploadDirectory = "..\\..\\App_Themes\\RecipeTheme\\thumbs\\";
            string filePath = Path.Combine(uploadDirectory, fileName);

            Recipe rc = new Recipe();
            rc.name = name;
            rc.description = description;
            rc.thumbnail = filePath;

            if (rc.UpdateRecipe(GlobalVariable.admin_recipe_selected) == "successed")
            {
                postedFile.SaveAs(Server.MapPath("~/") + Path.Combine("App_Themes", "RecipeTheme", "thumbs", fileName));
            }
        }
    }
}