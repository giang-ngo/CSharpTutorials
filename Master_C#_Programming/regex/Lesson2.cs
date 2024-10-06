using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Master_C__Programming.regex
{
    internal class Lesson2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Email có dạng: bắt đầu
            //bằng các kí tự chữ cái, dấu gạch dưới.Tiếp đó có thể là chữ cái, chữ số, dấu .-_@tiếp đó
            //tới tên miền chỉ gồm chữ cái, chữ số, kết thúc bằng đuôi.X với X có từ 2 - 4 kí tự chữ cái. Email
            //không phân biệt chữ hoa, thường

            var pattern = @"^[a-zA-Z_][\w\.-]+@[a-zA-Z0-9]+\.[a-zA-Z]{2,4}$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            Console.WriteLine("Nhập email từ bàn phím: ");
            var email = Console.ReadLine();

            if (regex.IsMatch(email))
            {
                Console.WriteLine("Email hợp lệ");
            }
            else
            {
                Console.WriteLine("Email không hợp lệ");
            }
        }
    }
}
