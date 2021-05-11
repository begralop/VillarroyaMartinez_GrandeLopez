using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebPage.localhost;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Net;
using System.IO;

namespace WebPage.client
{
    public partial class profile : System.Web.UI.Page
    {
        localhost.WebService service = new localhost.WebService();
        protected void Page_Load(object sender, EventArgs e)
        {

            System.Diagnostics.Debug.WriteLine(User.Identity.Name);
            if (User.Identity.Name != null)
            {
                var response = service.getUserData(User.Identity.Name);

                string userName = (string)response.ElementAt(0);
                string name = (string)response.ElementAt(1);
                string surname = (string)response.ElementAt(2);

                UsernameTextBox.Text = userName;
                NameTextBox.Text = name;
                SurnameTextBox.Text = surname;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string strContents = null;

            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://localhost:52064/WebService.asmx/getUserData?userName="+ User.Identity.Name);
            req.UserAgent = "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; .NET4.0C; .NET4.0E)";
            using (var resp = req.GetResponse())
            {
                strContents = new StreamReader(resp.GetResponseStream()).ReadToEnd();
            }

            req = (HttpWebRequest)HttpWebRequest.Create("http://localhost:52064/WebService.asmx/getStudentSubjects?userName=" + User.Identity.Name);

            using (var resp = req.GetResponse())
            {
                strContents += new StreamReader(resp.GetResponseStream()).ReadToEnd();
            }

            string attachment = "attachment; filename=profile.xml";
            Response.ClearContent();
            Response.ContentType = "application/xml";
            Response.AddHeader("content-disposition", attachment);
            Response.Write(strContents);
            Response.End();
        }
    }
}