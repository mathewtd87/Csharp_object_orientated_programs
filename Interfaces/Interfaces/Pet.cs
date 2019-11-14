using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //Add the interface to the Inheritance declaration
    //You can have 1 base class only, but you can have many Interfaces
    class Pet : Animal, IDisplay
    {
        private string name;
        //Constructor which populates the Animal species attribute as well.
        public Pet(string n, string a) : base(a)
        {
            name = n;
        }

        //Methods to override inherited interface methods
        public new void Display()
        {
            Console.WriteLine("Pet " + name + " is a " + GetSpecies());
        }

        public new void Display(int limit)
        {
            for (int i = 0; i < limit; i++)
                Console.WriteLine("Pet " + name + " is a " + GetSpecies());
        }
    }
}