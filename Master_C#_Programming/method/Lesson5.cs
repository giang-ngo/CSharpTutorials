using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__Programming.method
{
    internal class Lesson5

    {
        static void Main(string[] args)
        {
            Console.WriteLine("From number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("To number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Prime number from {a} to {b}: ");
            ListedPrimeNumbers(a, b);
        }
        static void ListedPrimeNumbers(int from, int to)
        {
            bool IsPrime(int number) // hàm cục bộ      
            {
                if (number < 2)
                {
                    return false;
                }
                int bound = (int)Math.Sqrt(number);
                for (int i = 2; i <= bound; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            for (int i = from; i <= to; i++)
            {
                if (IsPrime(i)) // call to local function        
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
    }
}
