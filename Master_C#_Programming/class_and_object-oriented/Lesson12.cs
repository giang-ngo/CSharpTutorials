using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExtensions
{
    public static class Extensions
    {
        public static int CountWord(this string str)
        {
            var data = Split(str);
            return data.Length;
        }

        public static string[] Split(this string str)
        {
            var spliter = new char[] { ' ', '\t', ',', ':', ';', '!', '?' };
            return str.Split(spliter, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}

namespace Master_C__Programming.class_and_object_oriented
{
    using CustomExtensions;
    internal class Lesson12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            var input = Console.ReadLine();
            Console.WriteLine("Word list: ");
            foreach (var item in Extensions.Split(input))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Number of word in string: " + Extensions.CountWord(input));
        }
    }
}
