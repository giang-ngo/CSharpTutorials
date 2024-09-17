using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.control_structures
{
    internal class Lesson6
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var data = Console.ReadLine().Split(' ');
            int width = int.Parse(data[0]);
            int height = int.Parse(data[1]);
            // vẽ hình chữ nhật đặc bằng các dấu *
            for (int i = 1; i <= width; i++)
            {
                for (int j = 1; j <= height; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }

            //var data = Console.ReadLine().Split(' ');
            //int a = int.Parse(data[0]);
            //int b = int.Parse(data[1]);
            //int k = int.Parse(data[2]);
            //bool isExisted = false;
            //// tìm số đầu tiên chia hết cho k trong đoạn [a, b]
            //for (int i = a; i <= b; i++)
            //{
            //    if (i % k == 0)
            //    {
            //        Console.WriteLine(i);
            //        isExisted = true;
            //        break;
            //    }
            //}
            //if (!isExisted)
            //{
            //    Console.WriteLine("Không tồn tại kết quả thoả mãn");
            //}
            //Console.WriteLine("Các lệnh tiếp theo...");

            //var data = Console.ReadLine().Split(' ');
            //int a = int.Parse(data[0]);
            //int b = int.Parse(data[1]);
            //int k = int.Parse(data[2]);
            //bool isExisted = false;
            //// tìm số đầu tiên chia hết cho k trong đoạn [a, b]
            //for (int i = a; i <= b; i++)
            //{
            //    if (i % k != 0)
            //    {
            //        continue;
            //    }
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine("\nCác lệnh tiếp theo...");
        }
    }
}
