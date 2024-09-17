using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.method
{
    internal class Lesson3
    {
        static void Main()
        {
            //double a = 20;
            //double b = 50;
            //Console.WriteLine(Max(20, 30.25));
            int a = 200;
            int b = 500;
            int c = 700;
            int d = 100;
            Console.WriteLine($"Max({a}, {b}) = {Max(a, b)}");
            Console.WriteLine($"Max({a}, {b}, {c}) = {Max(a, b, c)}");
            Console.WriteLine($"Max({a}, {b}, {c}, {d}) = {Max(a, b, c, d)}");
        }

        static int Max(int a, int b)
        {
            return Max(a, b, Int32.MinValue);
        }

        static int Max(int a, int b, int c)
        {
            return Max(a, b, c, Int32.MinValue);
        }

        static int Max(int a, int b, int c, int d)
        {
            int max1 = Math.Max(a, b);
            int max2 = Math.Max(b, c);
            return Math.Max(max1, max2);
        }
    }
}
