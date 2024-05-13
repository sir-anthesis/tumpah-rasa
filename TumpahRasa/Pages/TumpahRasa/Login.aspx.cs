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
                    HttpCookie userinfo = new HttpCookie("userinfo");
                    userinfo["username"] =  name;
                    userinfo.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(userinfo);
                }
                Session["username"] = name;
                Session["log_stat"] = true;
                Session["role"] = "member";
                Response.Redirect("Default.aspx");
            }
            else if (msg == "admin")
            {
                if (checkremember.Checked)
                {
                    HttpCookie userinfo = new HttpCookie("userinfo");
                    userinfo["username"] = name;
                    userinfo.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(userinfo);
                }
                Session["username"] = name;
                Session["log_stat"] = true;
                Session["role"] = "admin";
                Response.Redirect("~/Pages/Admin/Default.aspx");
            }
            else
            {
                Response.Write("<script> alert('" + msg + "'); </script>");

                // Redirect to Loved.aspx after 1 seconds
                Response.Write("<script>setTimeout(function() { window.location.href = 'Login.aspx'; }, 1000);</script>");
            }

        }
    }
}