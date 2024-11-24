using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Master_C__Programming.threads
{
    internal class Lesson1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var obj = new Lesson1();
            Thread instanceThread = new Thread(new ThreadStart(obj.InstanceMethod));
            Thread staticThread = new Thread(new ThreadStart(StaticMethod));

            Console.WriteLine("==> Trước khi gọi khởi chạy 2 thread:");
            instanceThread.Start();
            staticThread.Start();
            Console.WriteLine("==> Kết thúc chương trình");
        }

        static void StaticMethod()
        {
            Console.WriteLine("==> Phương thức static đang được thực thi bởi thread khác.");
            Thread.Sleep(5000);
            Console.WriteLine("==> Phương thức static đã kết thúc");
        }

        void InstanceMethod()
        {
            Console.WriteLine("==> Phương thức instance đang được thực thi bởi thread khác.");
            Thread.Sleep(7000);
            Console.WriteLine("==> Phương thức instance đã kết thúc");
        }
    }
}
