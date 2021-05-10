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
            string title = NameTextbox.Text;
            int numberReserve = Convert.ToInt32(idTextBox.Text);

            service.createSubject(title,numberReserve);
            Response.Redirect("/admin/subjects.aspx");
        }
    }
}