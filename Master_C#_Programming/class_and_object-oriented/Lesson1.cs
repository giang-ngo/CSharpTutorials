using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.class_and_object_oriented
{
    internal class Lesson1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Student student1 = new Student("001", "Trương Quỳnh Anh", 20);
            Console.WriteLine("Mã sv: " + student1.Id);
            Console.WriteLine("Họ tên: " + student1.FullName);
            Console.WriteLine("Tuổi: " + student1.Age);

            //tạo đối tượng của bank account
            BankAccount bankAccount = new BankAccount();
            Console.WriteLine("Acc id: " + bankAccount.AccId);
            Console.WriteLine("Acc Onwer: " + bankAccount.Owner);
        }
    }

    public class Student
    {
        // phương thức khởi tạo
        public Student(string id)
        {
            Id = id;
        }

        public Student(string id, string fullName, int age)
        {
            Id = id;
            FullName = fullName;
            Age = age;
        }
        //các thuộc tính
        public string Id { get; set; }
        public string FullName { get; set; } = "No Name";
        public int Age { get; set; } = 0;
        public int Gpa { get; set; } = 0;
        public string Major { get; set; } = "CNTT";
        // trường dữ liệu của lớp
        public string rank = "Trượt môn";

        public void CalculateRank()
        {
            // statements
        }
    }

    internal class BankAccount
    {
        public int AccId { get; set; }
        public string AccNumber { get; set; }
        public string Owner { get; set; }
        public long Balance { get; set; }
        public string BankName { get; set; }

        // nạp tiền vào tk
        public long Deposit(long amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                return amount;
            }
            return 0;
        }

        // chuyển tiền
        public long BankTransfer(BankAccount other, long amount)
        {
            if (amount > 0 && amount < Balance && other != null)
            {
                other.Balance += amount;
                return amount;
            }
            return 0;
        }
        //rút tiền
        // ktra số dư
        // in sao kê
        // vay tiền, trả nợ, thanh toán dịch vụ
    }
}
