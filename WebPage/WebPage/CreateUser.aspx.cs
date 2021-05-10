using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data.SQLite;

namespace WebPage
{
    public partial class CreateUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String dbPath = Server.MapPath("~/db.db");
            SQLiteConnection conn = new SQLiteConnection("DataSource = " + dbPath + "; Version = 3; ");
            conn.Open();

            String userName = TextBox1.Text;
            String password = TextBox2.Text;

            String query = "INSERT INTO Users VALUES('" + userName + "','" + password + "'); ";
            Console.WriteLine(query);
            SQLiteCommand comm = new SQLiteCommand(query, conn);

            SQLiteDataAdapter da = new SQLiteDataAdapter();
            da.InsertCommand = comm;
            da.InsertCommand.ExecuteNonQuery();

            Response.Redirect("login.aspx");
        }
    }
}