using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.generic
{
    internal class Lesson2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<string> friends = new List<string>();
            friends.Add("Mai");
            friends.Add("Mây");
            friends.Add("Minh");
            friends.Add("Mạnh");
            friends.Add("Oanh");
            friends.Add("Nhân");
            friends.Add("Hướng");
            friends.Add("Trung");
            friends.Add("Ánh");
            friends.Add("Cảnh");
            Console.WriteLine("Trước khi sắp xếp: ");
            friends.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
            friends.Sort(CompareByLengthDESC);
            //friends.Reverse();
            Console.WriteLine("Sau khi sắp xếp: ");
            friends.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();


            //int[] numbers = new int[] { 1, 3, 43, 5, 655, 57, 0, 32, 21, 1000 };
            //List<int> list = new List<int>(numbers);
            //Console.WriteLine("Khả năng lưu trữ của list: " + list.Capacity);
            //Console.WriteLine("Số phần tử hiện có của list: " + list.Count);
            //list[1] = 99;
            //Console.WriteLine($"Phần tử tại vị trí 0: {list[1]}");
            //list.Add(200);
            //list.Add(100);
            //list.Add(900);

            //list.Insert(5, 800);
            //Console.WriteLine("Các phần tử của list: ");
            ////for (int i = 0; i < list.Count; i++)
            ////{
            ////    Console.Write(list[i]+" ");
            ////}
            ////Console.WriteLine();

            ////foreach (int i in list) Console.Write(i + " ");
            ////Console.WriteLine();

            //list.ForEach(x => Console.Write(x + " "));
            //Console.WriteLine();


        }

        private static int CompareASC(string str1, string str2)
        {
            return str2.CompareTo(str1);
        }

        static int CompareByLengthASC(string str1, string str2)
        {
            return str1.Length - str2.Length;
        }

        static int CompareByLengthDESC(string str1, string str2)
        {
            return str2.Length - str1.Length;
        }

    }
}
