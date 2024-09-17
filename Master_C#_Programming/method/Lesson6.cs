using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.method
{
    internal class Lesson6
    {
        static void Main(string[] args)
        {
            int a = int.Parse(args[0]);
            int b = int.Parse(args[1]);
            string op = args[2];
            switch (op)
            {
                case "add":
                    Console.WriteLine($"{a} + {b} = {a + b}");
                    break;
                case "sub":
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;
                case "mul":
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    break;
                case "div":
                    Console.WriteLine($"{a} / {b} = {1.0f * a / b}");
                    break;
                case "mod":
                    Console.WriteLine($"{a} % {b} = {a % b}");
                    break;
                default:
                    Console.WriteLine("Wrong operation");
                    break;
            }
        }
    }
}
