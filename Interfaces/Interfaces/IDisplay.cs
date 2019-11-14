using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //Note the keyword interface, like a class, an Iterface can inherit an Interface. 
    //Convention:Name starts with 'I' (IDisplay), type "System." to see list, got to 'I' for interface.
    //This Interface is created so classes can inherit from it and then those classes can be an argument
    //for a method where this 'IDisplay' is the parameter.
    interface IDisplay
    {
        //System.  //See line 10.

        //An interface with 2 methods
        void Display();                         //Display once
        void Display(int i);               //Display i times
    }
}
