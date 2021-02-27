using System;
using System.Collections.Generic;

// From Nick White

namespace Leetcode
{
    public class ThreeNumSumLC15
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (nums == null || nums.Length < 3)
                return result;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;

                int low = i + 1;
                int high = nums.Length - 1;

                int sum = 0 - nums[i];

                while (low < high)
                {
                    if (nums[low] + nums[high] > sum)
                        high--;
                    else if (nums[low] + nums[high] < sum)
                        low++;
                    else
                    {
                        result.Add(new List<int>() { nums[i], nums[low], nums[high] });
                        while (low < high && nums[low] == nums[low + 1]) low++;
                        while (low < high && nums[high] == nums[high - 1]) high--;
                        low++;
                        high--;
                    }
                }
            }

            return result;
        }
    }
}
