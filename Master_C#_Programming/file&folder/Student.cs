using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.file_folder
{
    public class Student
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Major { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }

        public Student(string id, string name, string address, string major, DateTime birthDate, string phoneNumber)
        {
            Id = id;
            FullName = name;
            Address = address;
            Major = major;
            BirthDate = birthDate;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"{Id,-20}{FullName,-25}{Address,-20}{Major,-10}{BirthDate.ToShortDateString(),-20}{PhoneNumber,-20}";
        }
    }
}
