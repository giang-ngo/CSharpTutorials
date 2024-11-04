using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.generic
{
    internal class Lesson14
    {
        // tìm hiểu lớp ArrayList
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var friends = new string[] { "Mai", "Nam", "Mạnh", "Long", "Phong", "Bách" };
            ArrayList list = new ArrayList(friends);
            //list.Add(100);
            //list.Add(true);

            Console.WriteLine("==> Số phần tử hiện có của list: " + list.Count);
            list.Sort(new MyComparer());
            ShowElements(list);
            list.Reverse();

            // xóa một số phần tử
            //list.Remove("Nam");
            //list.RemoveAt(0);
            Console.WriteLine("==> Kết quả sau xóa: ");
            ShowElements(list);
            var indexOfElement = list.IndexOf("Bách");
            Console.WriteLine("==> Vị trí của phần tử 'Bách': " + indexOfElement);
        }

        private static void ShowElements(ArrayList list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        class MyComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                var str1 = x as string;
                var str2 = y as string;
                return str2.CompareTo(str1);
            }
        }
    }
}
