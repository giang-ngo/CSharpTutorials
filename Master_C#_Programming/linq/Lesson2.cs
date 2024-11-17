using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.linq
{
    internal class Lesson2
    {
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

            // danh sách đăng ký
            var registers = new List<RegisteredSubject>() {
                new RegisteredSubject("B25DCCN100", "Java", DateTime.Now),
                new RegisteredSubject("B25DCCN100", "C#", DateTime.Now),
                new RegisteredSubject("B25DCCN100", "SQL", DateTime.Now),
                new RegisteredSubject("B25DCCN105", "Android", DateTime.Now),
                new RegisteredSubject("B25DCCN104", "C#", DateTime.Now),
                new RegisteredSubject("B25DCCN101", "C#", DateTime.Now)
            };

            var studentRegisterQuery = from student in students
                                       join register in registers
                                     on student.Id equals register.StudentId
                                       select new { student.Id, student.FullName, register.SubjectName };

            foreach (var student in studentRegisterQuery)
            {
                Console.WriteLine($"{student.Id} - {student.FullName}: {student.SubjectName}");
            }


            var groupStudentQuery = from student in students group student by student.Address;

            //foreach (var group in groupStudentQuery)
            //{
            //    Console.WriteLine($"==> {group.Key}");
            //    foreach (var student in group)
            //    {
            //        Console.WriteLine(student);
            //    }
            //}

            //var studentInHanoiQuery = from Student student in students
            //                          where student.Address == "Hà Nội" orderby student.Id
            //                          select student;

            //// thực hiện truy vấn
            //foreach (var item in studentInHanoiQuery)
            //{
            //    Console.WriteLine(item);
            //}
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

    //struct Student
    //{
    //    public string Id { get; set; }
    //    public string FullName { get; set; }
    //    public string Address { get; set; }
    //    public Student(string id, string fullName, string address)
    //    {
    //        Id = id;
    //        FullName = fullName;
    //        Address = address;
    //    }
    //    public override string ToString() => $"Student[{Id}, {FullName}, {Address}]";
    //}
}


