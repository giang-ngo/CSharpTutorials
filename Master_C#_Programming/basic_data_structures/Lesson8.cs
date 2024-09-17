using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.basic_data_structures
{
    struct Point
    {
        public Point(int x, int y, string label)
        {
            this.x = x;
            this.y = y;
            this.label = label;
        }
        public int x = 0;
        public int y = 0;
        public string label = "";

        public override string ToString()
        {
            return $"{label} ({x}, {y})";
        }
    }

    struct Triangle
    {
        public Triangle(Point a, Point b, Point c)
        {
            A = a; B = b; C = c;
        }
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }

        public override string ToString() => $"Triangle ({A}, {B}, {C})";

        internal class Lesson8
        {
            struct Rectangle
            {
                public Rectangle(int x, int y)
                {
                    X = x;
                    Y = y;
                }
                public Rectangle(int x, int y, int width, int height)
                {
                    X = x;
                    Y = y;
                    Width = width;
                    Height = height;
                }

                public int X { get; set; } = 0;
                public int Y { get; set; } = 0;
                public int Width { get; set; } = 20;
                public int Height { get; set; } = 20;
                public string name = "X";

            }
            static void Main(string[] args)
            {
                //Rectangle rect = new Rectangle(10, 25);
                //Console.WriteLine(rect.Width);
                //Console.WriteLine(rect.Height);

                Point p = new Point(1, 2, "A");
                Point p2 = new Point(5, 3, "B");
                Point p3 = new Point(10, 5, "C");

                //Console.WriteLine(p);
                //Console.WriteLine(p2);

                Triangle triangle = new Triangle(p, p2, p3);
                Console.WriteLine(triangle);
            }
        }
    }
}
