using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MissingNumInArrayLC448
    {
        //4, 3, 2, 7, 8, 2, 3, 1
        //currentnum = 4
        //4,3,2,-7,8,2,3,1
        //currentnum = 3
        //4,3,-2,-7,8,2,3,1
        //currentnum = 8
        //4,3,-2,-7,8,2,3,-1
        //currentnum = 2
        //4,-3,-2,-7,8,2,3,-1
        //currentnum = 3

        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            List<int> results = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int currentNum = Math.Abs(nums[i]);
                if (currentNum > 0)
                    nums[currentNum - 1] = Math.Abs(nums[currentNum - 1]) * -1;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                    results.Add(i + 1);
            }

            return results;
        }
    }
}
