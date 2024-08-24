using System.Data;
using System.Data.SqlClient;
using System;

namespace Samples.TestMars
{
    class Program
    {
        static void Main(string[] args)
        {
        	
        	Console.WriteLine(" Simple SQL Server Connection with MARS enabled.");
        	Console.WriteLine("================================================");
            try
            {
                AdvWorksDal dac = new AdvWorksDal();
                dac.PrintQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Press any key to finish...");
            Console.ReadLine();
        }
    }
}