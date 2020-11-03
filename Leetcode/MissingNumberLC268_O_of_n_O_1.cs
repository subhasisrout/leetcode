using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MissingNumberLC268_O_of_n_O_1
    {
        public int MissingNumber(int[] nums)
        {
            int presentSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                presentSum += nums[i];
            }

            int totalSum = (nums.Length * (nums.Length + 1)) / 2;
            return totalSum - presentSum;
        }
    }
}
