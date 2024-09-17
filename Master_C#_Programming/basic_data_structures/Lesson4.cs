using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.basic_data_structures
{
    internal class Lesson4
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] arr = { 1, 5, 0, 2, 3, 2, 4, 5, 9, 6, 7, 4, 8 };
            Array.Sort(arr);
            Console.WriteLine("Nhập x cần tìm: ");
            int x = int.Parse(Console.ReadLine());
            var result = BinarySearch(arr, x, 0, arr.Length - 1);
            Console.WriteLine($"{x}{(result >= 0 ? "" : " không")} tồn tại trong mảng.");
        }

        static int BinarySearch(int[] arr, int x, int left, int right)
        {
            if (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == x)
                {
                    return mid;
                }
                if (arr[mid] < x)
                {
                    return BinarySearch(arr, x, mid + 1, right);
                }
                else
                {
                    return BinarySearch(arr, x, left, mid - 1);
                }
            }
            return -1;
        }
    }
}
