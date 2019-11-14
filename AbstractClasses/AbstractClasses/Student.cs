using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Student : Person
    {
        private int ID;

        public Student(int id, string n) : base(n)
        {
            ID = id;
        }

        //Override from the GetDetails method in the abstract class
        public override string GetDetails()
        {
            return "Student Details: ID is " + ID + " Name is " + GetName();
        }
    }
}
