using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TumpahRasa.Pages.TumpahRasa
{
    public partial class TumphRasa : System.Web.UI.MasterPage
    {
        public static string msg;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["log_stat"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else if ((string)Session["role"] == "admin")
            {
                Response.Redirect("~/Pages/Admin/Default.aspx");
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            GlobalVariable.memberId = 0;
            Response.Redirect("Login.aspx");
        }
    }
}