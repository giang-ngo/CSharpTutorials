using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.generic
{
    internal class Lesson9
    {
        // tìm hiểu về Queue<T> của namespace System.Collections.Generic;
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Queue<string> queue = new Queue<string>();
            // Queue<string> queue1 = new Queue<string>(10);
            Queue<string> queue2 = new Queue<string>(new List<string>() { "one", "two", "three" });
            Console.WriteLine("==> Số lượng phần tử trong hàng đợi: " + queue2.Count);
            queue2.Enqueue("four");
            queue2.Enqueue("five");
            queue2.Enqueue("six");
            Console.WriteLine("==> Phần tử đầu hàng đợi: " + queue2.Peek());
            Console.WriteLine("==> Phần tử vừa bị xóa: " + queue2.Dequeue());
            var elements = queue2.ToArray();
            Console.WriteLine("==> Các phần tử hiện có trong hàng đợi: ");
            foreach (var element in elements)
            {
                Console.WriteLine(element);
            }
            queue2.Clear();
            Console.WriteLine("==> Số lượng phần tử trong hàng đợi: " + queue2.Count);
        }
    }
}
