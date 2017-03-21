using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    public class clsPerson
    {
        public string Name;

        public string LastName;

        public int Age;

        // CONSTRUCTOR 
        public clsPerson()
        {
            Name = "";
            LastName = "";
            Age = 0;
        }

        public string info()
        {
            return "Name: " + Name + " LastName: " + LastName + " Age: " + Age;
        }
    }
}
