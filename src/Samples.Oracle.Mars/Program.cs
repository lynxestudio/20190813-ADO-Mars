using System;
using Oracle.DataAccess.Client;
using System.Collections.Generic;
using System.Data;

namespace Samples.Oracle.Mars
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities.ShowMenu("Oracle ADO.NET Mars sample");
            string managerId = Utilities.Scanf("Enter a Manager id ");
            Console.WriteLine();
            using (OracleConnection conn = OracleDataBase.GetConnection())
            {
                //Three commands associated to a one single connection
                OracleCommand cmd1 = new OracleCommand(CommandTexts.CommandText1, conn);
                OracleCommand cmd2 = new OracleCommand(CommandTexts.CommandText2, conn);
                OracleCommand cmd3 = new OracleCommand(CommandTexts.CommandText3, conn);
                cmd1.Parameters.Add("prmManagerId", managerId);
                using (OracleDataReader reader = cmd1.ExecuteReader())
                {
                    ShowDataGrid(reader);
                }
                string departmentId = Utilities.Scanf("Enter a department id ");
                Console.WriteLine();
                cmd2.Parameters.Add("prmDepartmentId", departmentId);
                using (OracleDataReader reader = cmd2.ExecuteReader())
                {
                    ShowDataGrid(reader);
                }
                string jobId = Utilities.Scanf("Enter a Job id ");
                Console.WriteLine();
                cmd3.Parameters.Add("prmJobId", jobId);
                using (OracleDataReader reader = cmd3.ExecuteReader())
                {
                    ShowDataGrid(reader);
                }

            }
            Utilities.Pause();
        }

        internal static void ShowDataGrid(OracleDataReader reader)
        {
            // DataGrid dimensions
            int columnWidth = 15;
            int numColumns = reader.FieldCount;
            bool hasColumns = false;
            string nameColumn = null;
            //int numRows = data.Length / numColumns;
            // Draw the header
            Console.WriteLine("+" + new string('-', columnWidth * numColumns + (numColumns + 1)) + "+");
            while (reader.Read())
            {
                if (!hasColumns)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        nameColumn = reader.GetName(i);
                        Console.Write("|" + CenterText(nameColumn, columnWidth));
                        if (i == (numColumns - 1))
                        {
                            hasColumns = true;
                            Console.Write("|");
                            Console.WriteLine();
                            break;
                        }
                    }
                    Console.WriteLine("+" + new string('-', columnWidth * numColumns + (numColumns + 1)) + "+");
                }
                // Draw the rows
                if(reader.HasRows)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
			        {
                        int offset = numColumns - 1;
                        Console.Write("|" + CenterText(reader.GetValue(i).ToString() , columnWidth));
                        if (i == offset)
                        {
                            Console.WriteLine();
                        }
			        }
                }
            }
            Console.WriteLine();
            // Draw the bottom border
            Console.WriteLine("+" + new string('-', columnWidth * numColumns + (numColumns + 1)) + "+");
            
        }

        static string CenterText(string text, int width)
        {
            if (text.Length >= width)
                return text.Substring(0, width); // Truncate if text is longer than width

            int spaces = width - text.Length;
            int padLeft = spaces / 2;
            int padRight = spaces - padLeft;

            return new string(' ', padLeft) + text + new string(' ', padRight);
        }
    }
}
