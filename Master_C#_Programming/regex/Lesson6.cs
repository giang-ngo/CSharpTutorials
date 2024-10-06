using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Master_C__Programming.regex
{
    internal class Lesson6
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Ngày sinh phải nhập đúng định dạng dd/mm/yyyy, ví dụ 25/05/ 2015
            var pattern = @"^(?:0[1-9]|[12][0-9]|3[01])/(?:0[1-9]|1[0-2])/\d{4}$";

            var regex = new Regex(pattern);

            Console.WriteLine("Nhập ngày sinh: ");
            string date = Console.ReadLine().Trim();
            if (regex.IsMatch(date))
            {
                Console.WriteLine("Ngày sinh hợp lệ");
            }
            else
            {
                Console.WriteLine("Ngày sinh không hợp lệ");
            }
        }
    }
}
