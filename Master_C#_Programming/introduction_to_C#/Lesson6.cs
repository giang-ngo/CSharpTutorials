using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.introduction_to_C_
{
    internal class Lesson6
    {
        static void Main()
        {
            float a = 20.25f;
            int b = 30;
            var sum = a + b; // sum kiểu float
            Console.WriteLine(sum);
            Console.WriteLine(sum.GetType().Name);
            // phép chia
            Console.WriteLine(1.0 * 2 / 3);
            Console.WriteLine(2.0 / 3);
            Console.WriteLine(-2 / 0.0);
            // ví dụ ép kiểu
            int x = 2;
            int y = 3;
            Console.WriteLine((float)x / y);
            Console.WriteLine(a % b);
            Console.WriteLine(-2 % -3);

            // phép tăng giảm ++ --
            x = 1;
            y = x++;
            int z = --y;
            Console.WriteLine($"x = {x}, y = {y}, z = {z}");
            string str1 = "Today";
            string str2 = " is Monday";
            var str = str1 + str2;
            Console.WriteLine(str);
            x = 5;
            x += 5;
            Console.WriteLine(x);
        }
    }
}
