using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Master_C__Programming.linq
{
    internal class Lesson9
    {    /*
         * Lọc dữ liệu với toán tử where của LINQ
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // danh sách sinh viên
            var students = new List<Student>()
            {
                new Student("B25DCCN107", "Trần Trung Đức", "Hà Nội", 3.21f),
                new Student("B25DCCN100", "Trần Trung Đức", "Cao Bằng", 3.66f),
                new Student("B25DCCN105", "Lê Khả Ngân", "Nam Định", 3.78f),
                new Student("B25DCCN103", "Hoàng Thanh Mai", "Đà Nẵng", 3.54f),
                new Student("B25DCCN109", "Nguyễn Thúy Quyên", "Hà Nội", 3.36f),
                new Student("B25DCCN106", "Nông Tiến Mạnh", "Thái Nguyên", 3.45f),
                new Student("B25DCCN101", "Hồ Hoài Anh", "Hà Nội", 3.69f),
                new Student("B25DCCN104", "Trương Thanh Thức", "Hồ Chí Minh", 3.11f),
                new Student("B25DCCN104", "Trương Thanh Thức", "Hồ Chí Minh", 3.39f),
                new Student("B25DCCN108", "Đỗ Hoàng Long", "Hồ Chí Minh", 3.88f)
            };
            // truy vấn

            //var gpaGreaterThan32Query = from student in students
            //                            where student.Gpa > 3.2
            //                            && student.Address == "Hà Nội"
            //                            select student;

            var pattern = @".*h.*";
            var regex = new Regex(pattern);
            var studentsWithNameContainHQuery = from student in students
                                                where regex.IsMatch(student.FullName)
                                                select student;


            foreach (var student in studentsWithNameContainHQuery)
            {
                Console.WriteLine(student);
            }
        }
    }

}
