using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.basic_data_structures
{
    internal class Lesson6
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //bool? isOk = null; // true, false
            //double? pi = 3.14;
            //int?[] arr = new int?[10]; // mảng được khởi tạo giá trị null
            //int x = 200;
            //int? y = x;

            //int? number1 = 100;
            //int? number2 = null;
            //if (number1.HasValue)
            //{
            //    Console.WriteLine($"Giá trị trong number1: {number1.Value}");
            //}
            //else
            //{
            //    Console.WriteLine("Giá trị trong number1 là null.");
            //}
            //if (number2.HasValue)
            //{
            //    Console.WriteLine($"Giá trị trong number1: {number2.Value}");
            //}
            //else
            //{
            //    Console.WriteLine("Giá trị trong number2 là null.");
            //}

            int? number1 = 100;
            int? number2 = null;
            int? number3 = 200;
            //phép cộng
            //number1++; // ok number1 tăng lên 101
            //Console.WriteLine($"number1 = {number1}");
            //number1 += number3; // number3 sẽ là 301
            //Console.WriteLine($"number1 = {number1}");
            //number1 += number2; // null
            //Console.WriteLine($"number1 = {number1}");
            //so sánh
            Console.WriteLine($"number1 > number2? {number1 > number2}"); // false
            Console.WriteLine($"number1 < number2? {number1 < number2}"); // false
            Console.WriteLine($"number1 >= number2? {number1 >= number2}"); // false
            Console.WriteLine($"number1 == number2? {number1 == number2}"); // false
            Console.WriteLine($"number1 != number2? {number1 != number2}"); // true
            Console.WriteLine($"number2 == null? {number2 == null}"); // true
            Console.WriteLine($"number2 != null? {number2 != null}"); // false

            Console.WriteLine(Nullable.GetUnderlyingType(typeof(int)) != null ? "nullable" : "non-nullable");
            Console.WriteLine(Nullable.GetUnderlyingType(typeof(int?)) != null ? "nullable" : "non-nullable");
            Console.WriteLine(Nullable.GetUnderlyingType(typeof(bool)) != null ? "nullable" : "non-nullable");
            Console.WriteLine(Nullable.GetUnderlyingType(typeof(bool?)) != null ? "nullable" : "non-nullable");
            Console.WriteLine(Nullable.GetUnderlyingType(typeof(double)) != null ? "nullable" : "non-nullable");
            Console.WriteLine(Nullable.GetUnderlyingType(typeof(double?)) != null ? "nullable" : "non-nullable");
            // kết quả:
            // non-nullable
            // nullable
            // non-nullable
            // nullable
            // non-nullable
            // nullable
        }
    }
}
