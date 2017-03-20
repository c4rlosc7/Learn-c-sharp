using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conditional if example number prime
            int numberToInput = 0;
            Console.Write("Enter the number: ");
            numberToInput = Convert.ToInt32(Console.ReadLine());
            Console.Write("The number is {0}",numberToInput);
            if (numberToInput % 2 == 0)
            {
                Console.WriteLine(" is even number.");
            }
            else
            {
                Console.WriteLine(" is prime number.");
            }
            Console.ReadKey();

        }
    }
}
