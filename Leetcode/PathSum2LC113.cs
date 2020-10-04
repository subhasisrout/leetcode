using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class PathSum2LC113
    {
        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            IList<IList<int>> result = new List<IList<int>>();

            PathSumUtil(root, sum, result, new List<int>());

            return result;
        }

        private void PathSumUtil(TreeNode root, int sum, IList<IList<int>> result, List<int> currentList)
        {
            if (root == null)
                return;

            if (root.val > sum)
                return;

            currentList.Add(root.val);

            if (root.val == sum && root.left == null && root.right == null)
            {
                result.Add(currentList);
                return;
            }

            PathSumUtil(root.left, sum - root.val, result, new List<int>(currentList));
            PathSumUtil(root.right, sum - root.val, result, new List<int>(currentList));

        }
    }
}
