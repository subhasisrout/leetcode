// #Self written. #Helper methods making it more readable.
// #Leetcode #LC34

namespace Leetcode
{
    public class SearchForRangeBinSearchAE
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int l = 0;
            int r = nums.Length - 1;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (target > nums[mid])
                    l = mid + 1;
                else if (target < nums[mid])
                    r = mid - 1;
                else
                {
                    int resultLeft = FindLeftMostTargetPos(nums, target, mid);
                    int resultRight = FindRightMostTargetPos(nums, target, mid);
                    return new int[] {resultLeft, resultRight };
                }
            }
            return new int[] {-1,-1};
        }

        private int FindRightMostTargetPos(int[] array, int target, int left)
        {
            if (left == array.Length - 1)
                return array.Length - 1;

            int l = left;
            int r = array.Length - 1;

            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (target < array[mid])
                    r = mid - 1;
                else
                {
                    if (mid == array.Length - 1)
                        return array.Length - 1;
                    else if (array[mid + 1] != target)
                        return mid;
                    else
                        l = mid + 1;
                }
            }
            return -1;
        }

        private int FindLeftMostTargetPos(int[] array, int target, int right)
        {
            if (right == 0)
                return 0;
            
            int l = 0;
            int r = right;

            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (target > array[mid])
                    l = mid + 1;
                else
                {
                    if (mid == 0)
                        return 0;
                    else if (array[mid - 1] != target)
                        return mid;
                    else
                        r = mid - 1;
                }
            }
            return -1;
        }
    }
}
