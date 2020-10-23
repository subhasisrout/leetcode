using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class LevelOrderLC102
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();

            if (root == null)
                return result;

            

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            Queue<TreeNode> queueForNodesForAGivenLevel = null;
            List<int> listLevel = null;
            while (q.Count != 0)
            {
                //loop for a given level
                queueForNodesForAGivenLevel = new Queue<TreeNode>();
                listLevel = new List<int>();
                
                while (q.Count != 0)
                {
                    TreeNode node = q.Dequeue();
                    queueForNodesForAGivenLevel.Enqueue(node);  // or we can use .Count and do a for loop. (from Kevin's video)               
                }
                
                while (queueForNodesForAGivenLevel.Count != 0)
                {
                    TreeNode nodeAtAGivenLevel = queueForNodesForAGivenLevel.Dequeue();
                    listLevel.Add(nodeAtAGivenLevel.val);
                    if (nodeAtAGivenLevel.left != null)
                        q.Enqueue(nodeAtAGivenLevel.left);
                    if (nodeAtAGivenLevel.right != null)
                        q.Enqueue(nodeAtAGivenLevel.right);
                }
                result.Add(listLevel);
            }
            return result;
        }
    }
}
