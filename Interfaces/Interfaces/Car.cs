using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Car : IDisplay
    {
        private string type;

        public Car(string t)
        {
            type = t;
        }

        public string GetCarType()
        {
            return type;
        }

        //Implement Display methods from Inherited Interface IDisplay
        public void Display()
        {
            Console.Write(type + " brmm brmm");
        }

        public void Display(int limit)
        {
            Console.WriteLine(type);
            for (int i = 0; i < limit; i++)
                Console.WriteLine("brmm brmm");
        }

    }
}
