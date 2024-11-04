using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.generic
{
    internal class Lesson11
    {
        // tìm hiểu HashSet<T>
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var friends = new string[] { "Hoàng", "Nam", "Nhân", "Mai", "Long" };
            var friends2 = new string[] { "Hoàng", "Nam", "Mạnh", "Mai", "Hưng", "Quân" };
            HashSet<string> set1 = new HashSet<string>(friends);
            HashSet<string> set2 = new HashSet<string>(friends2);
            Console.WriteLine("==> Set1: ");
            PrintElements(set1);
            Console.WriteLine("==> Set2: ");
            PrintElements(set2);
            set1.IntersectWith(set2);
            Console.WriteLine("==> Các phần tử chung của 2 set: ");
            PrintElements(set1);
            set2.ExceptWith(set1);
            Console.WriteLine("==> Các phần tử riêng của set2: ");
            PrintElements(set2);
            //set.Add("Linh");
            //set.Add("Linh");
            //set.Add("Linh");
            //set.Add("Linh");
            //set.Add("Linh");
            //Console.WriteLine("==> Số phần tử của set: " + set.Count);
            //PrintElements(set);
            //set.Remove("Linh");
            //PrintElements(set);
            //var isExisted = set.Contains("Nam");
            //Console.WriteLine("'Khánh' có tồn tại trong set không? " + 
            //  (isExisted ? "Có" : "Không"));
        }

        private static void PrintElements(HashSet<string> set)
        {
            Console.WriteLine("==> Các phần tử trong set: ");
            foreach (var item in set)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
