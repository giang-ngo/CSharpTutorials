using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Master_C__Programming.regex
{
    internal class Lesson4
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Mã sinh viên có dạng<B> < 2 số >< 4 chữ cái>< 3 số >.Ví dụ B30DCCN171,
            //B29DCDT500

            var pattern = @"^B\d{2}[A-Z]{4}\d{3}$";
            var regex = new Regex(pattern);

            Console.WriteLine("Mã SV: ");
            var id = Console.ReadLine();
            if (regex.IsMatch(id))
            {
                Console.WriteLine("Mã SV hợp lệ");
            }
            else
            {
                Console.WriteLine("Mã SV không hợp lệ");
            }
        }
    }
}
