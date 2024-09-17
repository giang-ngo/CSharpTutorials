using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.control_structures
{
    internal class Lesson1
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập một số nguyên: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine($"{n} là số âm.");
            }
            else if (n == 0)
            {
                Console.WriteLine($"{n} là số không âm, không dương.");
            }
            else
            {
                Console.WriteLine($"{n} là số dương.");
            }
        }
    }
}
