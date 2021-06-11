
// #TODO


using System;

namespace Leetcode
{
    public class HouseRobberLC213
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            return Math.Max(RobHelper(0, nums.Length - 2, nums), RobHelper(1, nums.Length - 1, nums));
        }
        private int RobHelper(int startIdx, int endIdx, int[] nums)
        {
            int n = endIdx - startIdx + 1;
            if (n == 1) return nums[startIdx];
            int[] dp = new int[n];
            dp[0] = nums[startIdx];
            dp[1] = Math.Max(nums[startIdx], nums[startIdx + 1]);
            for (int i = startIdx + 2; i <= endIdx; i++)
            {
                int idx = (startIdx == 1) ? i - 1 : i; //hack for the second with startIdx = 1. It messes up the dp Array.
                dp[idx] = Math.Max(dp[idx - 1], nums[i] + dp[idx - 2]);
            }
            return dp[n - 1];

        }

    }
}
