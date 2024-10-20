using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Master_C__Programming.file_folder
{
    internal class Lesson3
    {
        // 1. Chọn ra những người có trong bảng và sắp xếp theo thứ tự tăng dần của tên -> done
        // 2. Chọn ra những người có trong bảng, sắp xếp theo thứ tự tăng dần của tuổi -> done
        // 3. Chọn ra những người có trong bảng sống tại địa chỉ cho trước
        // 4. Cho biết có bao nhiêu người cùng k tuổi có mặt trong bảng
        // 5. Cho biết tên những người có tuổi lớn nhất có mặt trong bảng

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var connString = "Data Source=LAPTOP-LLTJI6NG;Initial Catalog=LearnCSharp;User ID=sa;" +
                "Password=123456;TrustServerCertificate=False;Encrypt=False;";
            var conn = DBUtils.GetConnection(connString);
            try
            {
                conn.Open();
                // 1. Sắp xếp theo tên
                // var people = FindAll(conn, "ORDER BY FirstName ASC");

                // 2. Sắp xếp theo tuổi
                // var people = FindAll(conn,"ORDER BY Age ASC");

                // 3. Lọc theo địa chỉ
                //var people = FindAll(conn, "WHERE Address = N'Hồ Chí Minh'");

                // 4. Lọc theo k tuổi 
                //var people = FindAll(conn, "WHERE Age = 20");

                // 5. Tìm người có tuổi lớn nhất
                //var people = FindAll(conn, "WHERE Age = (SELECT MAX(Age) FROM Person)");
                var people = FindAll(conn, "WHERE Age IN (SELECT MAX(Age) FROM Person)", "Id,FirstName,Age");

                PrintInfo(people);
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

        static List<Person> FindAll(SqlConnection conn, string whereClause = "", string column = "*")
        {
            List<Person> list = new List<Person>();
            string sql = $"SELECT {column} FROM Person {whereClause}";
            var cmd = new SqlCommand(sql, conn);
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //var idColIndex = reader.GetOrdinal("Id");
                        //int id = reader.GetInt32(idColIndex);
                        //string first = reader.IsDBNull(1) ? null : reader.GetString(1);
                        //string last = reader.IsDBNull(2) ? null : reader.GetString(2);
                        //string mid = reader.IsDBNull(3) ? null : reader.GetString(3);
                        //int age = reader.IsDBNull(4) ? 0 : reader.GetInt32(4);
                        //string address = reader.IsDBNull(5) ? null : reader.GetString(5);

                        //list.Add(new Person
                        //{
                        //    Id = id,
                        //    FirstName = first,
                        //    LastName = last,
                        //    MidName = mid,
                        //    Age = age,
                        //    Address = address
                        //});

                        int id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                        string first = reader.IsDBNull(1) ? null : reader.GetString(1);
                        int age = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);



                        list.Add(new Person(id, first, null, null, age, null));
                    }
                }
            }
            return list;
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
