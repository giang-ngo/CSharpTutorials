using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.exception
{
    internal class Lesson1
    {
        static double Div(int a, int b)
        {
            if (b == 0)
            {
                throw new Exception("Không thể chia cho 0");
            }
            return a / b;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a = 120;
            int b = 0;
            try
            {

                Console.WriteLine($"{a} / {b} = {Div(a, b)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            Console.WriteLine("Next statement");
            Console.WriteLine("Next statement");
        }
    }
}
