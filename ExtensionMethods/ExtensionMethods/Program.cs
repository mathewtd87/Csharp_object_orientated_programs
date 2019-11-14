using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Extension Methods is adding Methods to an already existing Class, whether our Class or not
namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //These variables will call the extension methods, their value will be the "this" parameter
            //see parameters in MyExtensions class
            string me = "Mathew";
            int unit = 1;

            //Call Print Method from MyExtensions class
            me.Print();

            //Call Bracket Method from MyExtensions class
            Console.WriteLine(me.Bracket());

            //Only requires the string parameter like surround method below.
            Console.WriteLine(unit.Number(me));

            //Surround Method, only requires the argument for the non 'this' parameter.
            Console.WriteLine(me.Surround("**"));



            //Keep Open
            Console.ReadKey();
        }
    }
}