// #QuickSelect #Inspired from #AE
// #AE solution much more intuitive than #Neetcode
// Just remember. 1. Choose "pivot" as the first (0) element. Swap with "pivot" is done with "right" in the end of loop.


namespace Leetcode
{
    public class KthLargestElementLC215
    {
        public int FindKthLargest(int[] nums, int k)
        {
            int position = nums.Length - 1 - k; // if we sort ascending. Else it will be just k - 1, if we sort descending.           
            QuickSelectHelper(nums, 0, nums.Length - 1, k);
            return nums[position];
        }

        private void QuickSelectHelper(int[] array, int start, int end, int k)
        {
            if (end <= start)
                return;
            int pivot = start;
            int left = start + 1;
            int right = end;

            while (left <= right)
            {
                if (array[left] > array[pivot] && array[right] < array[pivot])
                    Swap(array, left, right);
                else if (array[left] <= array[pivot])
                    left++;
                else if (array[right] >= array[pivot])
                    right--;
            }
            Swap(array, pivot, right);
            if (right == array.Length - 1 - k)
                return;
            else if (array.Length - 1 - k < right)
                QuickSelectHelper(array, start, right - 1, k); // (because at 'right', now is the NEW 'pivot')
            else
                QuickSelectHelper(array, right + 1, end, k);
        }

        private void Swap(int[] arr, int index1, int index2)
        {
            int tmp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = tmp;
        }
    }
}
