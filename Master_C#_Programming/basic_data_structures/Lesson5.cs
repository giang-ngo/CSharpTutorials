using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.basic_data_structures
{
    internal class Lesson5
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] arr1 = { 1, 2, 0, 4, 9, 6, 5, 8, 8, 10, 10, 1 };
            Console.WriteLine("Mảng arr1 trước sắp xếp: ");
            ShowElements(arr1);
            Console.WriteLine("Mảng arr1 sau sắp xếp: ");
            Array.Sort(arr1);
            ShowElements(arr1);
            //Console.WriteLine("Đảo ngược mảng arr1: ");
            //Array.Reverse(arr1);
            //ShowElements(arr1);
            Console.WriteLine("Nhập x cần tìm: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(Array.BinarySearch(arr1, x) >= 0 ? "Tồn tại x" : "Không tồn tại x");
            //Array.Clear(arr1, 0, arr1.Length);
            //Console.WriteLine("Kích thước mảng sau khi clear: " + arr1.Length);
            //Console.WriteLine("Giá trị phần tử mảng sau clear: ");
            //ShowElements(arr1);
            //var arr2 = (float[])Array.CreateInstance(typeof(float), 100);
            //Console.WriteLine(arr2.Length);
            Console.WriteLine("Sau khi copy: ");
            int[] arr2 = new int[100];
            arr1.CopyTo(arr2, 5);
            ShowElements(arr2);
        }

        static void ShowElements(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
