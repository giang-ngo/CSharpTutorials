using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.basic_data_structures
{
    internal class Lesson7
    {
        static void Main(string[] args)
        {
            // định nghĩa biểu thức lambda và gán cho biến action
            //    var action = () => Console.WriteLine("Welcome to C#");
            //    //action();

            //    // câu lệnh lambda tìm giá trị lớn nhất trong 3 số
            //    var findMax = int (int a, int b, int c) =>
            //    {
            //        int max = a;
            //        if (max < b)
            //        {
            //            max = b;
            //        }
            //        if (max < c)
            //        {
            //            max = c;
            //        }
            //        return max;
            //    };

            //    int maxValue = findMax(5, 6, 9);
            //    //Console.WriteLine($"Max value in (5,6,9) is " + maxValue);

            //    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            //    var countOddNumber = int (int[] arr) =>
            //    {
            //        int counter = 0;
            //        foreach (int item in arr)
            //        {
            //            if (item % 2 != 0)
            //            {
            //                counter++;
            //            }
            //        }
            //        return counter;
            //    };

            //    var result = countOddNumber(numbers);
            //    Console.WriteLine("Number of off element in array: " + result);

            // định nghĩa biểu thức lambda và gán cho biến action
            Action<string> action = (msg) => Console.WriteLine(msg);
            action("Hello world!");

            // câu lệnh lambda tìm giá trị lớn nhất trong 3 số
            Func<int, int, int, int> findMax = (a, b, c) =>
            {
                int max = a;
                if (max < b)
                {
                    max = b;
                }
                if (max < c)
                {
                    max = c;
                }
                return max;
            };

            int maxValue = findMax(5, 6, 9);
            Console.WriteLine($"Max value in (5,6,9) is " + maxValue);

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            Func<int[], int> countOddNumber = (arr) =>
            {
                int counter = 0;
                foreach (int item in arr)
                {
                    if (item % 2 != 0)
                    {
                        counter++;
                    }
                }
                return counter;
            };

            var result = countOddNumber(numbers);
            Console.WriteLine("Number of off element in array: " + result);
        }
    }
}
