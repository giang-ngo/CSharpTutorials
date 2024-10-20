using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Master_C__Programming.file_folder
{
    class Lesson93
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            //var data = File.ReadAllText("data.json");
            //var jObject = JObject.Parse(data);
            //var jArray = jObject["students"];
            //List<Student> students = new List<Student>();

            //foreach (var item in jArray)
            //{
            //    students.Add(item.ToObject<Student>());
            //}

            //ShowData(students);


            var students = CreateStudents();
            var root = new
            {
                students = CreateStudents(),
            };
            var strJson = JsonConvert.SerializeObject(root, Formatting.Indented);
            Console.WriteLine(strJson);
            File.WriteAllText("students.json",strJson);
        }

        static Student[] CreateStudents()
        {
            return new Student[] {
        new Student("SV101", 20, "CNTT", 3.25f,
            new FullName("Hoàng", "Trần", "Đình"),
            new Address("Phú Nhuận", "Phú Nhuận", "TP. Hồ Chí Minh")),
        new Student("SV102", 21, "CNTT", 3.45f,
            new FullName("Lâm", "Nguyễn", "Tiến"),
            new Address("Tân Bình", "Tân Bình", "TP. Hồ Chí Minh")),
        new Student("SV103", 24, "CNTT", 3.75f,
            new FullName("Mạnh", "Phạm", "Thế"),
            new Address("Quận 1", "Quận 1", "TP. Hồ Chí Minh")),
        new Student("SV104", 21, "CNTT", 3.15f,
            new FullName("Bình", "Lê", "Đức"),
            new Address("Bình Thạnh", "Bình Thạnh", "TP. Hồ Chí Minh")),
        new Student("SV105", 20, "CNTT", 3.15f,
            new FullName("Mai", "Phan", "Thị"),
            new Address("Quận 3", "Quận 3", "TP. Hồ Chí Minh"))
    };
        }


        static void ShowData(List<Student> people)
        {
            foreach (var item in people)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Student // lớp mô tả thông tin sinh viên
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("age")]
        public int Age { get; set; }
        [JsonProperty("major")]
        public string Major { get; set; }
        [JsonProperty("gpa")]
        public float Gpa { get; set; }
        [JsonProperty("fullname")]
        public FullName FullName { get; set; }
        [JsonProperty("address")]
        public Address Address { get; set; }

        public Student() { }
        public Student(string id, int age, string major,
            float gpa, FullName fullName, Address address)
        {
            Id = id;
            Address = address;

            FullName = fullName;
            Age = age;
            Major = major;
            Gpa = gpa;
        }

        public override string ToString()
        {
            return $"Student[Id={Id}, Age={Age}, Major={Major}, " +
                $"Gpa={Gpa}, FullName={FullName}, Address={Address}]";
        }
    }

    internal class FullName
    {
        [JsonProperty("first")]
        public string FirstName { get; set; }
        [JsonProperty("last")]
        public string LastName { get; set; }
        [JsonProperty("mid")]
        public string MidName { get; set; }

        public FullName() { }

        public FullName(string first, string last, string mid)
        {
            FirstName = first;
            LastName = last;
            MidName = mid;
        }

        public override string ToString()
        {
            return $"{LastName} {MidName} {FirstName}";
        }
    }

    internal class Address
    {
        [JsonProperty("wards")]
        public string Wards { get; set; }
        [JsonProperty("district")]
        public string District { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }


        public Address() { }
        public Address(string ward, string district, string city)
        {
            Wards = ward;
            District = district;
            City = city;
        }

        public override string ToString()
        {
            return $"{Wards} - {District} - {City}";
        }
    }
}
