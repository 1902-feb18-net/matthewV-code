using System;
using System.Data.SqlClient;

namespace adoNetConnected
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //bad idea to have username + password in code, insecure
            var conString = "Server = tcp:matthew1995sql.database.windows.net,1433; Initial Catalog = chinook; Persist Security Info = False; User ID = { your_username }; Password ={ your_password}; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;";

            SqlConnection connection = new SqlConnection();
        }
    }
}
