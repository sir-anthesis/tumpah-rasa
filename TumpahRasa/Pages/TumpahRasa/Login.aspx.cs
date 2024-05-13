using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

        protected void BtnRegister(object sender, EventArgs e) 
        {
            string name = Request.Form["rname"];
            string email = Request.Form["remail"];
            string password = Request.Form["rpw"];

            ac.email = email;
            ac.username = name;
            ac.password = password;

            string msg = ac.CreateMember();

            Response.Write(msg);
        }

        protected void BtnLogin(object sender, EventArgs e)
        {
            string name = Request.Form["lname"];
            string password = Request.Form["lpw"];

            ac.username = name;
            ac.password = password;

            string msg = ac.doLogin();

            if (msg == "member")
            {
                if (checkremember.Checked)
                {
                    Response.Write("remember me checked");
                }
                Response.Write("Login as member");
            }
            else if (msg == "admin")
            {
                if (checkremember.Checked)
                {
                    Response.Write("remember me checked");
                }
                Response.Write("login as admin");
            }
            else
            {
                Response.Write(msg);
                Response.Write("name = " + name);
                Response.Write("pw = " + password);
            }

        }
    }
}