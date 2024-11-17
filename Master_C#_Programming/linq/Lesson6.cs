using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.linq
{
    internal class Lesson6
    {
        /*
            Các tính năng hỗ trợ LINQ:
            1.Biểu thức truy vấn
            2.Kiểu tự suy luận var
            3.Cú pháp khởi tạo tập hợp
            4.Các kiểu vô danh
            5.Phương thức mở rộng
            6.Biểu thức lambda
         
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

            var student1 = new Student { Address = "Hải Phòng", FullName = "Trần Văn Hưng", Id = "ST001" };

            //var studentsQuery = from student in students
            //                    select new Student
            //                    {
            //                        Id = student.Id,
            //                        FullName = student.FullName,
            //                        Address = "Hồ Chí Minh"
            //                    };

            //var studentsQuery = from student in students
            //                    select new
            //                    {
            //                        student.Id,
            //                        student.FullName,
            //                    };

            var studentsQuery = students.Select(student => new { student.Id, student.FullName });
            foreach (var student in studentsQuery)
            {
                Console.WriteLine(student);
            }
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
