using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.basic_data_structures
{
    internal class Lesson2
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // khởi tạo mảng int
            //int[,] matrix = new int[,] {
            //    {1, 2, 3, 4 },
            //    {5, 6, 7, 8 },
            //    {0, 5, 9, 7 }
            //};
            // khởi tạo mảng string
            var friends = new string[,]
            {
                { "Nam", "Thanh", "Oanh"},
                { "Nhan", "Tung", "Khanh" },
                { "Hoang", "Quy", "Mai"}
            };

            // mảng răng cưa
            int[][] jaggedArr = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6, 7 },
                new int[] { 2, 5 }
            };
            // duyệt mảng răng cưa
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    Console.Write(jaggedArr[i][j] + " ");
                }
                Console.WriteLine();
            }

            // hoặc thực hiện như sau: 
            int[][] jaggedArr2 = new int[3][];
            jaggedArr2[0] = new int[] { 1, 2, 3 };
            jaggedArr2[1] = new int[] { 1, 2, 3, 4 };
            jaggedArr2[2] = new int[] { 1, 2 };


            int[,] matrix = new int[,] {
                {1, 2, 3, 4 },
                {5, 6, 7, 8 },
                {0, 5, 9, 7 }
            };

            // duyệt mảng
            Console.WriteLine($"Số lượng phần tử trong matrix: {matrix.Length}");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
