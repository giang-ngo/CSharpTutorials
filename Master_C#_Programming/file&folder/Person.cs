using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.file_folder
{
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MidName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public Person()
        {

        }

        public Person(int id, string first, string last, string mid, int age, string address)
        {
            Id = id;
            FirstName = first;
            LastName = last;
            MidName = mid;
            Address = address;
            Age = age;
        }

        public override string ToString()
        {
            return $"Person[Id={Id}, FirstName = {FirstName}, " +
                $"LastName = {LastName}, MidName = {MidName}, Age = {Age}, Address = {Address}]";
        }
    }

    
}
