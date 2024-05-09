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
    public partial class EditThumb : System.Web.UI.Page
    {
        public static string old_thumb;
        public int id;

        Recipe rc = new Recipe();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                id = Convert.ToInt32(Request.QueryString["id"]);
                rc.GetThumbnail(id);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpPostedFile postedFile = Request.Files["thumb"];
            string fileName = Path.GetFileName(postedFile.FileName);
            string uploadDirectory = "..\\..\\App_Themes\\RecipeTheme\\thumbs\\";
            string filePath = Path.Combine(uploadDirectory, fileName);

            Recipe rc = new Recipe();
            rc.thumbnail = filePath;

            if (rc.UpdateThumb(id) == "successed")
            {
                postedFile.SaveAs(Server.MapPath("~/") + Path.Combine("App_Themes", "RecipeTheme", "thumbs", fileName));
            }
        }
    }
}