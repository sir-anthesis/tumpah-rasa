using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TumpahRasa.Pages.Admin
{
    public partial class AdminMaster : System.Web.UI.MasterPage
    {
        public static string alert = "";
        public static string msg = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["log_stat"] == null)
            {
                Response.Redirect("/Pages/TumpahRasa/Login.aspx");
            }
            else if ((string)Session["role"] == "member")
            {
                Response.Redirect("~/Pages/TumpahRasa/Default.aspx");
            }
        }
    }
}