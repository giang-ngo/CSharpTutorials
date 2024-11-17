using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.linq
{
    struct Student
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public float Gpa { get; set; }
        public float[] Marks { get; set; }
        public Student(string id, string fullName, string address)
        {
            Id = id;
            FullName = fullName;
            Address = address;
        }
        public Student(string id, string fullName, string address, float gpa)
        {
            Id = id;
            FullName = fullName;
            Address = address;
            Gpa = gpa;
        }

        public Student(string id, string fullName, string address, float[] marks)
        {
            Id = id;
            FullName = fullName;
            Address = address;
            Marks = marks;
        }

        public override string ToString() => $"Student[{Id}, {FullName}, {Address}]";

        public override bool Equals(object obj)
        {
            return obj is Student student && Equals(student);
        }

        public bool Equals(Student other)
        {
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + EqualityComparer<string>.Default.GetHashCode(Id);
        }
    }
}
