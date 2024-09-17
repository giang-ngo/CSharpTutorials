using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.control_structures
{
    internal class Lesson2
    {
        static void Main()
        {
            double gpa = 3.25;
            string rank;
            switch (gpa)
            {
                case < 1.6 and >= 0.0: // gpa từ 0.0 đến 1.6: trượt môn, F
                    rank = "F";
                    break;
                case < 2.0 and >= 1.6: // gpa từ 1.6 đến dưới 2.0, điểm D
                    rank = "D";
                    break;
                case >= 2.0 and < 2.8: // gpa từ 2.0 đến dưới 2.8, điểm C
                    rank = "C";
                    break;
                case >= 2.8 and < 3.2: // gpa từ 2.8 đến dưới 3.2, điểm B
                    rank = "B";
                    break;
                case >= 3.2 and < 3.6: // gpa từ 3.2 đến dưới 3.6, điểm A
                    rank = "A";
                    break;
                case >= 3.6 and <= 4.0: // gpa từ 3.6 đến 4.0, điểm A+
                    rank = "A+";
                    break;
                default:
                    rank = "";
                    Console.WriteLine("Wrong GPA. Please try again!");
                    break;
            }
            Console.WriteLine($"GPA = {gpa}, rank = {rank}");
        }
    }
}
