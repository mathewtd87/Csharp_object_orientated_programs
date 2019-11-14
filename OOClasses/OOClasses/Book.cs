/* CSC10210 Assignment 1 Part 2, Book Class
 * Mathew Turner-Dauncey
 * 2017
 * Version 1.0
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOClasses
{
    class Book : MediaItem
    {
        private string author;

        public Book(string t, string a) : base(t)
        {
            author = a;
        }

        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value.ToString();
            }
        }
    }
}
