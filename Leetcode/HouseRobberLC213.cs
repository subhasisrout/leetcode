
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

        // Below method without HELPER is MORE INTUITIVE
        public int Rob2(int[] nums)
        {
            int[] dp = new int[nums.Length - 1];
            if (nums.Length == 1)
                return nums[0];
            if (nums.Length == 2)
                return Math.Max(nums[0], nums[1]);

            // 0th element to second last element
            dp[0] = nums[0];
            dp[1] = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < nums.Length - 1; i++)
            {
                dp[i] = Math.Max(dp[i - 1], dp[i - 2] + nums[i]);
            }
            var val1 = dp[dp.Length - 1];

            // 1st element to last element
            dp = new int[nums.Length - 1];
            dp[0] = nums[1];
            dp[1] = Math.Max(nums[1], nums[2]);
            for (int i = 2; i < nums.Length - 1; i++)
            {
                dp[i] = Math.Max(dp[i - 1], dp[i - 2] + nums[i + 1]); //note i+1 for nums. Try to visualize.
            }
            var val2 = dp[dp.Length - 1];

            return Math.Max(val1, val2);
        }

    }
}
