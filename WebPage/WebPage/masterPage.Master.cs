using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPage
{
    public partial class masterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink1.Text = HttpContext.Current.User.Identity.Name;
            if (HyperLink1.Text.Contains("admin"))
            {
                HyperLink1.NavigateUrl = "admin/updateuser.aspx?username=" + HttpContext.Current.User.Identity.Name;
            }
            else
            {
                HyperLink1.NavigateUrl = "student/profile.aspx";
                HyperLink2.Attributes.Add("class", "nav-link active");
                HyperLink3.Visible = false;
                HyperLink4.Visible = false;
        }

            if (Request.Path.EndsWith("dashboard.aspx"))
            {
                HyperLink2.Attributes.Add("class", "nav-link active");
            }

            if (Request.Path.EndsWith("users.aspx") | Request.Path.EndsWith("newuser.aspx") | Request.Path.EndsWith("updateuser.aspx"))
            {
                HyperLink3.Attributes.Add("class", "nav-link active");
            }

            if (Request.Path.EndsWith("subjects.aspx") | Request.Path.EndsWith("newsubject.aspx") | Request.Path.EndsWith("updatesubject.aspx") | Request.Path.EndsWith("registration.aspx"))
            {

                HyperLink4.Attributes.Add("class", "nav-link active");
            }


        }
    }
}