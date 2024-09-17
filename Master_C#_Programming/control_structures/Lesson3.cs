using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.control_structures
{
    internal class Lesson3
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = int.Parse(Console.ReadLine());
            string result = n < 0 ? "là số âm" : n == 0 ? "không âm, không dương" : "số dương";
            Console.WriteLine(result);
        }
    }
}
