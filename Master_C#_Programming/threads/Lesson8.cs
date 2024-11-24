using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Master_C__Programming.threads
{
    internal class Lesson8
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Task> tasks = new List<Task>();
            Random random = new Random();// đối tượng sinh số ngẫu nhiên
            long total = 0; // tổng của tất cả các số ngẫu nhiên đã tạo ra
            int n = 0;  // số lượng các số ngẫu nhiên đã sinh ra

            for (int i = 0; i < 10; i++)
            {
                tasks.Add(Task.Run(() =>
                {
                    int[] values = new int[10000];
                    int taskN = 0;
                    int ctr = 0;
                    int taskTotal = 0;
                    Monitor.Enter(random);
                    for (ctr = 0; ctr < values.Length; ctr++)
                    {
                        values[ctr] = random.Next(0, 1001);
                        taskTotal += values[ctr];
                    }
                    Monitor.Exit(random);
                    taskN = ctr;
                    Console.WriteLine($"==> Trung bình cộng task #{Task.CurrentId,-2:d}: " +
                        $"{(taskTotal * 1.0 / taskN),2:f} (N = {taskN:N0})");
                    Interlocked.Add(ref total, taskTotal);
                    Interlocked.Add(ref n, taskN);
                }));
            }

            try
            {
                Task.WaitAll(tasks.ToArray());
                Console.WriteLine(new string('-', 80));
                Console.WriteLine($"Trung bình cộng của tất cả các task: {total * 1.0 / n,2:f} (N = {n:N0})");
            }
            catch (AggregateException ex)
            {
                foreach (var item in ex.InnerExceptions)
                {
                    Console.WriteLine(item.GetType().Name + ": " + item.Message);
                }
            }

        }
    }
}
