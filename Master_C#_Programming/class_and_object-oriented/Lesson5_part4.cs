using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.class_and_object_oriented/// cùng namespace
{
    partial class Student
    {
        public partial void PayFee(long amount)
        {
            Console.WriteLine($"Sinh viên {FullName} nộp học phí số tiền {amount}K");
        }
    }
}
