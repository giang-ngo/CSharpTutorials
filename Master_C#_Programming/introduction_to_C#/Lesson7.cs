using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.introduction_to_C_
{
    internal class Lesson7
    {
        static void Main()
        {
            int a = 5;
            int b = 6;
            int c = 7;
            Console.WriteLine($"a == b ? {a == b}");
            Console.WriteLine($"a != b ? {a != b}");
            Console.WriteLine($"a < b ? {a < b}");
            Console.WriteLine($"a <= b ? {a <= b}");
            Console.WriteLine($"a > b ? {a > b}");
            Console.WriteLine($"a >= b ? {a >= b}");
            Console.WriteLine($"a < b && a < c? {(a < b) && (a < c)}");
            Console.WriteLine($"a > b || a > c? {(a > b) || (a > c)}");
        }
    }
}
