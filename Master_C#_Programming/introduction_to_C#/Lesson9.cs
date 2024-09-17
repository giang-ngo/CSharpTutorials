using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.introduction_to_C_
{
    internal class Lesson9
    {
        static void Main()
        {
            string message = "Hello World!"; // cách phổ biến
            // viết hoa toàn bộ:
            string msgUpperCase = message.ToUpper();
            // viết thường toàn bộ
            string msgLowerCase = message.ToLower();
            // hiển thị kết quả
            Console.WriteLine($"Length of message: {message.Length}");
            Console.WriteLine($"Original message: {message}");
            Console.WriteLine($"Message upper case: {msgUpperCase}");
            Console.WriteLine($"Message lower case: {msgLowerCase}");
            Console.WriteLine($"First position of 'l' character: {message.IndexOf('l')}");
            Console.WriteLine($"Last position of 'l' character: {message.LastIndexOf('l')}");
            Console.WriteLine($"Is message start with Hello? {message.StartsWith("Hello")}");
        }
    }
}
