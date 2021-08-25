using System.Collections.Generic;

// #DFS #Backtrack #Graph
// #RememberPattern
// Observe the difference between this and LC78
// // This is more generic than AE version and can be applied in Permuatation-II as well. Learn this.

namespace Leetcode
{
    public class PermutationsLC46
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            bool[] visited = new bool[nums.Length];
            PermuteHelper(nums, result, new List<int>(), visited);
            return result;
        }
        private void PermuteHelper(int[] nums, IList<IList<int>> result, IList<int> current, bool[] visited)
        {
            if (current.Count == nums.Length)
            {
                result.Add(new List<int>(current));
                return;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                // In Permuations 2 - LC47 and Sorting required.
                // This line become if (visited[i] || i > 0 && nums[i] == nums[i-1] && !visited[i-1]) continue;
                if (visited[i]) continue; 
                visited[i] = true;
                current.Add(nums[i]);
                PermuteHelper(nums, result, current, visited);
                current.RemoveAt(current.Count - 1);
                visited[i] = false;
                // above 5-6 lines are a standard for all backtrackking problems.
            }
        }
    }
}
