using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.basic_data_structures
{
    internal class Lesson1
    {
        static void Main()
        {
            //int[] numbers = new int[100];
            //string[] oldGirlFriends = new string[500];
            //var ages = new int[6];
            //var results = new bool[6];
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(oldGirlFriends[0]);
            //Console.WriteLine(ages[0]);
            //Console.WriteLine(results[1]);

            //// Khởi tạo giá trị cho các phần tử mảng
            //float[] grades = { 1.25f, 3.47f, 6.54f, 9.87f };
            //float[] othergrades = new float[] { 1.25f, 3.47f, 6.54f, 9.87f };
            //var values = new string[] { "Hello", "Hi", "Bye", "What", "...." };

            //// Gán giá trị cho phần tử cụ thể
            //var friends = new string[200];
            //friends[0] = "Nam";
            //friends[1] = "Mai";
            //friends[2] = "Hoa";
            //friends[199] = "Thanh";
            //friends[100] = "Loan";

            //for (int i = 0; i < friends.Length; i++)
            //{
            //    Console.WriteLine(friends[i]);
            //}

            //foreach (var item in friends)
            //{
            //    // item = "New data";
            //    Console.WriteLine(item);
            //}

            var friends = FriendNames();
            ShowFriends(friends);
        }

        // phương thức nhập tên những người bạn và trả về mảng
        static string[] FriendNames()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số lượng người bạn: ");
            int n = int.Parse(Console.ReadLine());
            string[] friends = new string[n];
            for (int i = 0; i < friends.Length; i++)
            {
                Console.WriteLine("Nhập tên một người bạn: ");
                friends[i] = Console.ReadLine();
            }
            return friends;
        }

        // phương thức hiển thị danh sách tên những người bạn
        static void ShowFriends(string[] friends)
        {
            Console.WriteLine("=====================");
            Console.WriteLine("Số lượng bạn bè: " + friends.Length);
            Console.WriteLine("Danh sách những người bạn của tôi: ");
            foreach (var item in friends)
            {
                Console.WriteLine(item);
            }
        }
    }
}
