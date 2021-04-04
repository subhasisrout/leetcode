// Also present in #AlgoExpert #AE
// #AlgoExpert #AE solution does not find PIVOT separately, BUT adds extra conditions in the MAIN binary search itself.



namespace Leetcode
{
    public class SearchInRotatedSortedArrayLC33
    {
        public static int ShiftedBinarySearch(int[] array, int target)
        {
            int pivotIndexLeft = FindPivot(array);
            var resultIdx = BinSearch(array, 0, pivotIndexLeft, target);
            if (resultIdx != -1)
                return resultIdx;
            return BinSearch(array, pivotIndexLeft + 1, array.Length - 1, target);
        }

        private static int BinSearch(int[] nums, int l, int r, int target)
        {
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] > target)
                    r = mid - 1;
                else
                    l = mid + 1;
            }
            return -1;
        }

        private static int FindPivot(int[] nums)
        {
            return FindPivotHelper(nums, 0, nums.Length - 1);
        }

        private static int FindPivotHelper(int[] nums, int low, int high)
        {
            if (high < low) return 0;
            int mid = low + (high - low) / 2;

            if (mid < high && nums[mid] > nums[mid + 1])
                return mid;

            if (mid > low && nums[mid] < nums[mid - 1])
                return mid - 1;

            if (nums[low] >= nums[mid])
                return FindPivotHelper(nums, low, mid - 1);

            return FindPivotHelper(nums, mid + 1, high);

        }
    }
}
