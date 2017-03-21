using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    class Program
    {
        static void Main(string[] args)
        {
            clsPerson student = new clsPerson();
            student.Name = "Carlos";
            student.LastName = "Martinez";
            student.Age = 26;
            Console.WriteLine(student.info());
            Console.ReadKey();
        }
    }
}
