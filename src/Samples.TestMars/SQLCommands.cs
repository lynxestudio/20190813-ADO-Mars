using System;

namespace Samples.TestMars
{
	public class SQLCommands
	{
		public const string SQLCommand1 = "SELECT VendorID, [Name] FROM Purchasing.Vendor";
		public const string SQLCommand2 = "SELECT Production.Product.Name FROM Production.Product " 
        + "INNER JOIN Purchasing.ProductVendor " +
        "ON Production.Product.ProductID = " +
        "Purchasing.ProductVendor.ProductID " +
        "WHERE Purchasing.ProductVendor.VendorID = @VendorId";
	}
}
