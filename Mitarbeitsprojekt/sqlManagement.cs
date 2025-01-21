using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO.Packaging;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mitarbeitsprojekt
{
    public class sqlManagement
    {
        static SqlConnection sqlConnection;
        static string con;
        static string CreateDatabaseName;
        static string selectedDatabase;
        public static List<string> databases { get; set; }
        public static List<string> tables { get; set; }

        public static void SQLConn(string server, string password, string user, string SSPI)
        {
            Login login = new Login();


            if (SSPI == "true")
            {
                con = "server=" + server + "; Integrated Security=true;";
            }
            else
            {
                con = "server=" + server + "; Integrated Security=false; user=" + user + "password=" + password;

            }

            SqlDatabases(con);
        }


        public static void SqlDatabases(string connection)
        {
            databases = new List<string>();

            SqlConnection sqlConnection = new SqlConnection(connection);
            sqlConnection.Open();

            SqlCommand sqlCommandDatabases = new SqlCommand("Select name from sys.databases", sqlConnection);

            SqlDataReader sqlDataReader = sqlCommandDatabases.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                string message = "Verbindung erfolgreich";
                MessageBox.Show(message);
                con = connection;
            }
            else
            {
                string message = "Verbindung fehlgeschlagen";
                MessageBox.Show(message);
            }

            while (sqlDataReader.Read())
            {
                databases.Add(sqlDataReader[0].ToString());
            }

            sqlConnection.Close();
        }

        public static void DeleteDatabase(string SelectedDatabase, string databaseToDelete)
        {
            SqlConnection sqlConnection = new SqlConnection(con);
            sqlConnection.Open();

            SqlCommand sqlCommandDeleteDatabase = new SqlCommand($"DROP DATABASE  [{databaseToDelete}]", sqlConnection);

            sqlCommandDeleteDatabase.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public static void CreateDatabase(string SelectedServer, string NewDatabaseName)
        {
            SqlConnection sqlConnection = new SqlConnection(con);
            sqlConnection.Open();

            MessageBox.Show(con);

            SqlCommand sqlCommandCreateDatabase = new SqlCommand($"CREATE DATABASE  [{NewDatabaseName}]", sqlConnection);
            sqlCommandCreateDatabase.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public static void SqlTables(string con)
        {
            DatabaseForm form = new DatabaseForm();
            tables = new List<string>();


            sqlConnection = new SqlConnection(con);


            sqlConnection.Open();


        }


    }
}
