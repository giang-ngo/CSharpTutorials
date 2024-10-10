using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Master_C__Programming.exception
{
    internal class Lesson2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            try
            {
                var fullName = GetFullName();
                Console.WriteLine("Xin chào " + fullName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static string GetFullName()
        {
            var pattern = @"^[\p{L} ]{2,40}$";
            Console.WriteLine("Họ và tên: ");
            var fullName = Console.ReadLine();
            var regex = new Regex(pattern);
            if (regex.IsMatch(fullName))
            {
                return fullName;
            }
            else
            {
                throw new InValidNameException("Họ và tên không hợp lệ", fullName);
            }
        }
    }

    class InValidNameException : Exception
    {
        public string InvalidName { get; set; }

        public InValidNameException() : base() { }
        public InValidNameException(string message) : base(message) { }
        public InValidNameException(string message, Exception innerException) 
            : base(message, innerException) { }
        public InValidNameException(string message, string invalidName) : base(message)
        {
            InvalidName = invalidName;
        }

        public override string ToString()
        {
            return base.ToString() + $" InvalidName: {InvalidName}";
        }
    }
}
