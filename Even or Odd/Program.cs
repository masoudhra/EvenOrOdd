using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_or_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your number");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            if (number % 2 == 0)
            {
                Console.WriteLine("Your number is even");
            }
            else
            {
                Console.WriteLine("Your number is odd");
            }
            Console.ReadKey();

        }
    }
}
