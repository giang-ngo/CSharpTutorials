using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.introduction_to_C_
{
    internal class Lesson3
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Giá trị max cua kiểu int: {Int32.MaxValue}");
            Console.WriteLine($"Giá trị min cua kiểu int: {Int32.MinValue}");
            Console.WriteLine($"Giá trị max cua kiểu long: {Int64.MaxValue}");
            Console.WriteLine($"Giá trị min cua kiểu long: {Int64.MinValue}");
            Console.WriteLine($"Giá trị max cua kiểu ulong: {UInt64.MaxValue}");
            Console.WriteLine($"Giá trị min cua kiểu ulong: {UInt64.MinValue}");
            string fullName = "Tran Van Nam";
            bool isMarried = true;
            int age = 21;
            Console.WriteLine("Hello " + fullName);
            Console.WriteLine(age);
            Console.WriteLine(isMarried);

        }
    }
}
