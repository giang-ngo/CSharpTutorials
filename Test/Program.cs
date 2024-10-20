using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DirectoryInfo dir = new DirectoryInfo(@"D:\windows\web\wallpaper");
            Console.WriteLine("=========================================");
            Console.WriteLine("======> Thông tin thư mục: ");
            Console.WriteLine("Họ tên: "+dir.FullName);
            Console.WriteLine("Tên: "+dir.Name);
            Console.WriteLine("Parent: "+dir.Parent);
            Console.WriteLine("Thời gian tạo: "+dir.CreationTime);

            //var path = @"D:\C#_test\Example_Create_Folder";

            //DirectoryInfo dir = new DirectoryInfo(path);
            //dir.CreateSubdirectory(@"f1\f2\f3\fn");

        }
    }
}
