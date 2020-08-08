using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class CoinChangeLC322
    {
        public int CoinChange(int[] coins, int amount)
        {
            int retVal = int.MaxValue;                
            return CoinChangeHelper(amount, coins,ref retVal);
        }

        private int CoinChangeHelper(int amount, int[] coins, ref int numCoins)
        {
            int minCoins = amount;
            for (int i = 0; i < coins.Length; i++)
            {
                if (amount == coins[i])
                    return 1;
            }

            for (int i = 0; i < coins.Length; i++)
            {
                if (coins[i] <= amount)
                    numCoins = 1 + CoinChangeHelper(amount - coins[i], coins, ref numCoins);
                if (numCoins < minCoins)
                    minCoins = numCoins;
            }
            return minCoins;
        }
    }
}
