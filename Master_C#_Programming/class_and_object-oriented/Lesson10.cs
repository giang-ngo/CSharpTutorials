using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.class_and_object_oriented
{
    class Student : IComparable<Student>
    {
        public string StudentId { get; set; }
        public string FullName { get; set; }
        public float Gpa { get; set; }
        public Student(string id, string fullName, float gpa)
        {
            StudentId = id;
            FullName = fullName;
            Gpa = gpa;
        }

        public override string ToString()
        {
            return $"{StudentId,-10}{FullName,-20}{Gpa,-10}";
        }

        public int CompareTo(Student other)
        {
            if (Gpa == other.Gpa)
            {
                return 0;
            }
            else if (Gpa < other.Gpa)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }

    public interface IControl
    {
        void Paint();
    }

    public interface ISurface
    {
        void Paint();
    }

    public class SampleClass : IControl, ISurface
    {
        void IControl.Paint()
        {
            Console.WriteLine("IControl.Paint in SampleClass");
        }

        public void Paint()
        {
            Console.WriteLine("ISurface.Paint in SampleClass");
        }
    }

    internal class Lesson10
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Student[] students = new Student[]
            {
                new Student("1001,","Hoàng Thị Tâm",3.29f),
                new Student("1002,","Nguyễn Ngọc Anh",3.5f),
                new Student("1003,","Ngô Diệc Phong",3.8f),
                new Student("1004,","Mai Văn Hải",3.56f),
                new Student("1005,","Hứa Thùy Dung",2.97f),
                new Student("1005,","Lê Trần Đạt",3.1f),
            };
            Console.WriteLine("Trước khi sắp xếp: ");
            ShowData(students);
            Console.WriteLine("Sau khi sắp xếp: ");
            Array.Sort(students);
            ShowData(students);


            //SampleClass obj = new SampleClass();
            //IControl control = obj;
            //ISurface surface = obj;
            //obj.Paint();

            //control.Paint();
            //surface.Paint();

            //Circle circle = new Circle(0, 0, 5);
            //IShape ishape = new Circle(1, 1, 8);
            //Console.WriteLine($"Chu vi đường tròn r = {circle.Radius}: {circle.Perimeter()}");
            //Console.WriteLine($"Diện tích đường tròn r = {circle.Radius}: {circle.Area()}");
            //Console.WriteLine(new string('-',50));
            //Console.WriteLine($"Chu vi đường tròn r = {((Circle)ishape).Radius}: {ishape.Perimeter()}");
            //Console.WriteLine($"Diện tích đường tròn r = {((Circle)ishape).Radius}: {ishape.Area()}");
        }

        public static void ShowData(Student[] students)
        {
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }
    }

    public interface IShape
    {
        int X { get; set; }
        int Y { get; set; }

        double Area();
        double Perimeter();
    }

    class Circle : IShape
    {
        private int _x;
        private int _y;
        public double Radius { get; set; }
        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }
        public Circle(int x, int y, double r)
        {
            X = x;
            Y = y;
            Radius = r;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    interface IPoint
    {
        int X { get; set; }
        int Y { get; set; }

        double Distance(IPoint other);
    }
}
