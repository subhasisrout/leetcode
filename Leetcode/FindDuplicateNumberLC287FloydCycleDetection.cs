// Remember slow and fast are NOT slow fast indices, but rather number reffered by the indices
// #RememberPattern
// Explanation in https://www.youtube.com/watch?v=dfIqLxAf-8s
// Other option for O(1) solution is "CHANGING THE ARRAY" by multiplying numbers by -1.
namespace Leetcode
{
    public class FindDuplicateNumberLC287FloydCycleDetection
    {
        public int FindDuplicate(int[] nums)
        {
            int slow = 0;
            int fast = 0;
            do
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
            }
            while (slow != fast);

            slow = 0;
            // fast is where it met in the last loop

            while (slow != fast)
            {
                slow = nums[slow];
                fast = nums[fast];

            }
            return slow; //or fast as both are same.
        }
    }
}
