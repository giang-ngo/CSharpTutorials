using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.generic
{
    internal class Lesson1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Pair<string, string> hello = new Pair<string, string>("Hello", "Xin Chào");
            //Pair<string, string> lovely = new Pair<string, string>("Lovely", "Đáng yêu");

            //Console.WriteLine($"{hello.Key} => {hello.Value}");
            //Console.WriteLine($"{lovely.Key} => {lovely.Value}");

            int[] integers = new int[] { 1, 2, 3, 5, 8, 9, 7, 0, 4 };
            double[] gpas = new double[] { 1.2, 3.5, 4.0, 2.54, 3.65, 3.24, 3.17 };
            string[] friends = new string[] { "Linh", "Thủy", "Vy", "Ngân", "Tuấn", "Tú", "Tài", "Hưng" };

            ShowElements(integers);
            Console.WriteLine($"Giá trị lớn nhất: " + FindMax(integers));
            ShowElements(gpas);
            Console.WriteLine($"Giá trị lớn nhất: " + FindMax(gpas));

            ShowElements(friends);
            Console.WriteLine($"Giá trị lớn nhất: " + FindMax(friends));

            //Student[] students = new Student[] { new Student(), new Student() };
            //Console.WriteLine(FindMax(students));
        }

        static T FindMax<T>(T[] arr) where T : IComparable<T>
        {
            T max = arr[0];
            foreach (var item in arr)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }

            }
            return max;
        }

        static void ShowElements<T>(T[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        class TranscriptOfStudent<S, T>
        {
            public string SubjectName { get; set; }
            public S Student { get; set; }
            public T Transcript { get; set; }


            public TranscriptOfStudent(S student, T transcript, string subjectName)
            {
                Student = student;
                Transcript = transcript;
                SubjectName = subjectName;
            }
        }

        class Student : IComparable<Student>
        {
            public int CompareTo(Student other)
            {
                throw new NotImplementedException();
            }
        }

        class Utils
        {
            public static void Display<T>(T value)
            {
                Console.WriteLine(value);
            }
        }


        class Pair<K, V> where K : IComparable<V>, new()
        {
            public K Key { get; set; }
            public V Value { get; set; }

            public Pair(K key, V value)
            {
                Key = key;
                Value = value;
            }
        }

        interface MyInterface<T, U, V>
        {
            // do something...
        }
    }
}
