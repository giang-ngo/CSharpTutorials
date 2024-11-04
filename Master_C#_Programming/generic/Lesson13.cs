using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.generic
{
    internal class Lesson13
    {
        // tìm hiểu về SortedList<K, V>
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            SortedList<string, int> list = new SortedList<string, int>(new MyComparer());
            list.Add("One", 1);
            list.Add("Five", 5);
            list.Add("Three", 3);
            list.Add("Six", 6);
            list.Add("Nine", 9);
            list.Add("Four", 4);

            // list.Add("Four", 4);
            ShowListElements(list);
            list.Remove("One");
            Console.WriteLine("==> Sau khi xóa: ");
            ShowListElements(list);
            Console.WriteLine("==> Key 'One' tồn tại trong list? " + list.ContainsKey("One"));
            Console.WriteLine("==> Value 5 tồn tại trong list? " + list.ContainsValue(5));
            Console.WriteLine("==> Phần tử vị trí 2 trong values: " + list.Values[2]);
            Console.WriteLine("==> Phần tử vị trí 2 trong keys: " + list.Keys[2]);
        }

        private static void ShowListElements(SortedList<string, int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        class MyComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return y.CompareTo(x);
            }
        }
    }
}
