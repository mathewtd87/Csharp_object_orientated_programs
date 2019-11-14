using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        //Delegate is a function signature that can be used as a variable or a Parameter
        //Note this function header, it is a TYPE declaration
        public delegate int IntResult(int num1, int num2);

        static void Main(string[] args)
        {
            int i;
            i = 23;


            //IntResult func1;
            //func1 = Add;

            //Add is passed as a function using the delegate parameter of DoIntRes
            Console.WriteLine(DoIntRes(Add, 3, 5));
            Console.WriteLine(DoIntRes(Multi, 3, 10));

            Console.ReadKey();

        }

        //THESE 2 METHODS MUST BE IN THE FORM OF THE DECLARED(above main) DELEGATE
        //Example of the delegate
        public static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        //Another Example
        public static int Multi(int n1, int n2)
        {
            return n1 * n2;
        }

        //Passign a function as a parameter(This is how a delegate can be used)
        public static int DoIntRes(IntResult f, int number, int num2)
        {
            //Note how the passed function is referred to by the delegate name, in this case 'f'.
            return f(number, num2);
        }
    }
}
