using System;
using System.Text;

/**
 * Tính kế thừa
 */
namespace Chapter6
{
    class Person
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public Person(string fullName = "", string address = "", int age = 0)
        {
            FullName = fullName;
            Address = address;
            Age = age;
        }
    }

    class Student : Person // lớp Student kế thừa Person
    {
        public string StudentId { get; set; }
        public string Major { get; set; }
        public float Gpa { get; set; }

        // gọi constructor khác từ 1 constructor trong cùng lớp
        public Student(string id, string major, float gpa) : this("", "", 0, id, major, gpa)
        {
        }

        // gọi constructor của lớp cha trong cùng dòng dõi kế thừa
        public Student(string fullName, string address,
            int age, string studentId, string major, float gpa)
            : base(fullName, address, age)
        {
            StudentId = studentId;
            Major = major;
            Gpa = gpa;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Mã SV: {StudentId}");
            Console.WriteLine($"Họ và tên: {FullName}");
            Console.WriteLine($"Địa chỉ: {Address}");
            Console.WriteLine($"Chuyên ngành: {Major}");
            Console.WriteLine($"Tuổi: {Age}");
            Console.WriteLine($"Điểm gpa: {Gpa}");
        }
    }

    class Test68
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8; // cho phép hiển thị tiếng việt trong console
            string fullName = "Lê Văn Tuấn";
            string address = "Hồ Chí Minh";
            string studentId = "SV1005";
            string major = "CNTT";
            float gpa = 3.66f;
            int age = 20;
            Student student = new Student(fullName, address, age, studentId, major, gpa);
            Console.WriteLine("==> Thông tin sinh viên: <==");
            student.ShowInfo();
        }
    }
}
