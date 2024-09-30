using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.class_and_object_oriented
{
    internal class Lesson13
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Season season = Season.Autumn;
            //Console.WriteLine($"Value of {season} is {(int)season}");

            DayOfWeek today = DayOfWeek.Monday;
            DayOfWeek workingDay = DayOfWeek.WeekDay;
            DayOfWeek meetingDay = DayOfWeek.Monday | DayOfWeek.Friday;
            DayOfWeek travelingDay = DayOfWeek.Weekend;

            var isWorkingDay = (today & workingDay) == today;
            Console.WriteLine("Hôm nay là ngày làm việc: " + isWorkingDay);
            Console.WriteLine("Ngày có buổi họp: " + meetingDay);
            Console.WriteLine("Ngày người ta hay đi du lịch: " + travelingDay);
            Console.WriteLine((int)DayOfWeek.Monday);
        }
    }

    enum Season
    {
        Spring = 100,
        Summer = 200,
        Autumn = 300,
        Winter = 400,
    }

    [Flags]
    enum DayOfWeek
    {
        None = 0b_0000_0000,
        Monday = 0b_0000_0001,
        Tuesday = 0b_0000_0010,
        Wednesday = 0b_0000_0100,
        Thursday = 0b_0000_1000,
        Friday = 0b_0001_0000,
        Saturday = 0b_0010_0000,
        Sunday = 0b_0100_0000,
        WeekDay = Monday | Tuesday | Wednesday | Thursday | Friday,
        Weekend = Sunday | Saturday,

    }
}
