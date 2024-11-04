using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.generic
{
    internal class Lesson10
    {
        // tìm hiểu LinkedList<T> của namespace System.Collections.Generic;
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var elements = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday" };
            LinkedList<string> list = new LinkedList<string>(elements);
            Console.WriteLine("==> Số phần tử hiện có của DSLK: " + list.Count);
            Console.WriteLine("==> Phần tử đầu của DSLK: " + list.First.Value);
            Console.WriteLine("==> Phần tử cuối của DSLK: " + list.Last.Value);
            Console.WriteLine("==> Phần tử tiếp theo của phần tử first trong DSLK: " +
                list.First.Next.Value);
            Console.WriteLine("==> Phần tử liền trước của phần tử first trong DSLK: " +
                (list.First.Previous == null ? "null" : ""));


            // lấy node thứ hai của danh sách
            LinkedListNode<string> node = list.First.Next; // Tuesday


            // các phương thức
            list.AddFirst("Sunday");
            list.AddLast("Friday");
            Console.WriteLine("==> Các phần tử trong danh sách LK hiện tại: ");
            ShowNodes(list);
            list.AddAfter(node, "Saturday");
            list.AddBefore(node, "Saturday");
            Console.WriteLine("==> Các phần tử trong DSLK sau chèn: ");
            ShowNodes(list);


            // xóa node đầu:
            list.RemoveFirst();
            Console.WriteLine("==> Các phần tử trong DSLK sau xóa node first: ");
            ShowNodes(list);


            // xóa node cuối
            list.RemoveLast();
            Console.WriteLine("==> Các phần tử trong DSLK sau xóa node last: ");
            ShowNodes(list);


            // xóa node được chỉ định
            list.Remove("Wednesday");
            Console.WriteLine("==> Các phần tử trong DSLK sau xóa node 'Wednesday': ");
            ShowNodes(list);


            // kiểm tra một giá trị có tồn tại trong DSLK không
            Console.WriteLine("==> 'Friday' có tồn tại trong DSLK? " + list.Contains("Friday"));
            Console.WriteLine("==> 'Monday' có tồn tại trong DSLK? " + list.Contains("Monday"));
            list.Clear();
        }

        private static void ShowNodes(LinkedList<string> list)
        {

            foreach (var item in list)
            {
                Console.Write(item + " -> ");
            }
            Console.WriteLine("null");
        }
    }
}
