using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        //Interfaces allow you to make your classes comform to other peoples code.
        static void Main(string[] args)
        {
            //Create instance of class animal and call its Display methods.
            Animal doggy = new Animal("dog");
            doggy.Display();
            doggy.Display(4);
            Console.WriteLine();

            //Now call the display methods from inside a function which has been written below.
            DoDisplay(doggy);

            //Create new instance of the class Pet
            Pet joshsPet = new Interfaces.Pet("Charlie", "Dog");
            //Now notice the argument being passed to DoDisplay is of type Pet, can still populate the
            //parameter of the method which is an interface IDisplay
            DoDisplay(joshsPet);

            //Now we call DoDisplay using instance of class type 'Car' called subie as the parameter
            Car subie = new Interfaces.Car("Subaru");
            DoDisplay(subie);


            Console.ReadKey();
        }

        //Note the parameter here is a type of the interface. Can be passed an intance of a derived class 'Animal'
        static void DoDisplay(IDisplay d)
        {
            //Now the class which is passed through the parameter can access interface functions.
            d.Display(4);
            Console.WriteLine();
        }
    }




}