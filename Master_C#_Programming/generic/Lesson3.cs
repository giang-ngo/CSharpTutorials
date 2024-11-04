using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.generic
{
    internal class Lesson3
    {
        public delegate void MyDelegate(string msg);
        public delegate int CalculateDelegate(int a, int b);
        public delegate T FindMaxDelegate<T>(List<T> list);

        public static void ShowMessage(string msg)
        {
            Console.WriteLine(msg);
        }
        public static int Add(int a, int b) => a + b;
        public static int Sub(int a, int b) => a - b;
        public static int Mul(int a, int b) => a * b;

        public static void ShowResult(int a, int b, string op, CalculateDelegate cacl)
        {
            Console.WriteLine($"{a} {op} {b} = " + cacl(a, b));
        }

        public static void PrintResultA(string msg)
        {
            Console.WriteLine($"{msg} thực hiện trong phương thức PrintResultA.");
        }
        public static void PrintResultB(string msg)
        {
            Console.WriteLine($"{msg} thực hiện trong phương thức PrintResultB.");
        }
        public static void PrintResultC(string msg)
        {
            Console.WriteLine($"{msg} thực hiện trong phương thức PrintResultC.");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Đếm số lượng từ có trong 1 câu
            Func<string, int> countWordFunc = (str) =>
            {
                var data = str.Split(' ');
                return data.Length;
            };

            // Hiển thị bất kỳ kiểu dữ liệu nhận được
            Action<object> printer = msg => Console.WriteLine(msg);

            // Kiểm tra xem các ký tự của xâu ký tự có phải chữ hoa hay không
            Predicate<string> checkUpperCase = str => str.CompareTo(str.ToUpper()) == 0;

            var msg = "Hello World";
            var numOfWord = countWordFunc.Invoke(msg);
            Console.WriteLine($"Số từ của câu \"{msg}\" là {numOfWord}");
            printer($"Câu \"{msg}\" chỉ chứa các chữ cái hoa: {checkUpperCase(msg)}");

            // Sử dụng Action để hiển thị thông điệp
            printer("Thông điệp cần hiển thị là:");
            printer(msg);
            printer(123); 
            printer(45.67); 
            printer(true);
        }
    }
}
