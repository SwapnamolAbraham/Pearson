using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearsonTest
{
    public class CoinChange
    {
        public int FindCoinChanges(int number)
        {

            int[] coins = {1,2,5,10,20,50,100};
            int coinChange =0;

            foreach (var coin in coins.Reverse())
            {
                if (number <= 0) break;
                while (number >= coin)
                {
                    coinChange++;
                    number -= coin;
                }
            }

            return coinChange;         
        }

    }
}
