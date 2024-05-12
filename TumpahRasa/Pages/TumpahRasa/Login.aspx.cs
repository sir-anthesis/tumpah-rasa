using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TumpahRasa.Models;

namespace TumpahRasa.Pages.TumpahRasa
{
    public partial class Login : System.Web.UI.Page
    {

        Account ac = new Account();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register(object sender, EventArgs e) 
        {
            string name = Request.Form["rname"];
            string email = Request.Form["remail"];
            string password = Request.Form["rpw"];

            ac.email = email;
            ac.name = name;
            ac.password = password;

            string msg = ac.CreateMember();

            Response.Write(msg);
        }
    }
}