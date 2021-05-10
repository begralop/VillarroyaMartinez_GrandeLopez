using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SQLite;
using System.Collections;

namespace SOAP
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        public SQLiteConnection createConnection()
        {
            String dbPath = Server.MapPath("~/dbHotel.db");
            SQLiteConnection conn = new SQLiteConnection("DataSource = " + dbPath + "; Version = 3; ");
            return conn;
        }

        [WebMethod]
        public ArrayList login(string userName, string pass)
        {
            SQLiteConnection conn = createConnection();
            conn.Open();

            String query = "SELECT name,username,type FROM users WHERE username = '" + userName + "' AND password = '" + pass + "';";
            Console.WriteLine(query);
            SQLiteCommand comm = new SQLiteCommand(query, conn);
            SQLiteDataReader reader = comm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            conn.Close();

            ArrayList data = new ArrayList();

            if (dt.Rows.Count != 0)
            {
                data.Add(true);
                string role = userName;
                if (role.Contains("admin"))
                {
                    data.Add("admin");
                }
                else
                {
                    data.Add("student");
                }
                return data;
            }
            else
            {
                data.Add(false);
                data.Add("null");
            }
            return data;
        }

        [WebMethod]
        public ArrayList getUserData(string userName)
        {
            SQLiteConnection conn = createConnection();
            conn.Open();

            String query = "SELECT name,username,type FROM users WHERE username = '" + userName + "';";
            Console.WriteLine(query);
            SQLiteCommand comm = new SQLiteCommand(query, conn);
            SQLiteDataReader reader = comm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            conn.Close();
            ArrayList data = new ArrayList();

            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows[0].ItemArray.Count(); i++)
                {
                    data.Add(dt.Rows[0][i]);
                }
                return data;
            }

            return data;
        }
    }
}
