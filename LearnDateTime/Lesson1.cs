using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDateTime
{
    internal class Lesson1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DateOnly dateOnly = new DateOnly(2025, 10, 15);

            Console.WriteLine("==> Thông tin về đối tượng dateOnly vừa tạo <==");

            Console.WriteLine($"Ngày: {dateOnly.Day}");
            Console.WriteLine($"Tháng: {dateOnly.Month}");
            Console.WriteLine($"Năm: {dateOnly.Year}");

            // thực hiện thêm ngày
            var otherDate = dateOnly.AddDays(17);

            Console.WriteLine("==> Thông tin về đối tượng otherDate sau khi thêm 17 ngày vừa tạo <==");

            Console.WriteLine($"Ngày: {otherDate.Day}");
            Console.WriteLine($"Tháng: {otherDate.Month}");
            Console.WriteLine($"Năm: {otherDate.Year}");

            // thực hiện thêm tháng
            otherDate = dateOnly.AddMonths(17);

            Console.WriteLine("==> Thông tin về đối tượng otherDate sau khi thêm 17 tháng vừa tạo <==");

            Console.WriteLine($"Ngày: {otherDate.Day}");
            Console.WriteLine($"Tháng: {otherDate.Month}");
            Console.WriteLine($"Năm: {otherDate.Year}");

            Console.WriteLine(otherDate.ToLongDateString());

            // so sánh các đối tượng
            Console.WriteLine($"{dateOnly} > {otherDate}? {dateOnly > otherDate}");
            Console.WriteLine($"{dateOnly} == {otherDate}? {dateOnly == otherDate}");
            Console.WriteLine($"{dateOnly} < {otherDate}? {dateOnly < otherDate}");
        }
    }
}
