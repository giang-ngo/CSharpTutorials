using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.method
{
    internal class Lesson7
    {
        static void Main()
        {
            // n! = n * (n - 1)!
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine($"{n}! = {Factorial(n)}");
        }

        static ulong Factorial(uint n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
