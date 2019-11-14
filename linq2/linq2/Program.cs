using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare an array of objects type Pet
            Pet[] pets =
                {
                    new Pet("dog", "Missy", true),
                    new Pet("cat", "George", false),
                    new Pet("snake", "Fang", true),
                    new Pet("Budgie", "Harry", true),
                    new Pet("dog", "Terry", false),
                    new Pet("dog", "Charlie", true)
                };

            //Call Print function passing it the array of Pets to print out the ToString() method for each Pet
            Console.WriteLine("All Pets>>>>>");
            Print<Pet>(pets);

            //Print out all the nice pets after Querying with LINQ
            Console.WriteLine(">>>Nice Pets");
            var nicePets =
                from p in pets
                where p.Nice    //Query the value of the boolean attribute default as true
                select p;
            Print(nicePets);

            //Only Print the names of the nice Pets
            Console.WriteLine("Names of Nice Pets");
            var nicePetName =
                from p in pets
                where p.Nice
                select p.Name;
            Print<string>(nicePetName);  //Note the type is <string> as the var has been populated with p.Name(s)

            //Multiple Condtions
            Console.WriteLine("Nice Dog Names:");
            var niceDogNames =
                from p in pets
                where p.Species == "dog" && p.Nice   //Multiple where conditions for LINQ, case sensitive
                select p.Name;
            Print<string>(niceDogNames);

            //Select Nice pets ordered by Pet Names
            Console.WriteLine(">>>Nice Pets in name order");
            var nicePetsInOrder =
                from p in pets
                where p.Nice    //bool condition true?
                orderby p.Name   //alphabetical order
                select p.Name;
            Print<string>(nicePetsInOrder);  //Print the names

            //Select the Name and Species of a collection
            Console.WriteLine("Select the name and Species of a collection");
            var nameSpecies =
                from p in pets
                orderby p.Name
                select new { p.Name, p.Species };  //Create a new instance of var object called nameSpecies

            foreach (var obj in nameSpecies)  //Access the attributes of the nameSpecies objects
            {
                Console.WriteLine("Name: {0}, and Species: {1}", obj.Name, obj.Species);
            }

            //VARIATION ON THE ABOVE
            Console.WriteLine("Select the name and Species of a collection\n and change name of property");
            var nameSpecies2 =
                from p in pets
                orderby p.Name
                select new { PetName = p.Name, PetSpecies = p.Species };
            //Create a new instance of var object called nameSpecies
            //Similar to 'AS' in SQL assigning the property a new name.

            foreach (var obj in nameSpecies2)  //Access the attributes of the nameSpecies2 objects
            {
                Console.WriteLine("Name: {0}, and Species: {1}", obj.PetName, obj.PetSpecies); //access via new names
            }


            //Keep Open
            Console.ReadKey();
        }

        //Print Method, passing a generic type
        static void Print<T>(IEnumerable<T> elts)
        {
            foreach (T elt in elts)
            {
                //This will call the To.String() method in the class
                Console.WriteLine(elt);
            }
        }
    }
}
