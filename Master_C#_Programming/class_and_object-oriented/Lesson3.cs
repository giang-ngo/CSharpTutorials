using System;
using static System.Console;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.class_and_object_oriented
{
    internal class Lesson3
    {
        static public string Message { get; set; }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;// hiển thị tiếng việt
            //var obj = new Test();
            //int sum = obj.Add(1, 2, 3);
            //var msg = Message = "Hello";
            //WriteLine(msg);
            //WriteLine("Căn bậc 2 của 100 " + Sqrt(100));
            //string fullName = ReadLine();

            WriteLine("Id ban đầu: " + Employee.AutoIncrementId);
            Employee emp1 = new Employee("Hoàng Thanh Tùng", 25_000_000);
            Employee emp2 = new Employee("Lê Quỳnh Trang", 35_000_000);
            Employee emp3 = new Employee("Trương Việt Hoàng", 19_000_000);
            WriteLine("Id sau khi tạo 3 đối tượng: " + Employee.AutoIncrementId);
        }

        int Add(int a, int b, int c) => a + b + c;
    }

    class Employee
    {

        static Employee()//static constructor
        {
            fine = 100_000;//100k
            AutoIncrementId = 1000;//mã nhân viên

        }

        //instance constructor
        public Employee(string fullName, long salary)
        {
            EmpId = AutoIncrementId++;
            FullName = fullName;
            Salary = salary;

        }

        public static int AutoIncrementId { get; set; }
        public static long fine;//tiền phạt
        public int EmpId { get; set; }// mã nhân viên   
        public string FullName { get; set; }// họ và tên
        public long Salary { get; set; }// mức lương
    }
}
