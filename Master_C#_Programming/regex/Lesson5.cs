using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Master_C__Programming.regex
{
    internal class Lesson5
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            //Họ và tên chỉ có thể chứa các chữ cái, các từ phân tách nhau bởi dấu cách, không
            //quá 40 kí tự
            var pattern = @"^[\p{L} ]{1,40}$"; // hoặc @"^[a-zA-ZÀ-ỹ ]{1,40}$"

            var regex = new Regex(pattern);

            Console.WriteLine("Nhập họ tên: ");
            string name = Console.ReadLine().Trim();
            if (regex.IsMatch(name))
            {
                Console.WriteLine("Họ tên hợp lệ");
            }
            else
            {
                Console.WriteLine("Họ tên không hợp lệ");
            }
        }
    }
}
