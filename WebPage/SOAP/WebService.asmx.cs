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

           
            ArrayList datazo = new ArrayList();
            if (dt.Rows.Count != 0)
            {
                datazo.Add(true);
                datazo.Add(dt.Rows[0][2]);
            }
            else
            {
                datazo.Add(false);
            }
            return datazo;
            
           
            
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

        [WebMethod]
        public void createUser(string name, string username, string pass, string type)
        {
            SQLiteConnection conn = createConnection();
            conn.Open();

            String query = "INSERT INTO users (name,username,password,type) VALUES('" + name + "','" + username + "','" + pass + "' , '" + type + "'); ";
            Console.WriteLine(query);
            SQLiteCommand comm = new SQLiteCommand(query, conn);

            SQLiteDataAdapter da = new SQLiteDataAdapter();
            da.InsertCommand = comm;
            da.InsertCommand.ExecuteNonQuery();

            long id = conn.LastInsertRowId;

        }

        [WebMethod]
        public void editUser(string name, string username, string password)
        {
            SQLiteConnection conn = createConnection();
            conn.Open();

            String query = "SELECT * FROM users WHERE username = '" + username + "';";
            Console.WriteLine(query);
            SQLiteCommand comm = new SQLiteCommand(query, conn);
            SQLiteDataReader reader = comm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            conn.Close();

            if (dt.Rows.Count != 0)
            {
                long id = (long)dt.Rows[0][0];

                query = "UPDATE 'personal-info' SET name = '" + name + "', username = '" + username + "', password = '" + password + "' WHERE id = " + id + "; ";
                Console.WriteLine(query);

                conn.Open();
                comm = new SQLiteCommand(query, conn);

                SQLiteDataAdapter daPersonalInfo = new SQLiteDataAdapter();

                daPersonalInfo.UpdateCommand = comm;
                daPersonalInfo.UpdateCommand.ExecuteNonQuery();
                conn.Close();
            }
        }

        [WebMethod]
        public void deleteUser(string username)
        {
            SQLiteConnection conn = createConnection();
            conn.Open();

            String query = "DELETE FROM users WHERE username = '" + username + "'; ";
            Console.WriteLine(query);

            SQLiteCommand comm = new SQLiteCommand(query, conn);

            SQLiteDataAdapter da = new SQLiteDataAdapter();
            da.DeleteCommand = comm;
            da.DeleteCommand.ExecuteNonQuery();
        }

        [WebMethod]
        public void createReserve(string user, string roomname, int idCard, string date)
        {
            SQLiteConnection conn = createConnection();
            conn.Open();

            String query = "INSERT INTO reserve (user, roomname, idCard, date) VALUES('" + user + "','" + roomname + "','" + idCard + "','" + date + "'); ";
            Console.WriteLine(query);

            SQLiteCommand comm = new SQLiteCommand(query, conn);

            SQLiteDataAdapter da = new SQLiteDataAdapter();
            da.InsertCommand = comm;
            da.InsertCommand.ExecuteNonQuery();
            conn.Close();
        }

        [WebMethod]
        public ArrayList getUserReserves(string username)
        {
            SQLiteConnection conn = createConnection();
            conn.Open();

            String query = "SELECT roomname,user,date FROM reserve WHERE user = '" + username + "';";
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

        [WebMethod]
        public void editReserve(string idReserve, string user, string roomname, int idCard, string date)
        {
            SQLiteConnection conn = createConnection();
            conn.Open();

            String query = "SELECT * FROM reserve WHERE id = '" + idReserve + "';";
            Console.WriteLine(query);
            SQLiteCommand comm = new SQLiteCommand(query, conn);
            SQLiteDataReader reader = comm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            conn.Close();

            if (dt.Rows.Count != 0)
            {
                long id = (long)dt.Rows[0][0];

                query = "UPDATE 'reserve' SET user = '" + user + "', roomname = '" + roomname + "', idCard = '" + idCard + "', date = '" + date + "' WHERE id = " + idReserve + "; ";
                Console.WriteLine(query);

                conn.Open();
                comm = new SQLiteCommand(query, conn);

                SQLiteDataAdapter daPersonalInfo = new SQLiteDataAdapter();

                daPersonalInfo.UpdateCommand = comm;
                daPersonalInfo.UpdateCommand.ExecuteNonQuery();
                conn.Close();
            }
        }

        [WebMethod]
        public void deleteReserve(int id)
        {
            SQLiteConnection conn = createConnection();
            conn.Open();

            String query = "DELETE FROM reserve WHERE id = '" + id + "'; ";
            Console.WriteLine(query);

            SQLiteCommand comm = new SQLiteCommand(query, conn);

            SQLiteDataAdapter da = new SQLiteDataAdapter();
            da.DeleteCommand = comm;
            da.DeleteCommand.ExecuteNonQuery();
        }
    }
}