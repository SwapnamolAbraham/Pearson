using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearsonTest
{
    public class Romans
    {
        public string FindRomanLetters(string strNumber)
        {

            int number = Int32.Parse(strNumber, NumberStyles.AllowThousands); 
            string romanNumber = "";
            Dictionary<string, int> romanNumbersDictionary = new()
            {                           
                { "M", 1000 },
                { "CM", 900 },
                { "D", 500 },
                { "CD", 400 },
                { "C", 100 },
                { "XC", 90 },
                { "L", 50 },
                { "XL", 40 },
                { "X", 10 },
                { "IX", 9 },
                { "V", 5 },
                { "IV", 4 },
                { "I", 1 }
            };

            foreach (var item in romanNumbersDictionary)
            {
                if (number <= 0) break;
                while (number >= item.Value)
                {
                    romanNumber += item.Key;
                    number -= item.Value;
                }
            }
            return romanNumber;         
        }

    }
}
