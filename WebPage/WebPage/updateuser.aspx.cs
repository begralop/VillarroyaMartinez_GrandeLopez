using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebPage.localhost;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WebPage.admin
{
    public partial class updateuser : System.Web.UI.Page
    {
        localhost.WebService service = new localhost.WebService();

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strContents = null;

            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://localhost:52064/WebService.asmx/getUserData?userName=" + User.Identity.Name);
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

        protected void Button2_Click(object sender, EventArgs e)
        {
         
                string user = Request["userid"];
                string username = Request["usernameid"];
                string password = Request["password"];

                service.editUser(username, password, user);

                Response.Redirect("index.aspx");

          
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string userName = Request.QueryString["username"];

            service.deleteUser(userName);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string strContents = null;

            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://localhost:52064/WebService.asmx/getUserReserves");
            req.UserAgent = "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; .NET4.0C; .NET4.0E)";
            using (var resp = req.GetResponse())
            {
                strContents = new StreamReader(resp.GetResponseStream()).ReadToEnd();
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