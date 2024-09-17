using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.introduction_to_C_
{
    internal class Lesson5
    {
        /// <summary>
        /// tóm tắt chú thích về 1 tính năng nào đó
        /// </summary>
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            // hiển thị thông báo nhập tuổi
            Console.WriteLine("Nhập tuổi: ");
            int age = int.Parse(Console.ReadLine()); // chuyển đổi từ string sang int
            Console.WriteLine("Họ và tên: ");
            string fullName = Console.ReadLine();
            Console.WriteLine("Điểm TB: ");
            float gpa = float.Parse(Console.ReadLine());
            // hiển thị kết quả sau chuyển đổi
            Console.WriteLine($"Họ và tên: {fullName}");
            Console.WriteLine("Tuổi: {0}", age);
            Console.WriteLine("Điểm TB: " + gpa);
        }
    }
}
