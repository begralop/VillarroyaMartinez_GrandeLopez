using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPage
{
    public partial class edit_reserve : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

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