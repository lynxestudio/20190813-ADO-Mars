using System;
using System.Data.SqlClient;
using System.Data;

namespace Samples.TestMars
{
	public sealed class AdvWorksDal
	{
		public void PrintQuery()
		{
			string vendorSQL = SQLCommands.SQLCommand1;
            string productSQL = SQLCommands.SQLCommand2;
            using (SqlConnection awConnection = ConnectionManager.GetConnection())
            {
            	//Two Sql Commands associated to one SqlConnection
                    SqlCommand vendorCmd = new SqlCommand(vendorSQL, awConnection);
                    SqlCommand productCmd = new SqlCommand(productSQL, awConnection);
                    productCmd.Parameters.Add("@VendorId", SqlDbType.Int);
                    using (SqlDataReader vendorReader = vendorCmd.ExecuteReader())
                    {
                        while (vendorReader.Read())
                        {
                            System.Console.WriteLine("[+]" + vendorReader["Name"]);
                            int VendorID = (int)vendorReader["VendorId"];
                            productCmd.Parameters["@VendorId"].Value = VendorID;
                            //The following line of code requires a MARS-enabled connection
                            SqlDataReader productReader = productCmd.ExecuteReader();
                            using (productReader)
                            {
                                while (productReader.Read())
                                {
                                    Console.WriteLine(" |- " + productReader["Name"].ToString());
                                }
                            }
                        }
                    }
            }
		}
	}
}
