using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.control_structures
{
    internal class Lesson4
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số nguyên a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số nguyên b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhập số nguyên k: ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine($"Các giá trị trong đoạn [{a}, {b}] chia hết cho {k}:");
            for (int i = a; i <= b; i++)
            {
                if (i % k == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
