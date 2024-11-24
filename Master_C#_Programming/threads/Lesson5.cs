using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Master_C__Programming.threads
{
    internal class Lesson5
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(DoSomeTask));
            thread.IsBackground = true;
            Console.WriteLine(thread.IsBackground);
            thread.Start();
        }

        static void DoSomeTask()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Task finished");
        }
    }
}
