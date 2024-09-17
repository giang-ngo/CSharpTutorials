using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.basic_data_structures
{
    internal class Lesson3
    {
        static void Main()
        {
            int[] arr = { 1, 5, 0, 2, 3, 2, 4, 5, 9, 6, 7, 4, 8 };
            Console.WriteLine("Truoc sap xep: ");
            ShowArray(arr);

            QuickSort(arr, 0, arr.Length - 1);

            Console.WriteLine("Sau sap xep: ");
            ShowArray(arr);
        }

        static void QuickSort(int[] arr, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int p = Partition(arr, leftIndex, rightIndex);
                QuickSort(arr, leftIndex, p - 1);
                QuickSort(arr, p + 1, rightIndex);
            }
        }

        private static int Partition(int[] arr, int leftIndex, int rightIndex)
        {
            int pivot = arr[rightIndex];
            int i = leftIndex;

            for (int j = leftIndex; j < rightIndex; j++)
            {
                if (arr[j] < pivot)
                {
                    Swap(ref arr[i], ref arr[j]);
                    i++;
                }
            }
            Swap(ref arr[i], ref arr[rightIndex]);
            return i;
        }

        private static void Swap(ref int a, ref int b)
        {
            (a, b) = (b, a);
        }

        // Phương thức hiển thị các phần tử trong mảng
        static void ShowArray(int[] arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
