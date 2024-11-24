using System;
using System.Text;
using System.Threading;

namespace Master_C__Programming.threads
{
    class SyncResource
    {
        public void Access()
        {
            lock (this)
            {
                Console.WriteLine($"==> Bắt đầu đồng bộ hóa truy cập tài nguyên trên thread " +
                    $"#{Thread.CurrentThread.ManagedThreadId}");
                if (Thread.CurrentThread.ManagedThreadId % 2 == 0)
                {
                    Thread.Sleep(2000);
                }
                Thread.Sleep(300);
                Console.WriteLine($"==> Dừng đồng bộ hóa truy cập tài nguyên trên thread " +
                    $"#{Thread.CurrentThread.ManagedThreadId}");
            }
        }
    }

    class UnSyncResource
    {
        public void Access()
        {
            Console.WriteLine($"==> Bắt đầu truy cập tài nguyên không đồng bộ trên thread " +
                $"#{Thread.CurrentThread.ManagedThreadId}");
            if (Thread.CurrentThread.ManagedThreadId % 2 == 0)
            {
                Thread.Sleep(2000);
            }
            Thread.Sleep(300);
            Console.WriteLine($"==> Dừng truy cập tài nguyên không đồng bộ trên thread " +
                $"#{Thread.CurrentThread.ManagedThreadId}");
        }
    }

    class Lesson8Ex2
    {
        private static SyncResource syncResource = new SyncResource();
        private static UnSyncResource unSyncResource = new UnSyncResource();
        private static int numOps; // số lần thực hiện lời gọi
        private static AutoResetEvent opsAreDone = new AutoResetEvent(false);

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            numOps = 5;// gọi tới phương thức đồng bộ hóa 5 lần
            for (int i = 0; i < 5; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(SyncUpdateResource));
            }
            opsAreDone.WaitOne(); // chờ tới khi trình xử lý chờ đợi được tín hiệu kích hoạt
            Console.WriteLine("==> Tất cả các lời gọi đồng bộ hóa hoàn tất.");
            Console.WriteLine("================================================");
            numOps = 5;// gọi tới phương thức bất đồng bộ 5 lần
            for (int i = 0; i < 5; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(UnSyncUpdateResource));
            }
            opsAreDone.WaitOne(); // chờ tới khi trình xử lý chờ đợi được tín hiệu kích hoạt
            Console.WriteLine("==> Tất cả các lời gọi bất đồng bộ hoàn tất.");
        }

        static void SyncUpdateResource(Object state)
        {
            syncResource.Access(); // gọi phương thức truy cập tài nguyên đồng bộ
            if (Interlocked.Decrement(ref numOps) == 0)
            {
                opsAreDone.Set();
            }
        }

        static void UnSyncUpdateResource(Object state)
        {
            unSyncResource.Access(); // gọi phương thức truy cập tài nguyên bất đồng bộ
            if (Interlocked.Decrement(ref numOps) == 0)
            {
                opsAreDone.Set();
            }
        }
    }
}