using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.file_folder
{
    internal class Lesson10
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var connString = "Data Source=LAPTOP-LLTJI6NG;Initial Catalog=Test;User ID=sa;" +
               "Password=123456;TrustServerCertificate=False;Encrypt=False;";


            // tạo db
            // CREATE DATABASE DbName
            //var sql = "CREATE DATABASE Test";


            // xóa db
            // DROP DATABASE DbName
            //var sql = "DROP DATABASE Test";

            // tạo bảng

            //var sqlCreateTable = "CREATE TABLE Student(" +
            //    "StudentId VARCHAR(20) NOT NULL," +
            //    "FullName NVARCHAR(50) NULL," +
            //    "Gpa FLOAT NOT NULL DEFAULT(0.0)," +
            //    "Major NVARCHAR(50) NULL" +
            //    ")";

            //var sqlCreateTable = "CREATE TABLE OtherStudent(" +
            //    "StudentId VARCHAR(20) NOT NULL PRIMARY KEY," +
            //    "FullName NVARCHAR(50) NULL," +
            //    "Gpa FLOAT NOT NULL DEFAULT(0.0)," +
            //    "Major NVARCHAR(50) NULL" +
            //    ")";

            //var sqlCreateTable = "CREATE TABLE Student2(" +
            //    "Id INT IDENTITY(100,1) NOT NULL PRIMARY KEY," +
            //    "FullName NVARCHAR(50) NULL," +
            //    "Gpa FLOAT NOT NULL DEFAULT(0.0)," +
            //    "Major NVARCHAR(50) NULL" +
            //    ")";

            var sqlCreateTable = "CREATE TABLE Student3(" +
                "Id INT IDENTITY(100,10) NOT NULL," +
                "FullName NVARCHAR(50) NULL," +
                "Gpa FLOAT NOT NULL DEFAULT(0.0)," +
                "Major NVARCHAR(50) NULL," +
                "PRIMARY KEY CLUSTERED (Id ASC)" +
                ")";

            var conn = DBUtils.GetConnection(connString);
            try
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = sqlCreateTable;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
