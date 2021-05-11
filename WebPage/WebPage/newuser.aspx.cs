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

        void Page_Load(Object sender, EventArgs e)
        {

            Button1.Click += new EventHandler(this.createuser_click);

        }

        void createuser_click(Object sender, EventArgs e)
        {
            string user = user_id.Value.ToString();
            string username = username_id.Value.ToString();
            string password = password_id.Value.ToString();

            service.createUser(username, password, user);

            Response.Redirect("/admin/index.aspx");

        }

    }
}