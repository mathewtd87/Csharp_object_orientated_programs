/* CSC10210 Assignment 1 Part 2 MediaItem Class
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
    class MediaItem
    {
        private string title;

        public MediaItem(string t)
        {
            title = t;
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value.ToString();
            }
        }
    }
}