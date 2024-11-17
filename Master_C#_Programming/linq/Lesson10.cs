using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.linq
{
    internal class Lesson10
    {
        /*
         * Các toán tử định lượng trong LINQ
         * 1. All
         * 2. Any
         * 3. Contains
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // danh sách sinh viên
            var students = new List<Student>()
            {
                new Student("B25DCCN107", "Trần Trung Đức", "Hà Nội", new float[] {3.21f, 3.29f, 3.54f}),
                new Student("B25DCCN100", "Trần Văn Đức", "Cao Bằng", new float[] {3.66f, 3.37f, 3.88f}),
                new Student("B25DCCN105", "Lê Khả Ngân", "Nam Định", new float[] {3.78f, 3.18f, 3.42f}),
                new Student("B25DCCN103", "Hoàng Thanh Mai", "Đà Nẵng", new float[] {3.54f, 3.46f, 3.74f}),
                new Student("B25DCCN109", "Nguyễn Thúy Quyên", "Hà Nội", new float[] {3.36f, 3.05f, 3.18f}),
                new Student("B25DCCN106", "Nông Tiến Mạnh", "Thái Nguyên", new float[] {3.45f, 3.51f, 3.88f}),
                new Student("B25DCCN101", "Hồ Hoài Anh", "Hà Nội", new float[] {3.69f, 3.35f, 3.68f }),
                new Student("B25DCCN104", "Trương Thanh Thức", "Hồ Chí Minh", new float[] {3.11f, 3.18f, 3.72f }),
                new Student("B25DCCN108", "Đỗ Hoàng Long", "Hồ Chí Minh", new float[] {3.88f, 3.97f, 3.49f })
            };

            // truy vấn

            // All
            //var studentsNameQuery = from student in students
            //                        where student.Marks.All(m => m >= 3.2f)
            //                        select student.FullName;

            // Any
            //var studentsNameQuery = from student in students
            //                        where student.Marks.Any(m => m >= 3.7f)
            //                        select student.FullName;

            // Contains
            var studentsNameQuery = from student in students
                                    where student.Marks.Contains(3.54f)
                                    select new { student.Id, student.FullName };

            foreach (var student in studentsNameQuery)
            {
                Console.WriteLine(student);
            }
        }
    }

}
