using System;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace Master_C__Programming.threads
{
    internal class Lesson7Ex2
    {
        static void Main()
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            Console.OutputEncoding = Encoding.UTF8;
            StartWebRequest(cts.Token);
            Console.WriteLine("==> Nhấn phím bất kỳ để kết thúc: ");
            Console.ReadKey();
            Console.WriteLine();
            cts.Cancel();
        }

        static void StartWebRequest(CancellationToken token)
        {
            var target = "https://developer.mozilla.org/en-US/docs/Web/JavaScript";
            var edgePath = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";
            Console.WriteLine("==> Bắt đầu mở yêu cầu truy cập trang web...");
            StartProcess(edgePath, target);
            // lắng nghe sử dụng callback
            token.Register(() =>
            {
                StopProcess("msedge");
                Console.WriteLine("==> Đã hủy yêu cầu mở trang web.");
            });
        }

        static void StopProcess(string name)
        {
            try
            {
                var processes = Process.GetProcessesByName(name);
                foreach (var process in processes)
                {
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
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}