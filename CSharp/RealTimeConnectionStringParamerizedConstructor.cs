using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class DataBaseConnection
    {
        string ConnectionString;
        SqlConnection connection;

        public DataBaseConnection(string connString)
        {
            ConnectionString=connString;
            connection=new SqlConnection(ConnectionString);
        }

        public void OpenConnection()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Database Connection Opend Succesfully");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void CloseConnection() 
        {
            if(connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                Console.WriteLine("connection is closed! ");
            }
        }
    } 

    internal class RealTimeConnectionStringParamerizedConstructor
    {
        static void Main(string[] args)
        {
            string connString = "Server=.;InitialCatalog=MYDB;Integrated Security=True";
            DataBaseConnection db = new DataBaseConnection(connString);
            db.OpenConnection();
            db.CloseConnection();
        }
    }
}
