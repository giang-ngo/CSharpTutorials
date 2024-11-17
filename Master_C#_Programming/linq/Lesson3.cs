using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.linq
{
    internal class Lesson3
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // danh sách sinh viên
            List<Student> students = new List<Student>()
            {
                new Student("B25DCCN100", "Trần Trung Đức", "Hà Nội"),
                new Student("B25DCCN105", "Lê Khả Ngân", "Nam Định"),
                new Student("B25DCCN103", "Hoàng Thanh Mai", "Đà Nẵng"),
                new Student("B25DCCN109", "Nguyễn Thúy Quyên", "Hà Nội"),
                new Student("B25DCCN106", "Nông Tiến Mạnh", "Thái Nguyên"),
                new Student("B25DCCN101", "Hồ Hoài Anh", "Hà Nội"),
                new Student("B25DCCN104", "Trương Thanh Thức", "Hồ Chí Minh")
            };

            // câu lệnh truy vấn
            IEnumerable<string> studentInHanoiQuery = from student in students
                                                       where student.Address == "Hà Nội"
                                                       select student.FullName;
            foreach (string item in studentInHanoiQuery)
            {
                Console.WriteLine(item);
            }
        }
    }
    struct RegisteredSubject
    {
        public string StudentId { get; set; }
        public string SubjectName { get; set; }
        public DateTime RegisterTime { get; set; }
        public RegisteredSubject(string studentId,
            string subjectName, DateTime reg)
        {
            StudentId = studentId;
            SubjectName = subjectName;
            RegisterTime = reg;
        }
    }


}
