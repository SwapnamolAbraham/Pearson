using System;

namespace PearsonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Palindrome palindrome = new Palindrome();
            //bool result = palindrome.FindPalindrome("A man, a plan, a canal, Panama!");
            //if(result == true)
            //Console.WriteLine("Palindrome");
            //else
            //Console.WriteLine("Not Palindrome");

            // Romans romans = new Romans();
            //string romanNumber = romans.FindRomanLetters("4001");
            // Console.WriteLine(romanNumber);

            //Fibonacci fibonacci = new Fibonacci();
            //int result = fibonacci.FindFibonacci(5);
            //Console.WriteLine(result);

            CoinChange changes = new CoinChange();
            int result = changes.FindCoinChanges(111);
            Console.WriteLine(result);
        }
    }
}
