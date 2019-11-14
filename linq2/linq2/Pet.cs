using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq2
{
    //Creating an Object
    class Pet
    {
        public string Species { get; set; }
        public string Name { get; set; }
        public bool Nice { get; set; }

        public Pet(string s, string n, bool ni)
        {
            Species = s;
            Name = n;
            Nice = ni;
        }

        //Print out a string representation of the object
        public override string ToString()
        {
            //Customer message when ToString() is called on this object
            //Note the ternary operator for dealing with the boolean
            return "Pet " + Name + " is a " + Species + " and is " + (Nice ? "" : "NOT ") + "Nice";
        }

    }
}