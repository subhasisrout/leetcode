using System.Collections.Generic;

// #DFS #Backtrack #Graph
// #RememberPattern
// Observe the difference between this and LC78

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
                if (visited[i]) continue;
                visited[i] = true;
                current.Add(nums[i]);
                PermuteHelper(nums, result, current, visited);
                current.RemoveAt(current.Count - 1);
                visited[i] = false;

            }
        }
    }
}
