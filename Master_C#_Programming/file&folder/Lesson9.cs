using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.file_folder
{
    internal class Lesson9
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var connString = "Data Source=LAPTOP-LLTJI6NG;Initial Catalog=LearnCSharp;User ID=sa;" +
               "Password=123456;TrustServerCertificate=False;Encrypt=False;";

            // xóa cột  phoneNumber
            //var sql = "ALTER TABLE Person DROP CONSTRAINT DF__Person__PhoneNum__4AB81AF0" +
            //    ";ALTER TABLE Person DROP COLUMN PhoneNumber";

            //Thêm cột email
            //var sql = "ALTER TABLE Person ADD Email NVARCHAR(255) NULL";

            //thêm cột salary
            //var sql = "ALTER TABLE Person ADD Salary FLOAT NOT NULL DEFAULT(0)";

            //xóa cột salary
            //var sql = "ALTER TABLE Person DROP CONSTRAINT DF__Person__Salary__6E01572D" +
            //    ";ALTER TABLE Person DROP COLUMN Salary";

            // đã thêm cột salary trước đó kiểu float giờ thay đổi thành int
            //var sql = "ALTER TABLE Person DROP CONSTRAINT DF__Person__Salary__01142BA1;" +
            //    "ALTER TABLE Person ALTER COLUMN Salary INT";

            var sql = "ALTER TABLE Person ALTER COLUMN Email NVARCHAR(50)";
            var conn = DBUtils.GetConnection(connString);
            try
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = sql;
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
