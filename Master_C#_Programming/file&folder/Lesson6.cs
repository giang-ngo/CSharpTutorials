using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.file_folder
{
    internal class Lesson6
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            var connString = "Data Source=LAPTOP-LLTJI6NG;Initial Catalog=LearnCSharp;User ID=sa;" +
                "Password=123456;TrustServerCertificate=False;Encrypt=False;";
            var conn = DBUtils.GetConnection(connString);

            // Cách 1:

            Console.WriteLine("Tên:");
            var first = Console.ReadLine();
            Console.WriteLine("Họ: ");
            var last = Console.ReadLine();
            Console.WriteLine("Đệm:");
            var mid = Console.ReadLine();
            Console.WriteLine("Địa chỉ:");
            var address = Console.ReadLine();
            Console.WriteLine("Tuổi:");
            var age = int.Parse(Console.ReadLine());
            //var sql = $"INSERT INTO Person(FirstName,LastName,MidName,Address) VALUES(N'{first}'," +
            //    $" N'{last}', N'{mid}',  N'{address}') ";

            // Cách 2:

            var sql = $"INSERT INTO Person(FirstName,LastName,MidName,Age,Address) " +
                $"VALUES(@first,@last,@mid,@age,@address) ";
            try
            {
                conn.Open();
                var result = InsertData(conn, sql, first, last, mid, age, address);
                if (result != 0)
                {
                    Console.WriteLine($"Chèn thành công {result} dòng");
                }
                else
                {
                    Console.WriteLine("Chèn thất bại");
                }
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

        private static int InsertData(SqlConnection conn, string sql, string first,
            string last, string mid, int age, string address)
        {
            var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@first", System.Data.SqlDbType.NVarChar).Value = first;
            cmd.Parameters.Add("@mid", System.Data.SqlDbType.NVarChar).Value = mid;
            cmd.Parameters.Add("@last", System.Data.SqlDbType.NVarChar).Value = last;
            cmd.Parameters.Add("@age", System.Data.SqlDbType.Int).Value = age;
            cmd.Parameters.Add("@address", System.Data.SqlDbType.NVarChar).Value = address;

            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return 0;


        }
    }
}
