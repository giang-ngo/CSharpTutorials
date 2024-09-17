using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.introduction_to_C_
{
    internal class Lesson8
    {
        static void Main()
        {
            int x = 100;
            int y = -99;
            float d = 3.65f;
            Console.WriteLine($"Absolute of x = {Math.Abs(x)}"); // lấy trị tuyệt đối của x
            Console.WriteLine($"Absolute of y = {Math.Abs(y)}");
            Console.WriteLine($"Square root of x = {Math.Sqrt(x)}"); // lấy căn bậc hai
            Console.WriteLine($"Rounding up d = {Math.Ceiling(d)}"); // làm tròn lên
            Console.WriteLine($"Rounding down d = {Math.Floor(d)}"); // làm tròn xuống
            Console.WriteLine($"Rounding number d = {Math.Round(d)}"); // làm tròn tự động
            Console.WriteLine($"Min of (x, y) = {Math.Min(x, y)}"); // tìm min trong hai số
            Console.WriteLine($"Max of (x, y) = {Math.Max(x, y)}"); // tìm max trong hai số
            Console.WriteLine($"Sin 45 = {Math.Sin(Math.PI / 4)}"); // tính sin 45 độ(pi/4)
        }
    }
}
