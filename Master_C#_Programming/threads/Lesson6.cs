using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Master_C__Programming.threads
{
    internal class Lesson6
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread thread = new Thread(SleepIndefinitely);
            thread.Name = "Sleeping Thread 1";
            thread.Start();
            Thread.Sleep(2000);
            thread.Interrupt();

            Thread.Sleep(1000);

            thread = new Thread(SleepIndefinitely);
            thread.Name = "Sleeping Thread 2";
            thread.Start();
            Thread.Sleep(3000);
            thread.Abort();
        }

        static void SleepIndefinitely()
        {
            Console.WriteLine($"==> {Thread.CurrentThread.Name} chuẩn bị lặp vô thời hạn");
            try
            {
                Thread.Sleep(Timeout.Infinite);
            }
            catch (ThreadInterruptedException)
            {
                Console.WriteLine($"==> {Thread.CurrentThread.Name} được đánh thức");
            }
            catch (ThreadAbortException)
            {
                Console.WriteLine($"==> {Thread.CurrentThread.Name} đã bị hủy");
            }
            finally
            {
                Console.WriteLine($"==> {Thread.CurrentThread.Name} thực hiện các công việc trong khối finally");
            }
            Console.WriteLine($"==> {Thread.CurrentThread.Name} kết thúc bình thường");
            Console.WriteLine(new string('-', 80));

        }
    }
}
