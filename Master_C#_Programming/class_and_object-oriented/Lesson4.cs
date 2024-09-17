using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * Tính đóng gói dữ liệu
 */
namespace Master_C__Programming.class_and_object_oriented
{
    internal class Lesson4
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Student student = new Student("001", "Nguyễn Hoàng Long", 20, 3.56f);
            //student.SetFullName("Nguyễn Thành Luân");
            //student._age;// error


            //BankCard card = new BankCard();
            ////card.Id = 100;// error
            //Console.WriteLine("Mã thẻ: " + card.Id);


            Point point = new Point(10, 20);
            Console.WriteLine(point);
            Point point1 = new Point { X = 10, Y = 20 };
            Point point2 = new Point(20, 50) { };
            Point point3 = new Point(x: 20) { X = 10, Y = 20 };


        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point() : this(0, 0)
        {

        }

        public Point(int x) : this(x, 0)
        {

        }

        public Point(int x, int y)
        {
            X = x; Y = y;
        }

        public override string ToString() => $"Point({X}, {Y})";

    }

    class BankCard
    {
        private string _cardType;
        public int Id { get; private set; }
        public string CardNumber { get; }// chỉ đọc
        public string CardType { set => _cardType = value; }// chỉ ghi


    }

    class Student
    {
        private string _id;
        private string _fullName;
        private int _age;
        //private float _gpa;

        public Student(string id, string fullName, int age, float gpa)
        {
            _id = id;
            _fullName = fullName;
            _age = age;
            //_gpa = gpa;
        }
        public string GetId() => _id;

        public string SetId(string id) => _id = id;
        public string GetFullName() => _fullName;

        public void SetFullName(string fullName) => _fullName = fullName;

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        public float Gpa { get; set; } = 1.0f;// auto property

        //public int Age
        //{
        //    get => _age;
        //    set
        //    {
        //        if (value > 0)
        //        {
        //            _age = value;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Tuổi không hợp lệ");
        //            _age = 0;
        //        }
        //    }
        //}
    }

}


