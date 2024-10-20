using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.file_folder
{
    internal class Lesson7
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var connString = "Data Source=LAPTOP-LLTJI6NG;Initial Catalog=LearnCSharp;User ID=sa;" +
                "Password=123456;TrustServerCertificate=False;Encrypt=False;";
            var sql = "SET IDENTITY_INSERT Person ON; " +
                "INSERT INTO Person(Id, FirstName, LastName, MidName, Age, Address) " +
                "VALUES(3, N'Ngọc', N'Trần', N'Như', 21, N'Hồ Chí Minh');" +
                "SET IDENTITY_INSERT Person OFF";
            var conn = DBUtils.GetConnection(connString);
            try
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                var result = cmd.ExecuteNonQuery();
                Console.WriteLine($"{result} dòng đã được chèn vào bảng.");
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
