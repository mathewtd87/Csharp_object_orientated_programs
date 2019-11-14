using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    //Class with Extension Methods, note STATIC class declaration
    //Cannot create instances of a static class, can only call the static methods.
    static class MyExtensions
    {
        //Can access print by typing 'string.Print()' in the program
        //The Print() method become available on string objects.
        public static void Print(this string str) //Parameter refers to the string object calling the method 
        {
            Console.WriteLine(str);
        }

        public static string Bracket(this string str)
        {
            return "[" + str + "]";
        }

        public static string Number(this int num, string str) {
            return num + " " + str;
        }

        //This method allows an extra parameter 'bookend' string
        public static string Surround(this string str, string bookend)
        {
            return bookend + str + bookend;
        }

    }
}
