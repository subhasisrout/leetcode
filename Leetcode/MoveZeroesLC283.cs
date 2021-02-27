// #Similar question from AlgoExpert - you dont need to maintain the 
// order of other elements. To do that, you can use 2 pointers (i pointing to 0)
// and j (pointing to length - 1). i++ and j-- accordingly.

namespace Leetcode
{
    public class MoveZeroesLC283
    {
        public void MoveZeroes(int[] nums)
        {
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                    nums[index++] = nums[i];
            }

            for (int i = index; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }

    }
}
