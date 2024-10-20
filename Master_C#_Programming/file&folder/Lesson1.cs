using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.file_folder
{
    internal class Lesson1
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            // tạo file

            var fileName = "input.txt";
            FileInfo fileInfo = new FileInfo(fileName);
            var fs = fileInfo.Create();
            // do something
            fs.Close();
            //fileInfo.Delete();

            // mở file input.txt để đọc ghi dữ liệu
            var fileToOpen = "input.txt";
            FileInfo file = new FileInfo(fileToOpen);
            var reader = file.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            try
            {
                int data;
                while ((data = reader.ReadByte()) != -1)
                {
                    // do something here
                }
            }
            finally
            {
                Console.WriteLine("Đã chạy xong");
                reader.Close();
            }




            //var path = @"D:\windows\web\wallpaper";
            //DirectoryInfo dir = new DirectoryInfo(path);
            //dir.Create();
            //if (dir.Exists)
            //{
            //    Console.WriteLine("=========================================");
            //    Console.WriteLine("======> Thông tin thư mục: ");
            //    Console.WriteLine("Họ tên: " + dir.FullName);
            //    Console.WriteLine("Tên: " + dir.Name);
            //    Console.WriteLine("Parent: " + dir.Parent);
            //    Console.WriteLine("Thời gian tạo: " + dir.CreationTime);
            //    Console.WriteLine("Attributes: " + dir.Attributes);
            //    Console.WriteLine("Root: " + dir.Root);
            //    Console.WriteLine("=========================================");

            //    //var folders = dir.GetDirectories();
            //    //foreach (var item in folders)// duyệt qua các folder
            //    //{
            //    //    foreach (var file in item.GetFiles())// duyệt bên trong các folder là các file
            //    //    {
            //    //        Console.WriteLine($"Tên file: " + file.Name);
            //    //        Console.WriteLine($"Kích thương file: " + file.Length);
            //    //        Console.WriteLine($"Thuộc tính: " + file.Attributes);
            //    //        Console.WriteLine($"Thời gian tạo: " + file.CreationTime);
            //    //    }

            //    //}

            //    var files = dir.GetFiles("*.png", SearchOption.AllDirectories);
            //    foreach (var item in files)// duyệt qua các folder
            //    {
            //        Console.WriteLine($"Tên file: " + item.Name);
            //        Console.WriteLine($"Kích thương file: " + item.Length);
            //        Console.WriteLine($"Thuộc tính: " + item.Attributes);
            //        Console.WriteLine($"Thời gian tạo: " + item.CreationTime);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Thư mục không tồn tại");
            //}

            // tạo thư mục
            //var path = @"D:\C#_test\Example_Create_Folder";

            //DirectoryInfo dir = new DirectoryInfo(path);
            //dir.CreateSubdirectory(@"f1\f2\f3\fn");
        }
    }
}
