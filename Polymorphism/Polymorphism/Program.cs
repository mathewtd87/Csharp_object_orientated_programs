using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create instance of the Animal class
            Animal a1 = new Animal("Tiger");

            //Check that the instance was created
            Console.WriteLine("a1 Species is a: {0}", a1.GetSpecies());

            //Object class Functions(inherited)

            //ToString thats inherited will return the namespace.class name
            PrintStuff(a1); //Could just be (a1), it will auto call the ToString Method
            //This has been overridden in the Animal class function to return "Species:...."


            //Create instance of Pet joshs Pet cat. Test the Overridden ToString method without the .ToString
            Pet joshsPet = new Pet("Albert", "Cat");
            PrintStuff(joshsPet);//method below main

            PrintStuff(new object()); //Creates new object and outputs the namespace path from original non
                                      //overridden .ToString()

            //This is originally a base object
            Object v;
            v = a1;         //This is now an Animal object
            Console.WriteLine(v);
            v = joshsPet;   //This is now a Pet object
            Console.WriteLine(v);

            //This is Originally an Animal variable
            Animal anim;
            anim = a1;
            Console.WriteLine(anim);
            anim = joshsPet;
            Console.WriteLine(anim + " pet version");
            //anim = v;  Throws error because v is an Object, which is a level above Animal.


            //Creating an Array of base class Objects, populating them with derived objects.
            Object[] arr = new Object[10];
            arr[0] = a1;        //Animal Object
            arr[1] = joshsPet;  //Pet Object


            //Read Key to Exit Program
            Console.ReadKey();
        }



        //Polymorphism (Multiple meanings for the same name)

        //Passing object as an argument to the method PrintStuff
        static void PrintStuff(Object o)
        {
            Console.WriteLine(o);
        }
    }
}
