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
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

            if (rc.InsertRecipe() == "successed")
            {
                postedFile.SaveAs(Server.MapPath("~/") + Path.Combine("App_Themes", "RecipeTheme", "thumbs", fileName));
            }

        }
    }
}