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
            clsStudent student1 = new clsStudent();
            student1.Name = "Carlos";
            student1.LastName = "Martinez";
            student1.Age = 26;
            student1.GradeSchool = "second grade";
            Console.WriteLine(student1.info() + student1.GradeSchool);
            Console.WriteLine("My score is "+student1.AverageNotes(3,3,3));
            Console.ReadKey();
        }
    }
}
