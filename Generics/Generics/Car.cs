using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //Creating a class called Car to demonstrate our Generic MyList creating an array of Car type objects.
    class Car
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

        //This overide is to accomodate the method in the MyList class which will only print the class name of Car
        public override string ToString()
        {
            return type;
        }
    }

}
