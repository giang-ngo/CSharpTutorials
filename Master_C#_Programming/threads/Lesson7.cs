using System;
using System.Text;
using System.Threading;

namespace Master_C__Programming.threads
{
    internal class Lesson7
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            CancellationTokenSource cts = new CancellationTokenSource();
            ThreadPool.QueueUserWorkItem(new WaitCallback(DoSomeWork), cts.Token);
            Thread.Sleep(4000);
            // tiến hành hủy
            cts.Cancel();
            Console.WriteLine("==> Tiến hành hủy luồng...");
            Thread.Sleep(3000);
            cts.Dispose(); // giải phóng đối tượng
        }

        static void DoSomeWork(object obj)
        {
            CancellationToken token = (CancellationToken)obj;
            for (int i = 0; i < 100000; i++)
            {
                // lắng nghe kiểu thăm dò
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("==> Yêu cầu hủy được thực thi ở vòng lặp thứ " + (i + 1));
                    Console.WriteLine("...");
                    break;
                }
                Thread.SpinWait(50000);
            }
        }
    }
}