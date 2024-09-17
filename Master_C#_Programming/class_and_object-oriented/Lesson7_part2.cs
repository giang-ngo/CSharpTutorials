using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Tính kế thừa
 */
namespace Master_C__Programming.class_and_object_oriented
{
    internal class Lesson7_part2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Student student = new Student("001", 3.65f, "CNTT");
            Student student1 = new Student("003", 3.65f, "CNTT");
            Console.WriteLine(student1.Equals(student));
            Console.WriteLine(student1);

            //student.FirstName = "Hoàng";
            //student.LastName = "Trần";
            //student.MidName = "Huy";
            //student.Age = 20;
            //Console.WriteLine($"Họ tên: {student.LastName} {student.MidName} {student.FirstName}");
            //// truy cập tới các thành phần riêng của lớp con
            //Console.WriteLine("Mã SV: " + student.StudentId);
            //Console.WriteLine($"Điểm TB: " + student.Gpa);

            //Circle circle = new Circle();
            //circle.Radius = 20;
            //Console.WriteLine("Chu vi: " + circle.Perimeter());
            //Console.WriteLine("Diện tích: " + circle.Area());
        }
    }
    class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Name { get; set; }
        public virtual double Area()
        {
            return 0;
        }
        public virtual double Perimeter()
        {
            return 0;
        }
    }
    class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override double Perimeter()
        {
            return Math.PI * Radius * 2;
        }
    }
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return Width * Height;
        }
        public override double Perimeter()
        {
            return 2 * (Width + Height);
        }
    }
    class Father
    {
        public virtual void DoSomething(string something)
        {

        }
    }
    class Child : Father
    {
        public override void DoSomething(string something)
        {
            //..
        }
    }
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MidName { get; set; }
        public int Age { get; set; }
        public Person()
        {

        }

        public void Sleep()
        {

        }
    }

    class Student : Person
    {
        public string StudentId { get; set; }
        public float Gpa { get; set; }
        public string Major { get; set; }
        public Student()
        {

        }
        public Student(string id, float gpa, string major)
        {
            StudentId = id;
            Gpa = gpa;
            Major = major;
        }
        public void DoHomeWork(string subject)
        {

        }

        public void DoExam(string subject)
        {

        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            var other = (Student)obj;
            return other.StudentId.CompareTo(StudentId) == 0;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString() => $"Student[StudentId={StudentId}, Gpa={Gpa}, Major={Major}]";

    }
}
