using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Master_C__Programming.threads
{
    public delegate void PrintMessageDelegate(string message);

    internal class Lesson3
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // tạo đối tượng đóng gói thông tin và hành động cần thực hiện
            var copy1 = new CopyFile("input6.txt", "OUTPUT1.OUT", PrintMessage);
            var copy2 = new CopyFile("input5.txt", "OUTPUT2.OUT", PrintMessage);
            var copy3 = new CopyFile("input3.txt", "OUTPUT3.OUT", PrintMessage);

            // tạo các luồng để thực thi song song việc sao chép file
            Thread copyThread1 = new Thread(new ThreadStart(copy1.Copy));
            Thread copyThread2 = new Thread(new ThreadStart(copy2.Copy));
            Thread copyThread3 = new Thread(new ThreadStart(copy3.Copy));

            // kích hoạt các luồng
            copyThread1.Start();
            copyThread2.Start();
            copyThread3.Start();

            // điều hướng thread về main thread
            copyThread1.Join();
            copyThread2.Join();
            copyThread3.Join();

            // thông báo kết thúc
            Console.WriteLine("==> Kết thúc phương thức Main.");
        }

        public static void PrintMessage(string message)
        {
            Console.WriteLine("==> Thông điệp nhận được từ thread: " + message);
        }
    }

    class CopyFile
    {
        public string InputFileName { get; set; }
        public string OutputFileName { get; set; }

        private PrintMessageDelegate printCallback;

        public CopyFile(string input, string output, PrintMessageDelegate del)
        {
            InputFileName = input;
            OutputFileName = output;
            printCallback = del;
        }

        public void Copy()
        {
            try
            {
                var data = File.ReadAllText(InputFileName);
                File.WriteAllText(OutputFileName, data);
                //Thread.Sleep(3000);
                printCallback($"Copy file {InputFileName} hoàn tất.");
            }
            catch (FileNotFoundException e)
            {
                printCallback(e.Message);
            }
        }
    }
}
