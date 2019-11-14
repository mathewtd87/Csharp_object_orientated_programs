using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //This <T> means that the class is cut and paste throughout the instance of the class
    class MyList<T>
    {
        //Declare the Generic Type array
        private T[] data;
        private int next;
        //Constructor for the new instance of the class creating the new Generic Type Array
        public MyList()
        {
            data = new T[10];
            next = 0;
        }

        //Add and element of the generic type into the array
        public bool Add(T element)
        {
            //Make sure we're not over our array limit.
            if (next < data.Length)
            {
                data[next++] = element;
                return true;
            }
            else
                return false;
        }

        public void PrintList()
        {
            for (int i = 0; i < next; i++)
            {
                Console.WriteLine(data[i]);   //WriteLine Will automatically call the .ToString of the argument.
            }
        }

        //Check whether an element exists in the array
        public bool IsInList(T element)
        {
            for (int i = 0; i < next; i++)
            {
                //Generic types don't like == comparisons, so we use Equals() method inherited from 'Objects' class.
                if (data[i].Equals(element))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
