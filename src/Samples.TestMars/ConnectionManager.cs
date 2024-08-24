using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Samples.TestMars
{
	internal sealed class ConnectionManager
	{
        static SqlConnection connection = null;
		public static SqlConnection GetConnection()
		{
			string connectionString = ConfigurationManager.ConnectionStrings["adv"].ConnectionString;
			connection = new SqlConnection(connectionString);
			connection.Open();
			return connection;
		}

        public static void Close()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection = null;
            }
        }
	}
}
