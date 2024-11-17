using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.linq
{
    internal class Lesson15
    {
        /**
         * Các toán tử tổng hợp
         * 1. Average
         * 2. Count
         * 3. Max
         * 4. Min
         * 5. Sum
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            float[] temps = new float[] { 26.5f, 30.0f, 28.5f,
                29.5f, 29.0f, 31.5f, 27.5f };
            var students = new List<Student>()
            {
                new Student("B25DCCN107", "Trần Trung Đức", "Hà Nội",
                    new float[] {3.21f, 3.29f, 3.54f}),
                new Student("B25DCCN100", "Trần Văn Đức", "Cao Bằng",
                    new float[] {3.66f, 3.37f, 3.88f}),
                new Student("B25DCCN105", "Lê Khả Ngân", "Nam Định",
                    new float[] {3.78f, 3.18f, 3.42f}),
                new Student("B25DCCN103", "Hoàng Thanh Mai", "Đà Nẵng",
                    new float[] {3.54f, 3.46f, 3.74f}),
                new Student("B25DCCN109", "Nguyễn Thúy Quyên", "Hà Nội",
                    new float[] {3.36f, 3.05f, 3.18f}),
                new Student("B25DCCN106", "Nông Tiến Mạnh", "Thái Nguyên",
                    new float[] {3.45f, 3.51f, 3.88f}),
                new Student("B25DCCN101", "Hồ Hoài Anh", "Hà Nội",
                    new float[] {3.69f, 3.35f, 3.68f}),
                new Student("B25DCCN104", "Trương Thanh Thức", "Hồ Chí Minh",
                    new float[] {3.11f, 3.18f, 3.72f}),
                new Student("B25DCCN108", "Đỗ Hoàng Long", "Hồ Chí Minh",
                    new float[] {3.88f, 3.97f, 3.49f})
            };

            //Console.WriteLine($"Nhiệt độ trung bình tuần: {temps.Average(),2:f}");
            //Console.WriteLine($"Nhiệt độ cao nhất trong tuần: {temps.Max(),2:f}");
            //Console.WriteLine($"Nhiệt độ thấp nhất trong tuần: {temps.Min(),2:f}");
            //Console.WriteLine($"Số phần tử của mảng: {temps.Count(),2:f}");
            //Console.WriteLine($"Tổng nhiệt độ của tuần: {temps.Sum(),2:f}");

            var studyResultQuery = from student in students
                                   let gpa = Math.Round(student.Marks.Average(), 2)
                                   orderby gpa descending
                                   select new { student.Id, student.FullName, gpa };

            //var maxMarkQuery = from student in students
            //                   let max = student.Marks.Max()
            //                   orderby max descending
            //                   select new { student.Id, student.FullName, max };

            //var minMarkQuery = from student in students
            //                   let min = student.Marks.Min()
            //                   orderby min
            //                   select new { student.Id, student.FullName, min };

            var maxGpa = (from student in students
                          let gpa = Math.Round(student.Marks.Average(), 2)
                          orderby gpa descending
                          select gpa).Max();

            Console.WriteLine($"Điểm TB cao nhất: {maxGpa}");

            foreach (var student in studyResultQuery)
            {
                Console.WriteLine(student);
            }
        }
    }
}
