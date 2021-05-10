using WebPage.localhost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPage.admin
{
    public partial class newuser : System.Web.UI.Page
    {
        localhost.WebService service = new localhost.WebService();

        protected void Button1_Click(object sender, EventArgs e)
        {
            string userName = UsernameTextBox.Text;
            string pass = PasswordTextBox.Text;
            string name = NameTextBox.Text;
            string surname = SurnameTextBox.Text;
            string function = FunctionDropdown.SelectedValue.ToString();

            service.createUser(userName, pass, name, surname);

            Response.Redirect("/admin/users.aspx");
        }
    
    }
}