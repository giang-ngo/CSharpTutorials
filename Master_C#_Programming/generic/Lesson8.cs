using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.generic
{
    internal class Lesson8
    {
        // tìm hiểu về Stack<T> của namespace System.Collections.Generic;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            var stack = new Stack<int>();
            var stack2 = new Stack<string>(new string[] { "a", "b", "c", "d" });

            Console.WriteLine($"Số phần tử của stack2: {stack2.Count()}");
            stack2.Push("e");
            stack2.Push("f");
            Console.WriteLine($"Phần tử top: {stack2.Pop()}");


            Console.WriteLine("Các phần tử trong stack2");
            var elements = stack2.ToArray();
            foreach (var item in elements)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine($"\"a\" có tồn tại trong stack ko? {stack2.Contains("a")}");
            Console.WriteLine($"\"xyz\" có tồn tại trong stack ko? {stack2.Contains("xyz")}");

            // xóa các phần tử
            stack2.Clear();

            Console.WriteLine($"Số phần tử của stack2: {stack2.Count()}");


        }
    }
}
