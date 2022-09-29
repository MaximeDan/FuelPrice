// using System.Data;
// using System.Data.SqlClient;
// using OilPrice_CESIProject;
//
// namespace OilPriceAPI;
//
// public class DataBaseInstance
// {
//     private static IConfiguration Configuration;
//     private static string dataBaseName = "OilPriceDataBase";
//
//     public DataBaseInstance(IConfiguration configuration)
//     {
//         Configuration = configuration;
//     }
//
//     public static bool CheckDatabaseExists()
//     {
//         bool DbExists = false;
//
//         var connectionString = Configuration["ConnectionStrings:DefaultDB"];
//
//         var sqlCreateDBQuery = string.Format("SELECT database_id FROM sys.databases WHERE Name = '{0}'", dataBaseName);
//         SqlConnection myConn = new SqlConnection(connectionString);
//
//         SqlCommand myCommand = new SqlCommand(sqlCreateDBQuery, myConn);
//         try
//         {
//             myConn.Open();
//             myCommand.ExecuteNonQuery();
//             DbExists = true;
//             Console.WriteLine("DataBase is Created Successfully");
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine(ex.ToString());
//         }
//         finally
//         {
//             if (myConn.State == ConnectionState.Open)
//             {
//                 myConn.Close();
//             }
//         }
//
//         return DbExists;
//     }
//
//     public void CreateDataBase()
//     {
//             string dBCondition = @$"CREATE DATABASE {dataBaseName};
//                                     GO
//
//                                     USE [{dataBaseName}];
//                                     GO
//
//                                     CREATE TABLE [{dataBaseName}].[dbo].[OilPriceTable]
//                                     (id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
//                                     FuelType VARCHAR(255) NULL,
//                                     City VARCHAR(255) NULL,
//                                     PostalCode VARCHAR(5) NULL,
//                                     Address VARCHAR(255) NULL,
//                                     UpdateTime DATE NULL,
//                                     Price VARCHAR NULL);";
//
//         var connectionString = Configuration["ConnectionStrings:DefaultDB"];
//
//         SqlConnection myConn = new SqlConnection(connectionString);
//
//         SqlCommand myCommand = new SqlCommand(dBCondition, myConn);
//         try
//         {
//             myConn.Open();
//             myCommand.ExecuteNonQuery();
//             Console.WriteLine("DataBase is Created Successfully");
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine(ex.ToString());
//         }
//         finally
//         {
//             if (myConn.State == ConnectionState.Open)
//             {
//                 myConn.Close();
//             }
//         }
//     }
// }