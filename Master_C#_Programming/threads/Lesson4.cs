using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.threads
{
    internal class Lesson4
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var target = "https://www.google.com/";
            var otherTarget = "https://developer.mozilla.org/en-US/docs/Web/JavaScript";
            var edgePath = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";
            var fireFoxPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";

            StartProcess(edgePath, target);
            StartProcess(fireFoxPath, otherTarget);

            Console.WriteLine("Nhấn phím bất kỳ để kết thúc:");
            Console.ReadKey();
            StopProcess("msedge");
            StopProcess("firefox");
        }

        private static void StopProcess(string edgePath)
        {
            try
            {
                var processes = Process.GetProcessesByName(edgePath);
                foreach (var process in processes)
                {
                    var threads = process.Threads;
                    foreach (ProcessThread thread in threads)
                    {
                        Console.WriteLine("Thread Id: " + thread.Id);
                        Console.WriteLine("Thread PriorityLevel: " + thread.PriorityLevel);
                    }
                    process.Kill();
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e);
            }
        }

        static void StartProcess(string path, string target)
        {
            try
            {
                Process.Start(path, target);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
