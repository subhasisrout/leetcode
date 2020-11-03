using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ClimbStairsLC70
    {
        public int ClimbStairs(int n)
        {
            int count = 0;
            if (n == 0)
                return count;

            int sum = 0;
            ClimbStairsUtil(n,ref count, sum);
            return count;

        }

        private void ClimbStairsUtil(int n,ref int count, int sum)
        {
            if (sum == n)
            {
                count++;
                return;
            }

            if (sum > n)
                return;

            ClimbStairsUtil(n, ref count, sum + 1);
            ClimbStairsUtil(n, ref count, sum + 2);
        }
    }
}
