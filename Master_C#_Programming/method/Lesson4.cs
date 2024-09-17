using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.method
{
    internal class Lesson4
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            var first = "Hoang";
            var last = "Ngo";
            var mid = "Minh";
            var age = 20;
            var gpa = 3.56f;
            //// gọi theo cách truyền thống
            //ShowInfo(first, last, mid, age, gpa);
            //// gọi theo đối số được đặt tên
            //ShowInfo(firstName: first, lastName: last, age: age, gpa: gpa, midName: mid);
            //ShowInfo(age: age, gpa: gpa, midName: mid, firstName: first, lastName: last);
            //ShowInfo(first, last, midName: mid, age: age, gpa);
            //ShowInfo(first, last, age: age, gpa: gpa, midName: mid);

            // cung cấp chỉ tham số bắt buộc
            ShowInfo("Nguyễn Thị Loan");
            ShowInfo(fullName: "Nguyễn Thị Loan");
            ShowInfo(fullName: "Nguyễn Thị Loan", age: 21);
            ShowInfo(fullName: "Nguyễn Thị Loan", age: 21, address: "Đà Nẵng");
            ShowInfo("Nguyễn Thị Loan", address: "Đà Nẵng");
        }

        //static void ShowInfo(string firstName, string lastName,
        //                    string midName, int age, float gpa)
        //{
        //    Console.WriteLine($"First Name: {firstName}");
        //    Console.WriteLine($"Last Name: {lastName}");
        //    Console.WriteLine($"Mid Name: {midName}");
        //    Console.WriteLine($"Age: {age}");
        //    Console.WriteLine($"GPA: {gpa}");
        //    Console.WriteLine("================================");
        //}

        static void ShowInfo(string fullName, int age = 0, string address = "Hà Nội")
        {
            Console.WriteLine("Full name: " + fullName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Address: " + address);
        }
    }
}
