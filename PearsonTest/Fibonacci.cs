using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearsonTest
{
    public class Fibonacci
    {
        public int FindFibonacci(int length)
        {
            int result = 0;
            for (int i = 0; i < length; i++)
            {
                result= FibonacciSum(i);
                Console.WriteLine(result);
            }
            return result;
        }
        public int FibonacciSum(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
            {
                 return FibonacciSum(n - 1) + FibonacciSum(n - 2);
            }
        }
    }
}
