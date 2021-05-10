using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPage.admin
{
    public partial class registration : System.Web.UI.Page
    {
        localhost.WebService service = new localhost.WebService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string reserve = Request.QueryString["reserve"];

                if (reserve != null)
                {
                    string[][] users = service.getUsers();
                    for (int i = 0; i < users.Count(); i++)
                    {
                        DropDownList1.Items.Add(users[i][0]);
                    }
                }
                else
                {
                    Response.Redirect("/admin/reserves.aspx");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            service.insertStudent(DropDownList1.SelectedItem.Text, Request.QueryString["reserve"]);
        }
    }
}