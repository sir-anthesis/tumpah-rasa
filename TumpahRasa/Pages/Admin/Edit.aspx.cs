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
        public int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                    id = Convert.ToInt32(Request.QueryString["id"])
                        ;
                    // Create a new instance of the Client class
                    Recipe rc = new Recipe();

                    // Call the GetAClient method to populate the Client object with data
                    rc.GetARecipe(id);

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

            Recipe rc = new Recipe();
            rc.name = name;
            rc.description = description;
            rc.UpdateRecipe(id);
        }
    }
}