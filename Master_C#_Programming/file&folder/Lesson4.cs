using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Master_C__Programming.file_folder
{
    internal class Lesson4
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var connString = "Data Source=LAPTOP-LLTJI6NG;Initial Catalog=LearnCSharp;User ID=sa;" +
                "Password=123456;TrustServerCertificate=False;Encrypt=False;";
            var conn = DBUtils.GetConnection(connString);

            Console.WriteLine("Nhập mã của người cần xóa: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Mã không hợp lệ.");
                return;
            }

            try
            {
                conn.Open();
                var result = Remove(conn, id);
                if (result > 0)
                {
                    Console.WriteLine($"Xóa thành công {result} bản ghi.");
                }
                else
                {
                    Console.WriteLine("Xóa thất bại. Không có bản ghi nào được xóa.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Hàm thực hiện xóa bản ghi dựa trên id (sử dụng parameterized query)
        private static int Remove(SqlConnection conn, int id)
        {
            var sql = "DELETE FROM Person WHERE Id = @Id";
            var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Id", id);// tránh SQL Injection
            //@Id được coi là 1 biến thay vì 1 phần của sql

            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thực hiện truy vấn: " + ex.Message);
            }
            return 0;
        }
    }

}
