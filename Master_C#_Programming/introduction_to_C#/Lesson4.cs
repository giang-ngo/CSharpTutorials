using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.introduction_to_C_
{
    internal class Lesson4
    {
        static void Main()
        {
            float gpa;
            int age = 20;
            string address;
            string email;
            string major, fullName;
            int x = 1, y = 2, z = 3;

            const float PI = 3.141592f;
            const int MAX_AGE = 150;
            const string MONDAY = "MONDAY";

            // gán giá trị mặc định của kiểu cho biến
            int width = default;
            int height = default;
            string brand = default;
            float radius = new();
            float latitude = new float();

            var area = 3.25; // area kiểu double
            var number = 3.125f; // number kiểu float
            var firstName = "Nam"; // firstName kiểu string
            var balance = 1250; // balance kiểu int

            Console.WriteLine(width);
        }
    }
}
