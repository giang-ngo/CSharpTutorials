using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.introduction_to_C_
{
    internal class Lesson1
    {
        static void Main()
        {
            var originalFg = Console.ForegroundColor;
            var originalBg = Console.BackgroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Hello CSharp!");
            Console.WriteLine("I'm Giang Ngo");
            Console.WriteLine("I'm 21");
            Console.ForegroundColor = originalFg;
            Console.BackgroundColor = originalBg;
        }
    }
}
