using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Master_C__Programming.threads
{
    internal class Lesson2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // tạo đối tượng đóng gói thông tin và hành động cần thực hiện
            var copy1 = new CopyFile("input1.txt", "OUTPUT1.txt");
            var copy2 = new CopyFile("input2.txt", "OUTPUT2.txt");
            var copy3 = new CopyFile("input3.txt", "OUTPUT3.txt");

            // tạo ra các luồng để thực thi song song việc sao chép file
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
            Console.WriteLine("==> Tất cả hành động sao chép file hoàn tất");
        }

    }

    class CopyFile
    {
        public string InputFileName { get; set; }
        public string OutputFileName { get; set; }
        public CopyFile(string input, string output)
        {
            InputFileName = input;
            OutputFileName = output;
        }

        public void Copy()
        {
            var data = File.ReadAllText(InputFileName);
            File.WriteAllText(OutputFileName, data);
            Thread.Sleep(5000);
            Console.WriteLine($"==> Copy file {InputFileName} hoàn tất");
        }
    }
}
