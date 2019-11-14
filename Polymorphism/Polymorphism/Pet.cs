using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Pet : Animal
    {
        private string name;

        public Pet(string n, string s) : base(s)
        {
            name = n;
        }

        //Overriden ToString Methed that was also Overridden in Animal Class
        public override string ToString()
        {
            return "Pet named: " + name + ",who is a:" + GetSpecies();
        }
    }
}
