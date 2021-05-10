using System;
using WebPage.localhost;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;
using System.Web.UI.HtmlControls;

namespace WebPage.admin
{
    public partial class users : System.Web.UI.Page
    {
        localhost.WebService service = new localhost.WebService();
        protected void Page_Load(object sender, EventArgs e)
        {
            string[][] users = service.getUsers();

            HtmlTableRow row = new HtmlTableRow();
            HtmlTableCell cell = new HtmlTableCell();

            for (int i = 0; i < users.Count(); i++)
            {
                row = new HtmlTableRow();
                for (int j = 0; j < users[i].Count(); j++)
                {
                    cell = new HtmlTableCell();
                    if (j == 0)
                    {
                        HyperLink link1 = new HyperLink();
                        link1.Text = users[i][0];
                        link1.NavigateUrl = "/admin/updateuser.aspx?username=" + users[i][0];
                        cell.Controls.Add(link1);
                    }
                    else
                    {
                        cell.InnerText = users[i][j];
                        cell.Attributes.Add("class", "d-none d-sm-table-cell");
                    }
                    row.Cells.Add(cell);
                }
                tableContent.Rows.Add(row);
            }
        }
    }
}