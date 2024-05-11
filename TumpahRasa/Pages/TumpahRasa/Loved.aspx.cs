using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TumpahRasa.Models;

namespace TumpahRasa.Pages.TumpahRasa
{
    public partial class Loved : System.Web.UI.Page
    {
        Recipe rc = new Recipe();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Call the ShowClient method to populate cil list
                rc.ShowLove(GlobalVariable.memberId);

                // Bind the cil list to the repeater
                LovedRepeater.DataSource = rc.ril.Take(3);
                LovedRepeater.DataBind();
            }
        }
    }
}