using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Master_C__Programming.file_folder
{
    internal class Lesson8
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var connString = "Data Source=LAPTOP-LLTJI6NG;Initial Catalog=LearnCSharp;User ID=sa;" +
               "Password=123456;TrustServerCertificate=False;Encrypt=False;";

            var sql1 = "SET IDENTITY_INSERT Person ON;";
            var sql2 =
                "INSERT INTO Person(Id, FirstName, LastName, MidName, Age, Address) " +
                "VALUES(@id, @first, @last, @mid, @age, @address)";
            var sql3 = "SET IDENTITY_INSERT Person OFF;";

            var people = CreatePeople(); // danh sách người cần thêm vào bảng

            using (var conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    // Bật IDENTITY_INSERT
                    using (var command = new SqlCommand(sql1, conn))
                    {
                        command.ExecuteNonQuery();
                    }

                    // Thực hiện chèn dữ liệu
                    using (var command = new SqlCommand(sql2, conn))
                    {
                        command.Parameters.Add("@id", SqlDbType.Int);
                        command.Parameters.Add("@first", SqlDbType.NVarChar, 50);
                        command.Parameters.Add("@last", SqlDbType.NVarChar, 50);
                        command.Parameters.Add("@mid", SqlDbType.NVarChar, 50);
                        command.Parameters.Add("@age", SqlDbType.Int);
                        command.Parameters.Add("@address", SqlDbType.NVarChar, 50);

                        command.Prepare();

                        foreach (var item in people)
                        {
                            command.Parameters["@id"].Value = item.Id;
                            command.Parameters["@first"].Value = item.FirstName;
                            command.Parameters["@last"].Value = item.LastName;
                            command.Parameters["@mid"].Value = item.MidName;
                            command.Parameters["@age"].Value = item.Age;
                            command.Parameters["@address"].Value = item.Address;

                            command.ExecuteNonQuery();
                        }
                    }

                    // Tắt IDENTITY_INSERT
                    using (var command = new SqlCommand(sql3, conn))
                    {
                        command.ExecuteNonQuery();
                    }

                    Console.WriteLine($"{people.Count} dòng đã được chèn vào bảng.");
                }
                catch (SqlException e)
                {
                    Console.WriteLine($"Lỗi SQL: {e.Message}");
                }
            }
        }

        private static List<Person> CreatePeople()
        {
            return new List<Person>
            {
                new Person(140, "Long", "Phạm", "Đình", 20, "Nghệ An"),
                new Person(141, "Linh", "Trần", "Hạo", 20, "Hà Nam"),
                new Person(142, "Liên", "Ngô", "Thu", 20, "Cà Mau"),
                new Person(143, "Hồng", "Lê", "Thị Minh", 21, "Bình Dương"),
                new Person(144, "Luyến", "Nông", "Thị Lưu", 20, "Tây Ninh"),
                new Person(145, "Nga", "Vũ", "Thị Thu", 21, "Hà Tĩnh")
            };
        }
    }

   
}
