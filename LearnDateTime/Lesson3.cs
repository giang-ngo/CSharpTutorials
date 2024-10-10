using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDateTime
{
    internal class Lesson3
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var dateFormat = "dd/MM/yyyy";// định dạng ngày tháng
            var timeFormat = "HH:mm:ss";// định dạng giờ
            var dateTimeFormat = "MMMM dd, yyyy HH:mm:ss";// cả ngày giờ

            var format = "dd-MM-yyyy HH:mm:ss tt";// cả ngày giờ

            var dateString = "25/11/2009";
            var fullDateTimeString = "January 16, 2025 15:34:26";

            DateTime now = DateTime.Now;
            Console.WriteLine($"Giờ hiện tại: {now.ToString(timeFormat)}");
            Console.WriteLine($"Ngày hiện tại: {now.ToString(dateFormat)}");
            Console.WriteLine($"Ngày và giờ hiện tại: {now.ToString(dateTimeFormat)}");
            Console.WriteLine($"Ngày và giờ hiện tại: {now.ToString(format)}");

            DateTime birthDate;
            if (DateTime.TryParseExact(dateString.Trim(), dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate))
            {
                Console.WriteLine($"Sinh nhật của tôi: {birthDate.ToString(dateFormat)}");
            }
            else
            {
                Console.WriteLine("Không thể phân tích ngày sinh của tôi.");
            }

            DateTime otherDateTime;
            if (DateTime.TryParseExact(fullDateTimeString.Trim(), dateTimeFormat, new CultureInfo("en-US"), DateTimeStyles.None, out otherDateTime))
            {
                Console.WriteLine($"Ngày đầy đủ: {otherDateTime.ToLongDateString()}");
                Console.WriteLine($"Ngày giờ tự định dạng: {otherDateTime.ToString(format,
                    new CultureInfo("en-US"))}");
                Console.WriteLine($"Giờ tự định dạng: {otherDateTime.ToString(timeFormat)}");
            }
            else
            {
                Console.WriteLine("Không thể phân tích ngày giờ của bạn bè.");
            }
        }
    }
}
