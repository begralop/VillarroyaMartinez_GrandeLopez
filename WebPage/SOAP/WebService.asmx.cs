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
            String dbPath = Server.MapPath("~/db.db");
            SQLiteConnection conn = new SQLiteConnection("DataSource = " + dbPath + "; Version = 3; ");
            return conn;
        }

        [WebMethod]
        public ArrayList login(string userName, string pass)
        {
            SQLiteConnection conn = createConnection();
            conn.Open();

            String query = "SELECT * FROM users WHERE username = '" + userName + "' AND password = '" + pass + "';";
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

            String query = "SELECT username, name, surname FROM users, 'personal-info' WHERE username = '" + userName + "' AND users.id = userid;";
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
        public void createUser(string user, string pass, string name, string surname)
        {
            SQLiteConnection conn = createConnection();
            conn.Open();

            String query = "INSERT INTO users (username,password) VALUES('" + user + "','" + pass + "'); ";
            Console.WriteLine(query);
            SQLiteCommand comm = new SQLiteCommand(query, conn);

            SQLiteDataAdapter da = new SQLiteDataAdapter();
            da.InsertCommand = comm;
            da.InsertCommand.ExecuteNonQuery();

            long id = conn.LastInsertRowId;

            query = "INSERT INTO 'personal-info' (name,surname,userid) VALUES('" + name + "','" + surname + "','" + id + "'); ";
            Console.WriteLine(query);
            comm = new SQLiteCommand(query, conn);

            SQLiteDataAdapter daPersonalInfo = new SQLiteDataAdapter();

            daPersonalInfo.InsertCommand = comm;
            daPersonalInfo.InsertCommand.ExecuteNonQuery();
        }

        [WebMethod]
        public void editUser(string user, string name, string surname)
        {
            SQLiteConnection conn = createConnection();
            conn.Open();

            String query = "SELECT * FROM users WHERE username = '" + user + "';";
            Console.WriteLine(query);
            SQLiteCommand comm = new SQLiteCommand(query, conn);
            SQLiteDataReader reader = comm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            conn.Close();

            if (dt.Rows.Count != 0)
            {
                long id = (long)dt.Rows[0][0];

                query = "UPDATE 'personal-info' SET name = '" + name + "', surname = '" + surname + "' WHERE userid = " + id + "; ";
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
        public void deleteUser(string user)
        {
            SQLiteConnection conn = createConnection();
            conn.Open();

            String query = "DELETE FROM users WHERE username = '" + user + "'; ";
            Console.WriteLine(query);

            SQLiteCommand comm = new SQLiteCommand(query, conn);

            SQLiteDataAdapter da = new SQLiteDataAdapter();
            da.DeleteCommand = comm;
            da.DeleteCommand.ExecuteNonQuery();
        }

        [WebMethod]
        public ArrayList getReserve(string title)
        {
            SQLiteConnection conn = createConnection();
            conn.Open();

            String query = "SELECT title,numberReserve FROM reserve WHERE title = '" + title + "';";
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
        public string[][] getReserves()
        {
            SQLiteConnection conn = createConnection();
            conn.Open();

            String query = "SELECT title, numberReserve FROM reserve;";
            Console.WriteLine(query);
            SQLiteCommand comm = new SQLiteCommand(query, conn);
            SQLiteDataReader reader = comm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            conn.Close();

            string[][] x = new string[dt.Rows.Count][];

            for (int j = 0; j < dt.Rows.Count; j++)
            {
                x[j] = new string[4];
                for (int i = 0; i < dt.Rows[j].ItemArray.Count(); i++)
                {
                    x[j][i] = dt.Rows[j][i].ToString();
                }
            }
            return x;

        }

        [WebMethod]
        public void createReserve(string title, int numberReserve)
        {
            SQLiteConnection conn = createConnection();
            conn.Open();

            String query = "INSERT INTO reserve (title, numberReserve) VALUES('" + title + "','" + numberReserve + "'); ";
            Console.WriteLine(query);

            SQLiteCommand comm = new SQLiteCommand(query, conn);

            SQLiteDataAdapter da = new SQLiteDataAdapter();
            da.InsertCommand = comm;
            da.InsertCommand.ExecuteNonQuery();
            conn.Close();
        }

        [WebMethod]
        public void editSubject(string name, string name2, int credits)
        {
            SQLiteConnection conn = createConnection();
            conn.Open();

            String query = "SELECT * FROM subjects WHERE title = '" + name + "';";
            Console.WriteLine(query);
            SQLiteCommand comm = new SQLiteCommand(query, conn);
            SQLiteDataReader reader = comm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            conn.Close();

            if (dt.Rows.Count != 0)
            {
                long id = (long)dt.Rows[0][0];

                query = "UPDATE subjects SET title = '" + name2 + "', credits = '" + credits + "' WHERE id = " + id + "; ";
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
        public void deleteSubject(string title)
        {
            SQLiteConnection conn = createConnection();
            conn.Open();

            String query = "DELETE FROM subjects WHERE title = '" + title + "'; ";
            Console.WriteLine(query);

            SQLiteCommand comm = new SQLiteCommand(query, conn);

            SQLiteDataAdapter da = new SQLiteDataAdapter();
            da.DeleteCommand = comm;
            da.DeleteCommand.ExecuteNonQuery();
        }

        [WebMethod]
        public string[][] getUsers()
        {
            SQLiteConnection conn = createConnection();
            conn.Open();

            String query = "SELECT username, name, surname FROM users, 'personal-info' WHERE users.id = userid;";
            Console.WriteLine(query);
            SQLiteCommand comm = new SQLiteCommand(query, conn);
            SQLiteDataReader reader = comm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            conn.Close();

            string[][] x = new string[dt.Rows.Count][];

            for (int j = 0; j < dt.Rows.Count; j++)
            {
                x[j] = new string[4];
                for (int i = 0; i < dt.Rows[j].ItemArray.Count(); i++)
                {
                    x[j][i] = dt.Rows[j][i].ToString();
                }
            }
            return x;
        }

        [WebMethod]
        public void insertClient(string username, string reserve)
        {
            SQLiteConnection conn = createConnection();
            conn.Open();

            String query = "SELECT id FROM users WHERE username = '" + username + "';";
            Console.WriteLine(query);
            SQLiteCommand comm = new SQLiteCommand(query, conn);
            SQLiteDataReader reader = comm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            conn.Close();

            int idClient;
            int idReserve;

            if (dt.Rows.Count != 0)
            {
                idClient = Convert.ToInt32(dt.Rows[0][0]);

                conn.Open();

                String query2 = "SELECT id FROM reserve WHERE title = '" + reserve + "';";
                Console.WriteLine(query2);
                SQLiteCommand comm2 = new SQLiteCommand(query2, conn);
                SQLiteDataReader reader2 = comm2.ExecuteReader();
                DataTable dt2 = new DataTable();
                dt2.Load(reader2);

                conn.Close();

                if (dt2.Rows.Count != 0)
                {
                    idReserve = Convert.ToInt32(dt2.Rows[0][0]);

                    conn.Open();

                    String query3 = "INSERT INTO studentsubjects (idstudent, idsubject) VALUES('" + idClient + "','" + idReserve + "'); ";
                    Console.WriteLine(query);
                    SQLiteCommand comm3 = new SQLiteCommand(query3, conn);

                    SQLiteDataAdapter da3 = new SQLiteDataAdapter();
                    da3.InsertCommand = comm3;
                    da3.InsertCommand.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        [WebMethod]
        public ArrayList getStudentSubjects(string username)
        {
            SQLiteConnection conn = createConnection();
            conn.Open();

            String query = "SELECT id FROM users WHERE username = '" + username + "';";
            Console.WriteLine(query);
            SQLiteCommand comm = new SQLiteCommand(query, conn);
            SQLiteDataReader reader = comm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            conn.Close();

            int idStudent;
            ArrayList data = new ArrayList();


            if (dt.Rows.Count != 0)
            {
                idStudent = Convert.ToInt32(dt.Rows[0][0]);

                conn.Open();

                String query2 = "SELECT idsubject FROM studentsubjects WHERE idstudent = '" + idStudent + "';";
                Console.WriteLine(query2);
                SQLiteCommand comm2 = new SQLiteCommand(query2, conn);
                SQLiteDataReader reader2 = comm2.ExecuteReader();
                DataTable dt2 = new DataTable();
                dt2.Load(reader2);

                conn.Close();

                if (dt2.Rows.Count != 0)
                {
                    conn.Open();

                    for (int i = 0; i < dt2.Rows.Count; i++)
                    {
                        String query3 = "SELECT title FROM subjects WHERE id = '" + dt2.Rows[i][0] + "';";
                        Console.WriteLine(query3);
                        SQLiteCommand comm3 = new SQLiteCommand(query3, conn);
                        SQLiteDataReader reader3 = comm3.ExecuteReader();
                        DataTable dt3 = new DataTable();
                        dt3.Load(reader3);

                        if (dt3.Rows.Count != 0)
                        {
                            data.Add(dt3.Rows[0][0]);
                        }
                    }
                    conn.Close();

                    return data;
                }
                return data;
            }
            return data;
        }
    }
}
