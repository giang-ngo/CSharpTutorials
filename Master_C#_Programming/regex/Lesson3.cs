using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Master_C__Programming.regex
{
    internal class Lesson3
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Số điện thoại có 10 chữ số, bắt đầu với 03, 08, 09 sau đó là 8 số
            //var pattern = @"^0(?:3|8|9)\d{8}$"; // hoặc @"^0(3|8|9)\d{8}$"


            //+84-333333333 hoặc +84-333-333-333
            //var pattern = @"^\+84-[389](?:\d{8}|\d{2}-\d{3}-\d{3})$";// có thể bỏ ?:

            // nhóm 2 cái làm 1
            var pattern = @"^(0(?:3|8|9)\d{8}|\+84-[389](?:\d{8}|\d{2}-\d{3}-\d{3}))$";

            var regex = new Regex(pattern, RegexOptions.IgnoreCase);

            Console.WriteLine("Nhập sđt cần kiềm tra: ");
            var phoneNumber = Console.ReadLine();
            if (regex.IsMatch(phoneNumber))
            {
                Console.WriteLine("Số điện thoại hợp lệ");
            }
            else
            {
                Console.WriteLine("Số điện thoại không hợp lệ");
            }


        }
    }
}
