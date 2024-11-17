using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.linq
{
    internal class Lesson8
    {
        /*
         * Các toán tử liên quan đến tập hợp của LINQ
         * 1. Loại bỏ phần tử trùng lặp trong 1 tập hợp
         * 2. Trả về các phần tử ở tập này nhưng không ở tập kia
         * 3. Trả về các phần tử chung trong 2 tập hợp
         * 4. Trả về các phần tử duy nhất xuất hiện ở tập hợp 1 và tập hợp 2
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // danh sách sinh viên
            var students = new List<Student>()
            {
                new Student("B25DCCN107", "Trần Trung Đức", "Hà Nội"),
                new Student("B25DCCN100", "Trần Trung Đức", "Cao Bằng"),
                new Student("B25DCCN100", "Trần Trung Đức", "Cao Bằng"),
                new Student("B25DCCN105", "Lê Khả Ngân", "Nam Định"),
                new Student("B25DCCN103", "Hoàng Thanh Mai", "Đà Nẵng"),
                new Student("B25DCCN103", "Hoàng Thanh Mai", "Đà Nẵng"),
                new Student("B25DCCN109", "Nguyễn Thúy Quyên", "Hà Nội"),
                new Student("B25DCCN106", "Nông Tiến Mạnh", "Thái Nguyên"),
                new Student("B25DCCN106", "Nông Tiến Mạnh", "Thái Nguyên"),
                new Student("B25DCCN101", "Hồ Hoài Anh", "Hà Nội"),
                new Student("B25DCCN104", "Trương Thanh Thức", "Hồ Chí Minh"),
                new Student("B25DCCN104", "Trương Thanh Thức", "Hồ Chí Minh"),
                new Student("B25DCCN108", "Đỗ Hoàng Long", "Hồ Chí Minh")
            };

            var students2 = new List<Student>()
            {
                new Student("B25DCCN107", "Trần Trung Đức", "Hà Nội"),
                new Student("B25DCCN100", "Trần Trung Đức", "Cao Bằng"),
                new Student("B25DCCN100", "Trần Trung Đức", "Cao Bằng"),
                new Student("B25DCCN105", "Lê Khả Ngân", "Nam Định"),
                new Student("B25DCCN103", "Hoàng Thanh Mai", "Đà Nẵng"),
                new Student("B25DCCN103", "Hoàng Thanh Mai", "Đà Nẵng"),

            };
            //1 Distinct 
            //var distinctStudentsQuery = from student in students.Distinct() select student;


            //2 Except
            //var exceptStudentsQuery = from student in students.Except(students2) select student;

            //3 Intersect
            //var intersectStudentsQuery = from student in students.Intersect(students2) select student;

            //4 Union
            var unionStudentsQuery = from student in students.Union(students2) orderby student.Id select student;

            foreach (var item in unionStudentsQuery)
            {
                Console.WriteLine(item);
            }
        }
    }
    
}
