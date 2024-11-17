using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Master_C__Programming.linq
{
    internal class Lesson5
    {
        /*
        * Cú pháp biểu thức và cú pháp phương thức LINQ
        */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // danh sách sinh viên
            var students = new List<Student>()
            {
                new Student("B25DCCN100", "Trần Trung Đức", "Hà Nội"),
                new Student("B25DCCN105", "Lê Khả Ngân", "Nam Định"),
                new Student("B25DCCN103", "Hoàng Thanh Mai", "Đà Nẵng"),
                new Student("B25DCCN109", "Nguyễn Thúy Quyên", "Hà Nội"),
                new Student("B25DCCN106", "Nông Tiến Mạnh", "Thái Nguyên"),
                new Student("B25DCCN101", "Hồ Hoài Anh", "Hà Nội"),
                new Student("B25DCCN104", "Trương Thanh Thức", "Hồ Chí Minh")
            };

            // danh sách giáo viên
            var teachers = new List<Teacher>() {
                new Teacher("T001", "Mai Thu Huyền", "Hà Nội", 24500000),
                new Teacher("T003", "Hoàng Quốc Trung", "Hà Nội", 16500000),
                new Teacher("T002", "Lê Tấn Tài", "Đà Nẵng", 18500000),
                new Teacher("T004", "Lê Mỹ Hạnh", "Hà Nội", 19500000),
                new Teacher("T005", "Trần Thanh Tuấn", "Hồ Chí Minh", 17800000)
            };

            //var teachersQuery = from teacher in teachers
            //                    orderby teacher.Salary descending
            //                    select new { teacher.FullName, teacher.Salary };

            var teachersQuery = teachers.Select(t => t).OrderBy(t => t.Salary).Reverse();
            foreach (var teacher in teachersQuery)
            {
                Console.WriteLine(teacher);
            }

            //var peopleInHanoiQuery = from student in students
            //                         where student.Address == "Hà Nội"
            //                         select student;

            // tương ứng
            //var teachersQuery = students.Where(student => student.Address == "Hà Nội");

            //foreach (var teacher in teachersQuery)
            //{
            //    Console.WriteLine(teacher);
            //}

            // chuyển các đối tượng sv sang XML
            //var studentToXML = new XElement("students",
            //    students.Select(student => new XElement("student",
            //    new XElement("Id", student.Id),
            //    new XElement("FullName", student.FullName),
            //    new XElement("Address", student.Address)
            //    )));
            //Console.WriteLine(studentToXML);
        }
    }


    struct Teacher
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public long Salary { get; set; }
        public Teacher(string id, string name, string address, long salary)
        {
            Id = id;
            FullName = name;
            Address = address;
            Salary = salary;
        }
        public override string ToString() => $"Teacher[{Id}, {FullName}, {Address}, {Salary}]";
    }

}
