using WebPage.localhost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPage
{
    public partial class newuser : System.Web.UI.Page
    {

        localhost.WebService service = new localhost.WebService();

        void Page_Load(object sender, EventArgs e)
        {

         
        }

        protected void onClick2(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
            string user = Request["userid"];
             string username = Request["usernameid"];
             string password = Request["password"];

             service.createUser(username, password, user, "client");

             Response.Redirect("index.aspx");

        }

    }
}