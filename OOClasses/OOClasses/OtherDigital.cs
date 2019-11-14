/* CSC10210 Assignment 1 Part 2, OtherDigital class
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
    class OtherDigital : MediaItem
    {
        private string additionalInfo;

        public OtherDigital(string t, string ai) : base(t)
        {
            additionalInfo = ai;
        }

        public string AdditionalInfo
        {
            get
            {
                return additionalInfo;
            }

            set
            {
                additionalInfo = value.ToString();
            }
        }
    }
}

