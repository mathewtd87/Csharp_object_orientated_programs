using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //We have generic classes
    //We can also have generic methods
    //This allows us to reuse code for different data types
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections.Generic.               uncomment that to see the generics

            //Calling the star method below making the data type an int with value in the argument.
            Console.WriteLine(Star<int>(23));
            //Same method now receiveing a string as the data type.
            Console.WriteLine(Star<string>("hello"));


            //Create new instance of the class MyList using int
            MyList<int> list1 = new MyList<int>();
            //Add some values using the function within the class.
            list1.Add(23);
            list1.Add(-2);
            list1.Add(124);
            list1.PrintList();   //Call the function to output the elements that have been added

            //Test IsInList Method for list1
            if (list1.IsInList(-2))
                Console.WriteLine("-2 is in List 1");



            //Create another instance of MyList this time using string
            MyList<string> list2 = new MyList<string>();
            //Add a string
            list2.Add("Hello");
            list2.Add("World");
            list2.PrintList();

            //This list will create an array of instances of type 'Car' (See class called Car)
            MyList<Car> list3 = new MyList<Car>();
            list3.Add(new Car("Subaru"));
            list3.Add(new Generics.Car("mazda"));
            list3.Add(new Generics.Car("mercedes"));
            list3.PrintList();

            //Need to create a separate instance of Car then add it to the List
            Car rolls = new Car("Roller");
            list3.Add(rolls);
            list3.PrintList();
            //Check IsInList list3 of type Car. The .Equals works with primitive and object types, but not generic types.
            if (list3.IsInList(rolls))
            {
                Console.WriteLine("Roller Is in List 3");
            }




            Console.ReadKey();
        }

        //Method using Generics. The 'T' represents the Data type, (T obj) is the parameter.
        public static string Star<T>(T obj)
        {
            T x = obj;  //Can use the type and assign it to a new variable within the method.
            return "*" + x.ToString() + "*";
        }
    }
}
