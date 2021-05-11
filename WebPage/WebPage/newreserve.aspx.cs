using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPage.admin
{
    public partial class newreserve : System.Web.UI.Page
    {
        localhost.WebService service = new localhost.WebService();

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
            string user = Request["userid"];
            string username = Request["roomnameid"];
            string password = Request["idcard"];
            string date = Request["dateid"];

            //service.(username, password, user, "client");

            Response.Redirect("index.aspx");
        }
    }
}