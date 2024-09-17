using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.control_structures
{
    internal class Lesson5
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            ////example of while loop
            //int n = int.Parse(Console.ReadLine());
            //int m = n;
            //int sumDigits = 0;
            //while (n > 0)
            //{
            //    sumDigits += n % 10;
            //    n /= 10;
            //}
            //Console.WriteLine($"Tổng các chữ số của {m}: {sumDigits}");

            //example of do while loop
            int n = int.Parse(Console.ReadLine());
            int m = n;
            int sumDigits = 0;
            do
            {
                sumDigits += n % 10;
                n /= 10;
            } while (n > 0);
            Console.WriteLine($"Tổng các chữ số của {m}: {sumDigits}");

        }
    }
}
