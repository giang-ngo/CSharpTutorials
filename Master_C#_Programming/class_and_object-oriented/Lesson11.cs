using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Tính chất đa hình
 */
namespace Master_C__Programming.class_and_object_oriented
{
    class BaseClass
    {
        public string Name { get; set; }
        protected long Salary { get; set; }
        public virtual void DoSomething()
        {
            Console.WriteLine("DoSomeThing in BaseClass");
        }



    }
    class DerivedClass : BaseClass
    {
        public new string Name { get; set; }
        public new long Salary { get; set; }
        public new void DoSomething()
        {
            Console.WriteLine("DoSomeThing in DerivedClass");
        }
    }

    class A
    {
        public virtual void DoSomething()
        {
            Console.WriteLine("DoSomething in class A");
        }
    }

    class B : A
    {
        public override sealed void DoSomething()
        {
            base.DoSomething();
            Console.WriteLine("DoSomething in class B");
        }
    }

    class C : B
    {
        public new void DoSomething()
        {
            Console.WriteLine("DoSomething in class C");
        }
    }
    internal class Lesson11
    {
        static void Main(string[] args)
        {
            C c = new C();
            c.DoSomething();
            A a = c;
            Console.WriteLine(new string('-',50));
            a.DoSomething();


            //DerivedClass derived = new DerivedClass();
            //derived.DoSomething();
            //BaseClass baseObj = derived;
            //baseObj.DoSomething();



            //// Khai báo mảng các đối tượng Shape
            //Shape[] shapes = new Shape[]
            //{
            //    new Circle(20),
            //    new Rectangle(20,30),
            //    new Triangle(30,40,50),
            //    new Circle(25),
            //    new Triangle(30,30,30),
            //    new Triangle(30,40,30),
            //};

            //// In thông tin về các đối tượng và chu vi
            //foreach (var shape in shapes)
            //{
            //    Console.WriteLine(shape);
            //    Console.WriteLine($"Chu vi: {shape.Perimeter()}");
            //    Console.WriteLine(); 
            //}
        }
    }

    class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        // Phương thức ảo để tính chu vi, sẽ được ghi đè trong các lớp con
        public virtual double Perimeter() => 0;
    }

    class Triangle : Shape
    {
        public double EdgeA { get; set; }
        public double EdgeB { get; set; }
        public double EdgeC { get; set; }

        public Triangle(double a, double b, double c)
        {
            EdgeA = a;
            EdgeB = b;
            EdgeC = c;
        }

        // Ghi đè phương thức Perimeter của Shape
        public override double Perimeter()
        {
            return EdgeA + EdgeB + EdgeC;
        }

        public override string ToString()
        {
            return $"Triangle[EdgeA = {EdgeA}, EdgeB = {EdgeB}, EdgeC = {EdgeC}]";
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Ghi đè phương thức Perimeter của Shape
        public override double Perimeter()
        {
            return 2 * (Width + Height);
        }

        public override string ToString()
        {
            return $"Rectangle[Width = {Width}, Height = {Height}]";
        }
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        // Ghi đè phương thức Perimeter của Shape
        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            return $"Circle[Radius = {Radius}]";
        }
    }
}
