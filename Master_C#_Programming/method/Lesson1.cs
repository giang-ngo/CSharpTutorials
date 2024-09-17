using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.method
{
    internal class Lesson1
    {
        static void Main()
        {
            // nhập vào số bộ test
            int t = int.Parse(Console.ReadLine());
            // lần lượt nhập từng bộ test
            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Lesson1 obj = new Lesson1();
                // kiểm tra và đưa ra kết luận n có hoàn hảo không
                if (obj.IsPerfectNumber(n))
                {
                    Console.WriteLine($"Test {i}: YES");
                }
                else
                {
                    Console.WriteLine($"Test {i}: NO");
                }
            }
        }

        bool IsPerfectNumber(int number)
        {
            int sum = 0;
            // tính tổng ước
            for (int k = 1; k < number; k++)
            {
                if (number % k == 0)
                {
                    sum += k;
                }
            }
            return sum == number;
        }
    }
}
