using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Animal
    {
        private string species;
        //Constructor
        public Animal(string s)
        {
            species = s;
        }

        //Get Species Function
        public string GetSpecies()
        {
            return species;
        }
        //This is OVERRIDING the ToString function in the base class, object class
        public override string ToString()
        {
            return "Species: " + species;
        }
    }
}