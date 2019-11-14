using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{   //Abstract in from of class name for an abstract class
    abstract class Person
    {
        private string name;

        public Person(string n)
        {
            name = n;
        }

        public string GetName()
        {
            return name;
        }
        public abstract string GetDetails(); //No object means we can't call this method?!?!

    }
}
