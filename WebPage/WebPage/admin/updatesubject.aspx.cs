using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPage.admin
{
    public partial class updatesubject : System.Web.UI.Page
    {
        localhost.WebService service = new localhost.WebService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string subjectTitle = Request.QueryString["title"];

                if (subjectTitle != null)
                {
                    var response = service.getSubject(subjectTitle);

                    string title = (string)response.ElementAt(0);
                    Int64 credits = (Int64)response.ElementAt(1);

                    NameTextbox.Text = title;
                    CreditsTextBox.Text = credits.ToString();
                }
                else
                {
                    Response.Redirect("/admin/subjects.aspx");
                }
            }

            HyperLink1.NavigateUrl = "/admin/registration.aspx?subject=" + Request.QueryString["title"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            service.deleteSubject(Request.QueryString["title"]);
            Response.Redirect("/admin/subjects.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string title = NameTextbox.Text;
            int credits = Convert.ToInt32(CreditsTextBox.Text);

            service.editSubject(Request.QueryString["title"],title, credits);
            Response.Redirect("/admin/updatesubject.aspx?title="+title);

        }
    }
}