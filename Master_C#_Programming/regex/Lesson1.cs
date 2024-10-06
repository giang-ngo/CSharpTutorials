using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Master_C__Programming.regex
{
    internal class Lesson1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var input = "Hi  there           how are  you  to day";
            var pattern = @"\s+";
            var regex = new Regex(pattern);
            var words = regex.Split(input);

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }

            var result = regex.Replace(input, " ");
            Console.WriteLine("Sau khi thay thế:");
            Console.WriteLine(result);
        }
    }
}
