using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Master_C__Programming.file_folder
{
    internal class ExercisesSQL
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var connString = "Data Source=LAPTOP-LLTJI6NG;Initial Catalog=LearnCSharp;User ID=sa;" +
                             "Password=123456;TrustServerCertificate=False;Encrypt=False;";
            var conn = DBUtils.GetConnection(connString);
            var headerStudent = $"{"Id",-20}{"FullName",-25}{"Address",-20}{"Major",-10}{"BirthDate",-20}{"PhoneNumber",-20}";
            var headerSubject = $"{"Id",-10}{"Name",-50}{"Credit",-10}{"NumOfLesson",-20}{"Type",-20}{"NumOfRegister",-20}";

            try
            {
                conn.Open();

                // 1. Cho biết tên, địa chỉ, ngày sinh của các sinh viên có trong bảng Student.
                var sql1 = "SELECT FullName, Address, BirthDate FROM Student";
                var students1 = FindAll(conn, sql1, reader => new Student(
                    id: "",
                    name: reader.GetString(0),
                    address: reader.GetString(1),
                    major: "",
                    birthDate: reader.GetDateTime(2),
                    phoneNumber: ""
                ));
                ShowList(students1, headerStudent);

                // 2. Sắp xếp danh sách sinh viên trên theo thứ tự ngày sinh tăng dần.
                var sql2 = "SELECT * FROM Student ORDER BY BirthDate ASC";
                var students2 = FindAll(conn, sql2, MapStudent);
                ShowList(students2, headerStudent);

                // 3. Cho biết thông tin các sinh viên đã đăng ký môn học.
                var sql3 = @"
                    SELECT DISTINCT s.*
                    FROM Student s
                    JOIN Register r ON s.Id = r.StudentId";
                var students3 = FindAll(conn, sql3, MapStudent);
                ShowList(students3, headerStudent);

                // 4. Cho biết sinh viên nào đăng ký nhiều môn học nhất.
                var sql4 = @"
                    WITH StudentRegistrationCount AS (
                        SELECT s.*, COUNT(r.StudentId) AS RegistrationCount
                        FROM Student s
                        JOIN Register r ON s.Id = r.StudentId
                        GROUP BY s.Id, s.FullName, s.Address, s.Major, s.BirthDate, s.PhoneNumber
                    )
                    SELECT Id, FullName, Address, Major, BirthDate, PhoneNumber
                    FROM StudentRegistrationCount
                    WHERE RegistrationCount = (
                        SELECT MAX(RegistrationCount) FROM StudentRegistrationCount
                    )";
                var students4 = FindAll(conn, sql4, MapStudent);
                ShowList(students4, headerStudent);

                // 5. Cho biết sinh viên nào đăng ký sớm nhất.
                var sql5 = @"
                    SELECT s.*
                    FROM Student s
                    JOIN Register r ON s.Id = r.StudentId
                    WHERE r.RegisterTime = (
                        SELECT MIN(RegisterTime) FROM Register
                    )";
                var students5 = FindAll(conn, sql5, MapStudent);
                ShowList(students5, headerStudent);

                // 6. Cho biết môn học nào được đăng ký nhiều nhất (xử lý nếu có nhiều môn học cùng số lượng đăng ký nhiều nhất)
                var sql6 = @"
                    WITH SubjectRegistrationCount AS (
                        SELECT sj.Id, sj.Name, sj.Credit, sj.NumOfLesson, sj.Type, COUNT(r.SubjectId) AS NumOfRegister
                        FROM Subject sj
                        JOIN Register r ON sj.Id = r.SubjectId
                        GROUP BY sj.Id, sj.Name, sj.Credit, sj.NumOfLesson, sj.Type
                    )
                    SELECT Id, Name, Credit, NumOfLesson, Type, NumOfRegister
                    FROM SubjectRegistrationCount
                    WHERE NumOfRegister = (
                        SELECT MAX(NumOfRegister) FROM SubjectRegistrationCount
                    )";
                var subjects6 = FindAll(conn, sql6, MapSubject);
                ShowList(subjects6, headerSubject);

                // 7. Cho biết thông tin sinh viên đã đăng ký môn học C#
                var sql7 = @"
                    SELECT s.* 
                    FROM Student s
                    JOIN Register r ON s.Id = r.StudentId
                    JOIN Subject sj ON sj.Id = r.SubjectId
                    WHERE sj.Name = 'C#'";
                var students7 = FindAll(conn, sql7, MapStudent);
                ShowList(students7, headerStudent);

                // 8. Cho biết số lượng sinh viên đăng ký theo từng môn học, sắp xếp theo thứ tự giảm dần số lượng đăng ký
                var sql8 = @"
                    SELECT sj.Id, sj.Name, ISNULL(result.NumOfRegister, 0) AS NumOfRegister
                    FROM Subject sj
                    LEFT JOIN (
                        SELECT r.SubjectId, COUNT(r.SubjectId) AS NumOfRegister
                        FROM Register r
                        GROUP BY r.SubjectId
                    ) AS result 
                    ON sj.Id = result.SubjectId 
                    ORDER BY NumOfRegister DESC";
                var subjects8 = FindAll(conn, sql8, reader => new Subject(
                    id: reader.GetString(0),
                    name: reader.GetString(1),
                    credit: 0,
                    numOfLesson: 0,
                    type: "",
                    numOfRegister: reader.GetInt32(2)
                ));
                ShowList(subjects8, headerSubject);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        static void ShowList<T>(List<T> list, string header)
        {
            Console.WriteLine(header);
            Console.WriteLine(new string('-', 100));
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('=', 150));
        }

        static List<T> FindAll<T>(SqlConnection conn, string sql, Func<SqlDataReader, T> mapFunction)
        {
            var list = new List<T>();
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = sql;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(mapFunction(reader));
                    }
                }
            }
            return list;
        }

        static Student MapStudent(SqlDataReader reader)
        {
            return new Student(
                id: reader.GetString(0),
                name: reader.GetString(1),
                address: reader.GetString(2),
                major: reader.GetString(3),
                birthDate: reader.GetDateTime(4),
                phoneNumber: reader.GetString(5)
            );
        }

        static Subject MapSubject(SqlDataReader reader)
        {
            return new Subject(
                id: reader.GetString(0),
                name: reader.GetString(1),
                credit: reader.GetInt32(2),
                numOfLesson: reader.GetInt32(3),
                type: reader.GetString(4),
                numOfRegister: reader.GetInt32(5)
            );
        }
    }

}
