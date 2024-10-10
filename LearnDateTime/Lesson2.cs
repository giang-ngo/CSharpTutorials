using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDateTime
{
    internal class Lesson2
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng TimeOnly và hiển thị chuỗi kí tự đại diện tương ứng
            Console.OutputEncoding = Encoding.UTF8;
            TimeOnly time = new TimeOnly(15, 34, 55, 999);
            Console.WriteLine("==> Thông tin của đối tượng otherTime <==");
            Console.WriteLine($"{time.Hour}:{time.Minute}:{time.Second}");
            Console.WriteLine($"Giờ: {time.Hour}");
            Console.WriteLine($"Phút: {time.Minute}");
            Console.WriteLine($"Giây: {time.Second}");
            Console.WriteLine($"Mili giây: {time.Millisecond}");
            Console.WriteLine(time.ToShortTimeString());

            Console.WriteLine("==============================");
            //hiển thị string đại diện cho thời gian
            Console.WriteLine($"Thông tin thời gian dạng ngắn: {time.ToShortTimeString()}");
            Console.WriteLine($"Thông tin thời gian dạng dài: {time.ToLongTimeString()}");

            // tạo đối tượng thời gian mới từ đối tượng thời gian có sẵn
            var otherTime = time.AddMinutes(50).AddHours(3);
            Console.WriteLine("==> Thông tin của đối tượng otherTime <==");
            Console.WriteLine($"{otherTime.Hour}:{otherTime.Minute}:{otherTime.Second}");
            Console.WriteLine($"Giờ: {otherTime.Hour}");
            Console.WriteLine($"Phút: {otherTime.Minute}");
            Console.WriteLine($"Giây: {otherTime.Second}");
            Console.WriteLine($"Mili giây: {otherTime.Millisecond}");
            Console.WriteLine(otherTime.ToShortTimeString());


            // so sánh thời gian
            Console.WriteLine($"{otherTime} == {time}? {otherTime == time}");
            Console.WriteLine($"{otherTime} > {time}? {otherTime > time}");
            Console.WriteLine($"{otherTime} < {time}? {otherTime < time}");

        }
    }
}
