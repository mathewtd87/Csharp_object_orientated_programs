/* CSC10210 Assignment 1 Part 2, Game Class
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
    class Game : MediaItem
    {
        private string publisher;
        private string version;

        public Game(string t, string p, string v) : base(t)
        {
            publisher = p;
            version = v;
        }

        public string Publisher
        {
            get
            {
                return publisher;
            }

            set
            {
                publisher = value.ToString();
            }
        }

        public string Version
        {
            get
            {
                return version;
            }

            set
            {
                version = value.ToString();
            }
        }
    }
}
