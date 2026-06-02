//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class RealTimeConnectionString1
//    {
//        class DataBaseConnection
//        {
//            string connection;
//            SqlConnection conn;
            
//            public DataBaseConnection(string sqlconnection)
//            {
//                connection= sqlconnection;
//                conn= new SqlConnection(connection);
//            }

//            public void OpenConnection()
//            {
//                try
//                {
//                    conn.Open();
//                    Console.WriteLine("Connection is opend!");
//                }
//                catch(Exception e)
//                {
//                    Console.WriteLine(e.Message );
//                }
//            }

//            public void CloseConnection() 
//            {
//                if(conn.State == System.Data.ConnectionState.Open)
//                {
//                    conn.Close();
//                    Console.WriteLine("Connection is closed");
//                }
//            }

//        }
//        static void Main(string[] args)
//        {
//            string conn =  "Data Source=SAM\\SQLEXPRESS;Integrated Security=True;Initial Catalog=Login ";
//            DataBaseConnection db = new DataBaseConnection(conn);

//            db.OpenConnection();
//            db.CloseConnection(); 

//        }
//    }
//}
