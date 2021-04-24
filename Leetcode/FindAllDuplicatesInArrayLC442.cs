using System;
using System.Collections.Generic;

namespace Leetcode
{
    public class FindAllDuplicatesInArrayLC442
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            IList<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int currIdxAbs = Math.Abs(nums[i]);
                if (nums[currIdxAbs - 1] < 0)
                    result.Add(currIdxAbs);
                else
                    nums[currIdxAbs - 1] = nums[currIdxAbs - 1] * -1;
            }
            return result;
        }
    }
}
