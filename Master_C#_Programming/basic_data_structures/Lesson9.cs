using System;
using System.Collections.Generic;
using intArray = int[];
using print = System.Action<string>;


namespace Master_C__Programming.basic_data_structures
{
    internal class Lesson9
    {
        static void Main(string[] args)
        {
            //// biểu thức tập hợp
            //int[] arr = [1, 2, 3, 4, 5, 6, 7, 8];
            //Console.WriteLine(string.Join(" ", arr));

            //List<string> friends = ["Mai", "Long", "Hung", "Vy", "Thanh"];
            //friends.Add("Linh");

            //ShowArray(friends);

            //int[] row0 = [1, 2, 3];
            //int[] row1 = [4, 5, 6];
            //int[] row2 = [7, 8, 9];
            //int[] single = [.. row0, .. row1, .. row2];
            //ShowArray(single);

            // sử dụng tham số mặc định cho biểu thức lambda
            var IncrementBy = (int source, int increment = 1) => source + increment;

            // bí danh
            intArray row0 = [1, 2, 3];
            intArray row1 = [4, 5, 6];
            intArray row2 = [7, 8, 9];
            intArray single = [.. row0, .. row1, .. row2];

            // Sử dụng 'print' thay cho 'Console.WriteLine'
            print print = Console.WriteLine;
            print(IncrementBy(100).ToString()); // 101
            print(IncrementBy(199).ToString()); // 200
            print(IncrementBy(199, 5).ToString()); // 204
        }

        static void ShowArray<T>(IEnumerable<T> collection)
        {
            print print = Console.WriteLine;
            Console.WriteLine(string.Join(", ", collection));
        }
    }
}
