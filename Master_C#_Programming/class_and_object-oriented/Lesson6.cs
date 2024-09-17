using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.class_and_object_oriented
{
    internal class Lesson6
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Student student = new Student();
            //Console.WriteLine("Họ tên: ");
            //student.Name = Console.ReadLine();
            //Console.WriteLine("============================");
            //Console.WriteLine("Full Name: " + student.Name);
            //Console.WriteLine("First Name: " + student.FirstName);

            // tạo đối tượng của inner class từ bên ngoài
            OuterClass.InnerClass innerObject = new OuterClass.InnerClass();
            innerObject.Message = Console.ReadLine();
            Console.WriteLine("Message from inner class: ");
            innerObject.ShowMessage();
        }
    }
    class OuterClass
    {
        public class InnerClass
        {
            public string Message { get; set; }
            public void ShowMessage()
            {
                Console.WriteLine(Message);
            }
        }

    }
    class Student
    {
        private FullName _fullName;
        public string Name
        {
            get => _fullName.ToString();
            set
            {
                var data = value.Split(' ');
                _fullName.FirstName = data[data.Length - 1];
                _fullName.LastName = data[0];
                var mid = "";
                for (int i = 1; i < data.Length - 1; i++)
                {
                    mid += data[i] + " ";
                }
                _fullName.MidName = mid.TrimEnd();

            }
        }
        public string FirstName { get => _fullName.FirstName; }
        public Student()
        {
            _fullName = new FullName("", "", "");
        }
        private class FullName
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string MidName { get; set; }
            public FullName(string first, string mid, string last)
            {
                FirstName = first;
                LastName = mid;
                MidName = mid;
            }

            public override string ToString() => $"{LastName} {MidName} {FirstName}";
        }

        private class Address
        {
            public string Wards { get; set; }
            public string District { get; set; }
            public string City { get; set; }

        }
    }
}