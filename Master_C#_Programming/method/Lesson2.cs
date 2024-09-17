using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.method
{
    internal class Lesson2
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //    int a = 20;
            //    int b = 50;
            //    Console.WriteLine($"Trước khi thay đổi: a = {a}, b = {b}");
            //    Swap(ref a, ref b);
            //    Console.WriteLine($"Sau khi thay đổi: a = {a}, b = {b}");

            //string message = "Hello world";
            //PrintMessage(message);
            //PrintMessage(in message);

            //int[] numbers = { 1, 2, 3, 4, 5 };
            //ref int maxValue = ref FindMax(numbers);
            //Console.WriteLine(maxValue);
            //maxValue *= 2;
            //ref int newMaxValue = ref FindMax(numbers);
            //Console.WriteLine(newMaxValue);

            GetStudentData(out string fullName, out int age, out float gpa);
            Console.WriteLine($"Full name: {fullName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"GPA: {gpa}");

        }



        //ref return và ref local
        static ref int FindMax(int[] arr)
        {
            int max = arr[0];
            int maxValueIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    maxValueIndex = i;
                }

            }
            return ref arr[maxValueIndex];
        }

        //Keyword ref
        static void swap(ref int first, ref int second)
        {
            int tmp = first;
            first = second;
            second = tmp;
        }

        //Keyword in
        static void PrintMessage(in string message)
        {
            Console.WriteLine(message);
            //message = "New message";//Error
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            GetStudentData(out string fullName, out int age, out float gpa);
            Console.WriteLine($"Full name: {fullName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"GPA: {gpa}");
        }

        static void GetStudentData(out string fullName, out int age, out float gpa)
        {
            Console.Write("Full name: ");
            fullName = Console.ReadLine();
            Console.Write("Age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("GPA: ");
            gpa = float.Parse(Console.ReadLine());
        }
    }
}
