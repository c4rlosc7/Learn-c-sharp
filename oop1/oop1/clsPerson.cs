using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    public class clsPerson
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }


        // CONSTRUCTOR PERSON
        public clsPerson()
        {
            Name = "";
            LastName = "";
            Age = 0;
        }

        public string info()
        {
            return "Name: " + Name + " LastName: " + LastName + " Age: " + Age + " ";
        }
    }
}
