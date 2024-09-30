using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.class_and_object_oriented
{
    internal class Lesson14
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var circle = new Circle();
            Console.WriteLine($"Chu vi: {circle.Perimeter:f2}");
            Console.WriteLine($"Diện tích: {circle.Area:f2}");

        }
    }

    /*
    class Circle
    {
        public double Perimeter { get; set; }
        public double Area { get; set; }
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
            Area = Math.PI * Radius * Radius;
            Perimeter = 2 * Math.PI * Radius;
        }
    }*/

    class Point(int x, int y)
    {
        public int X { get; set; } = x;
        public int Y { get; set; } = y;
    }

    // C# 12
    class Circle(double r = 0)
    {
        public double Perimeter { get; set; } = 2 * Math.PI * r;
        public double Area { get; set; } = Math.PI * r * r;
        public double Radius { get; set; } = r;
        public Point Center { get; set; }

        public Circle() : this(0)
        {
            //Radius= 0;
        }

        public Circle(double radius, Point center) : this(radius)
        {
            Center = center;
        }

        public void Resize(double delta)
        {
            r += delta;
        }
    }
}
