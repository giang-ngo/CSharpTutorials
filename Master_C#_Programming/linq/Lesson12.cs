using Master_C__Programming.file_folder;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.linq
{
    internal class Lesson12
    {
        /**
         * Toán tử join
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // danh sách sinh viên
            var students = new List<Student>()
            {
                new Student("B25DCCN107", "Trần Trung Đức", "Hà Nội", new float[] {3.21f, 3.29f, 3.54f}),
                new Student("B25DCCN100", "Trần Văn Đức", "Cao Bằng", new float[] {3.66f, 3.37f, 3.88f}),
                new Student("B25DCCN105", "Lê Khả Ngân", "Nam Định", new float[] {3.78f, 3.18f, 3.42f}),
                new Student("B25DCCN103", "Hoàng Thanh Mai", "Đà Nẵng", new float[] {3.54f, 3.46f, 3.74f}),
                new Student("B25DCCN109", "Nguyễn Thúy Quyên", "Hà Nội", new float[] {3.36f, 3.05f, 3.18f}),
                new Student("B25DCCN106", "Nông Tiến Mạnh", "Thái Nguyên", new float[] {3.45f, 3.51f, 3.88f}),
                new Student("B25DCCN101", "Hồ Hoài Anh", "Hà Nội", new float[] {3.69f, 3.35f, 3.68f}),
                new Student("B25DCCN104", "Trương Thanh Thức", "Hồ Chí Minh", new float[] {3.11f, 3.18f, 3.72f}),
                new Student("B25DCCN108", "Đỗ Hoàng Long", "Hồ Chí Minh", new float[] {3.88f, 3.97f, 3.49f})
            };

            // danh sách môn học
            var subjects = new List<Subject>()
            {
                new Subject{Id="SJ1001", Name="C++", Credit=3},
                new Subject{Id="SJ1002", Name="C#", Credit=3},
                new Subject{Id="SJ1003", Name="Java", Credit=4},
                new Subject{Id="SJ1004", Name="SQL", Credit=3},
                new Subject{Id="SJ1005", Name="Python", Credit=3},
                new Subject{Id="SJ1006", Name="Kotlin", Credit=4},
                new Subject{Id="SJ1007", Name="JavaScript", Credit=4},
            };

            // danh sách đăng ký
            var registers = new List<Register>()
            {
                new Register{StudentId="B25DCCN100", SubjectId="SJ1002"},
                new Register{StudentId="B25DCCN100", SubjectId="SJ1002"},
                new Register{StudentId="B25DCCN100", SubjectId="SJ1001"},
                new Register{StudentId="B25DCCN101", SubjectId="SJ1002"},
                new Register{StudentId="B25DCCN103", SubjectId="SJ1003"},
                new Register{StudentId="B25DCCN104", SubjectId="SJ1002"},
                new Register{StudentId="B25DCCN104", SubjectId="SJ1005"},
                new Register{StudentId="B25DCCN108", SubjectId="SJ1006"},
                new Register{StudentId="B25DCCN108", SubjectId="SJ1001"},
                new Register{StudentId="B25DCCN100", SubjectId="SJ1003"},
                new Register{StudentId="B25DCCN107", SubjectId="SJ1003"},
                new Register{StudentId="B25DCCN106", SubjectId="SJ1002"},
            };

            // cho biết sinh viên nào đã đăng kí
            //var registeredStudentsQuery = (from student in students
            //                             join register in registers
            //                             on student.Id equals register.StudentId
            //                             orderby student.Id
            //                             select student).Distinct();


            // cho biết sinh viên nào đã đăng kí môn học nào

            var registeredStudentsQuery = (from student in students
                                         join register in registers
                                         on student.Id equals register.StudentId
                                         join subject in subjects on register.SubjectId equals subject.Id
                                         where subject.Name == "C#"
                                         orderby student.Id
                                         select new { student.Id, student.FullName, subject.Name, subject.Credit }).Distinct();

            foreach (var student in registeredStudentsQuery)
            {
                Console.WriteLine(student);
                //Console.WriteLine($"{student.Id} - {student.FullName}");
            }
        }
    }

    struct Subject
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Credit { get; set; }
    }

    struct Register : IEquatable<Register>
    {
        public string SubjectId { get; set; }
        public string StudentId { get; set; }
        public override bool Equals(object obj)
        {
            return obj is Register register && Equals(register);
        }
        public bool Equals(Register other)
        {
            return SubjectId == other.SubjectId &&
                   StudentId == other.StudentId;
        }
        public override int GetHashCode()
        {
            int hashCode = 1231936815;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SubjectId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(StudentId);
            return hashCode;
        }
    }
}
