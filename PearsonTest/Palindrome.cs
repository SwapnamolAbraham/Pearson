using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PearsonTest
{
    public class Palindrome
    {
        public bool FindPalindrome(String word)
        {
            word = Regex.Replace(word, @"[^0-9a-zA-Z]+", "");
            Boolean isPalindrome = false;
            if(!string.IsNullOrEmpty(word))
            {
                string reverseWord = new string(word.Reverse().ToArray());
                if (word.ToUpper() == reverseWord.ToUpper())
                    isPalindrome = true;
                else
                    isPalindrome = false;

            }
            return isPalindrome;
        }
    }
}
