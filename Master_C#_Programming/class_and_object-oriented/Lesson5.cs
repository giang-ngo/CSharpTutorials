using System;

namespace Master_C__Programming.class_and_object_oriented;// cùng namespace

public class Program
{
    //public static void Main()
    //{
    //    //global::System.Console.WriteLine("Hello world!");
    //    //System.Console.WriteLine("Hello world!");
    //}
}

partial class Student
{
    public string StudentId { get; set; }
    public string FullName { get; set; }
    public int Age { get; set; }
    public string Major { get; set; }
    public float Gpa { get; set; }
    public Student() : this("")
    {

    }
    public Student(string id) : this(id, "")
    {

    }

    public Student(string id, string fullName) : this(id, fullName, 0, "", 0)
    {

    }
    public Student(string id, string fullName, int age, string major, float gpa)
    {
        StudentId = id;
        FullName = fullName;
        Age = age;
        Major = major;
        Gpa = gpa;

    }
}

struct Person
{

}

struct Employee
{

}


