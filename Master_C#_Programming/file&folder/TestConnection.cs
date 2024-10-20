using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Master_C__Programming.file_folder
{
    internal class TestConnection
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var connString = "Data Source=LAPTOP-LLTJI6NG;Initial Catalog=LearnCSharp;User ID=sa;" +
                "Password=123456;TrustServerCertificate=False;Encrypt=False;";
            var conn = DBUtils.GetConnection(connString);
            try
            {
                conn.Open();
                var people = FindAll(conn);
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

        private static void PrintInfo(List<Person> people)
        {
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }

        static List<Person> FindAll(SqlConnection conn)
        {
            List<Person> list = new List<Person>();
            string sql = "SELECT * FROM Person";
            var cmd = new SqlCommand(sql, conn);
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var idColIndex = reader.GetOrdinal("Id");
                        int id = reader.GetInt32(idColIndex);
                        string first = reader.IsDBNull(1) ? null : reader.GetString(1);
                        string last = reader.IsDBNull(2) ? null : reader.GetString(2);
                        string mid = reader.IsDBNull(3) ? null : reader.GetString(3);
                        int age = reader.IsDBNull(4) ? 0 : reader.GetInt32(4);
                        string address = reader.IsDBNull(5) ? null : reader.GetString(5);
                        list.Add(new Person
                        {
                            Id = id,
                            FirstName = first,
                            LastName = last,
                            MidName = mid,
                            Age = age,
                            Address = address
                        });
                    }
                }
            }
            return list;
        }

        
    }
}
