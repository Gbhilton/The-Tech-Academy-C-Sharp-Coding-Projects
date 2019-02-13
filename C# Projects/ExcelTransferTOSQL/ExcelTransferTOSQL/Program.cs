using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;
using System.ComponentModel;
using System.Drawing;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;


namespace ExcelTransferTOSQL
{
    public partial class Program
    {

        static void Main()
        {
            //Set the connection string for the SQL Server Database.
            string strConnection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Game;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //file upload path
            string path = @"C:\Users\usagxh19\Desktop\Information\Homework\The Tech Academy\C# Projects\ExcelTransferTOSQL\VideoGameDatabase.xlsx";
            //Create connection string to Excel work book
            string excelConnectionString = @"Provider =Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;Persist Security Info=False";
            //Create Connection to Excel work book
            OleDbConnection excelConnection = new OleDbConnection(excelConnectionString);
            //Create OleDbCommand to fetch data from Excel
            OleDbCommand cmd = new OleDbCommand("Select [Title],[Year],[Genre],[Creator],[Console1],[Console2],[Console3] from [Games$]", excelConnection);
            excelConnection.Open();
            OleDbDataReader dReader;
            dReader = cmd.ExecuteReader();
            SqlBulkCopy sqlBulk = new SqlBulkCopy(strConnection);
            //Give your Destination table name
            sqlBulk.DestinationTableName = "VideoGames";
            sqlBulk.WriteToServer(dReader);
            excelConnection.Close();
        }
    }
}





