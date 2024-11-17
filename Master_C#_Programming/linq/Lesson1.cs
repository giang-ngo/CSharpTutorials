using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.linq
{
    internal class Lesson1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var cities = new List<string>() {
            "Hà Nội", "Đà Nẵng", "Hồ Chí Minh", "Bình Dương", "Cà Mau",
            "Nam Định", "Thanh Hóa", "Hà Tĩnh", "Điện Biên", "Lai Châu",
            "Thái Nguyên", "Hải Phòng", "Bắc Ninh", "Bắc Giang", "Bến Tre",
            "Bình Định", "Quảng Nam", "Nghệ An", "Hà Nam"
            };
            var result = from city in cities let x = city.ToLower() where x[0] == 'h' select x;
            foreach (var city in result)
            {
                Console.WriteLine("==> " + city);
            }
        }
    }
}
