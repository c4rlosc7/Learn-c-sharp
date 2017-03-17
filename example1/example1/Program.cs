using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example1
{
    class Program
    {
        static void Main(string[] args)
        {
            // First program, hello world
            Console.WriteLine("Hello world");

            // Type of data, everthing is the object
            int age = 24;
            decimal d = 1.0m;
            float height = 1.69f;
            double nD = 1.0d;
            string name = "carlos";
            bool flag = true;
            DateTime date = DateTime.Now;
            Console.WriteLine("I have {0} years old", age);
            Console.WriteLine("My height is {0:f}cm", height);
            Console.WriteLine("My name is {0}",name);
            Console.WriteLine("The time is "+date.ToShortDateString());
            Console.WriteLine("The value of flag is "+flag.ToString());

            Console.ReadKey();
        }
    }
}
