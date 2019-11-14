using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //Animal inheriting from Interface IDisplay
    class Animal : IDisplay  //Like Abstract methods, interface methods must be implemented in derived classes
    {
        private string species;

        public Animal(string s)
        {
            species = s;
        }

        public string GetSpecies()
        {
            return species;
        }

        //Methodsfrom the Interface IDisplay
        public void Display()
        {
            Console.WriteLine(species);
        }

        public void Display(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.Write(species + " ");
            }
        }
    }
}
