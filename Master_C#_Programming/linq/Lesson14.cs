using Master_C__Programming.file_folder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.linq
{
    internal class Lesson14
    {
        /**
         * Các toán tử với phần tử đơn
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // danh sách môn học
            var subjects = new List<Subject>()
            {
                new Subject{Id="SJ1001", Name="C++", Credit=3},
                new Subject{Id="SJ1002", Name="C#", Credit=3},
                new Subject{Id="SJ1003", Name="Java", Credit=4},
                new Subject{Id="SJ1004", Name="SQL", Credit=3},
                new Subject{Id="SJ1005", Name="Python", Credit=3},
                new Subject{Id="SJ1006", Name="Kotlin", Credit=4},
                new Subject{Id="SJ1007", Name="JavaScript", Credit=2},
            };

            Console.WriteLine("==> Phần tử đầu tiên trong danh sách:");
            Console.WriteLine(subjects.First(x => x.Credit >= 4));

            Console.WriteLine("==> Phần tử cuối cùng trong danh sách:");
            Console.WriteLine(subjects.Last());

            Console.WriteLine(new string('-', 50));
            Console.WriteLine(subjects.Single(x => x.Credit == 2));
            Console.WriteLine(subjects.ElementAt(3));
            Console.WriteLine(subjects.ElementAtOrDefault(30));// ko tìm thấy trả về giá trị mặc định
                                                                
            Console.WriteLine(subjects.FirstOrDefault(x => x.Credit >= 40));// tương tự

        }
    }

    struct Subject
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Credit { get; set; }
        public override string ToString()
        {
            return $"Subject[{Id}, {Name}, {Credit}]";
        }
    }
}
