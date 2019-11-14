using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    //LINQ concept
    class Program
    {
        static void Main(string[] args)
        {
            //An rray of Numbers
            int[] numbers = { 23, 77, -20, 8, 0, -44, -3 };

            //variable to store the result of the linq query(var = negatives)
            // = 
            //Query (from x in array, where condition, select element)
            var negatives =
                from num in numbers
                where num < 0
                select num;

            //print each number in the LINQ query result 'negatives' array
            foreach (int n in negatives)
                Console.Write(n + ", ");
            //Return Cursor
            Console.WriteLine();

            //Use method to Print the numbers array
            Print(numbers);

            //Use method to Print the negatives array
            Print(negatives);

            //var myInteger = 23;
            //int myInteger2 = 23; //Most precise data type is always the best data definition for a variable

            //Using LINQ to sort an array of numbers using the 'orderby' syntax
            var sorted =
                from num in numbers   //from the array 'numbers'
                orderby num         //orderby the elements
                select num;
            Print(sorted);

            //Descending sort
            Console.WriteLine("Sort Number Descending:");
            var sortedDesc =
                from num in numbers
                orderby num descending
                select num;
            Print(sortedDesc);

            //Find numbers 0 or greater and sort in descending order
            Console.WriteLine("Positive Numbers in reverse order");
            var posRev =
                from num in numbers
                where num >= 0  //change this number to test the .Any() method below.
                orderby num descending
                select num;
            Print(posRev);

            //Built in methods exist for the linq result variable
            Console.WriteLine("There are {0} psitive numbers in the numbers array.", posRev.Count());


            //Any method will check if there are any elements in the collection
            if (posRev.Any())
            {
                Console.WriteLine("There are elements.");
            }
            else
            {
                Console.WriteLine("There are no elements");
            }

            //Max and min number methods.
            Console.WriteLine("Max is {0}, Min is {1}", numbers.Max(), numbers.Min());

            //Keep Open
            Console.ReadKey();

        }

        //Print Method which receives the array as an argument, IEnumerable 
        static void Print(IEnumerable<int> collection)
        {
            foreach (int elt in collection)
            {
                Console.Write(elt + ", ");
            }
            //Return Cursor
            Console.WriteLine();
        }
    }
}