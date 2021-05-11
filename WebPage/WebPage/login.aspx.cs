using WebPage.localhost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data.SQLite;
using System.Data;
using System.Collections;

namespace WebPage
{
    public partial class Login : System.Web.UI.Page
    {
        WebService service = new WebService();
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            String userName = TextBox1.Text;
            String password = TextBox2.Text;
            System.Console.Write("hola");
            System.Diagnostics.Debug.WriteLine("Antes de peticion");
            var response = service.login(userName, password);

            
            bool responseState = (bool)response.ElementAt(0);

            System.Diagnostics.Debug.WriteLine("Respuesta: " + responseState);
            

            System.Diagnostics.Debug.WriteLine("Antes de if");
            if (responseState)
            {
                string userType = (string)response.ElementAt(1);
                System.Diagnostics.Debug.WriteLine("Despues de if");
                FormsAuthentication.SetAuthCookie(userName, true);
                if (userType == "client")
                {
                    TextBox1.Text = response.ElementAt(0).ToString()+", "+ response.ElementAt(1).ToString();
                  //  Response.Redirect("index.aspx");
                }
                else
                {
                    TextBox1.Text = response.ElementAt(0).ToString() + ", " + response.ElementAt(1).ToString();
                    Response.Redirect("dashboard.aspx");
                   // Response.Redirect("~/Login.aspx?ReturnPath=" + Server.UrlEncode(Request.Url.AbsoluteUri));
                }
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

      

    }
}