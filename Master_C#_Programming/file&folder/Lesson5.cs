using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.file_folder
{
    internal class Lesson5
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            var connString = "Data Source=LAPTOP-LLTJI6NG;Initial Catalog=LearnCSharp;User ID=sa;" +
                "Password=123456;TrustServerCertificate=False;Encrypt=False;";
            var conn = DBUtils.GetConnection(connString);

            //Console.WriteLine("Nhập mã người cần cập nhật: ");
            //var id = int.Parse(Console.ReadLine());
            //Console.WriteLine("Nhập tên đệm: ");
            //var midName = Console.ReadLine();
            //Console.WriteLine("Nhập tuổi: ");
            //int age = int.Parse(Console.ReadLine());

            //var sql = $"UPDATE Person SET MidName=N'{midName}', Age = {age} WHERE Id={id}";


            Console.WriteLine("Nhập mã người cần cập nhật: ");
            var id = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập địa chỉ mới:");
            var address = Console.ReadLine();

            var sql = "UPDATE Person SET Address=@address WHERE Id=@id";


            try
            {
                conn.Open();
                var result = Update(conn, sql, id, address);
                if (result != 0)
                {
                    Console.WriteLine($"Cập nhật thành công {result} bảng ghi vào bảng.");
                }
                else
                {
                    Console.WriteLine("Cập nhật thất bại");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }
        }

        static int Update(SqlConnection conn, string sql, int id, string address)
        {
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@address", address);

                try
                {
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return 0;
            }

        }

        private static void PrintInfo(List<Person> people)
        {
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
