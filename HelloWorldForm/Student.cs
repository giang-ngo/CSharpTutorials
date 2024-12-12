using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldForm
{
    public class Student
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Major { get; set; }
        public DateTime BirthDate { get; set; }
        public float Gpa { get; set; }

        public Student(string id, string name, string major, DateTime dob, float gpa)
        {
            Id = id;
            FullName = name;
            Major = major;
            BirthDate = dob;
            Gpa = gpa;
        }

        public object[] ToPropertiesArray()
        {
            return new object[] { Id, FullName, Major, BirthDate.ToString("dd/MM/yyyy"), Gpa };
        }
    }
}
