using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract Class is a class where you don't ever intend to create an Object from it!
            //If you try to you'll get a syntax error!
            //Person p1 = new Person("barry");  ERROR
            //Create a Student class which inherits from Person to get it to work, you'll be 
            //forced to override abstract methods when you create the derived methods.

            Student barry = new Student(1234, "barry");
            Console.WriteLine(barry.GetDetails());

            Person p1 = barry; //Can create a variable of the abstract class in populate it with a derived class.(polymorphism)
            Console.WriteLine(p1.GetDetails());

            //ABSTRACT CLASSES allow you to dictate the users use of your class by 
            //forcing them to override the abstract methods, think the concept of Microsofts Class library..

            Console.ReadKey();

        }
    }
}