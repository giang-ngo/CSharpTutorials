using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.class_and_object_oriented// cùng namespace
{
    partial class Student
    {
        public void GetInputInfo()
        {
            Console.WriteLine("Mã SV: ");
            StudentId = Console.ReadLine();
            Console.WriteLine("Họ tên: ");
            FullName = Console.ReadLine();
        }
        public void DoHomework(string subject)
        {
            Console.WriteLine($"Sinh viên {FullName} đang làm bt môn {subject}");
        }
        public partial void PayFee(long amount);
        
        public void DoExam(string subject)
        {

        }

        public void ShowInfo()
        {
            Console.WriteLine("Mã SV: " + StudentId);
            Console.WriteLine("Họ tên: " + FullName);
        }

    }
}
