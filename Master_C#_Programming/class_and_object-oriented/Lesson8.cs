using System;
using System.Collections.Generic;

/**
 * Mối qh thành phần
 */
namespace Master_C__Programming.class_and_object_oriented
{
    internal class Lesson8
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng FullName và Student để kiểm tra
            FullName studentFullName = new FullName("John", "Doe", "Smith");
            Student student = new Student(studentFullName)
            {
                Age = 20,
                PhoneNumber = new string[] { "123-456-7890", "987-654-3210" }
            };

            // Tạo đối tượng Subject
            Subject mathSubject = new Subject("Mathematics", 101);

            // Gọi phương thức DoExam
            student.DoExam(mathSubject);

            // Hiển thị thông tin sinh viên
            student.DisplayInfo();
        }
    }

    // Lớp FullName sử dụng cho Student (Composition)
    class FullName
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public FullName(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{FirstName} {MiddleName} {LastName}";
        }
    }

    // Lớp Subject (được dùng trong phương thức DoExam của Student)
    class Subject
    {
        public string SubjectName { get; set; }
        public int SubjectCode { get; set; }

        public Subject(string subjectName, int subjectCode)
        {
            SubjectName = subjectName;
            SubjectCode = subjectCode;
        }

        public override string ToString()
        {
            return $"{SubjectName} (Code: {SubjectCode})";
        }
    }

    // Lớp Student thể hiện các khái niệm OOP như aggregation, association, composition
    class Student
    {
        // Aggregation: tập hợp các số điện thoại
        public string[] PhoneNumber;

        public int Age { get; set; }

        // Composition: Student chứa đối tượng FullName
        public FullName FullName { get; set; }

        public Student(FullName fullName)
        {
            FullName = fullName;
        }

        // Association: liên kết giữa Student và Subject thông qua phương thức DoExam
        public void DoExam(Subject subject)
        {
            Console.WriteLine($"{FullName} is taking the exam for {subject.SubjectName}.");
        }

        // Phương thức hiển thị thông tin sinh viên
        public void DisplayInfo()
        {
            Console.WriteLine($"Full Name: {FullName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine("Phone Numbers:");
            foreach (var phone in PhoneNumber)
            {
                Console.WriteLine(phone);
            }
        }
    }
}
