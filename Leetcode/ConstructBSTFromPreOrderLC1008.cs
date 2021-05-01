using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ConstructBSTFromPreOrderLC1008
    {
        class TreeInfo
        {
            public int RootIdx { get; set; }
            public TreeInfo(int rootIdx)
            {
                this.RootIdx = rootIdx;
            }
        }
        public TreeNode BstFromPreorder(int[] preorder)
        {
            TreeInfo treeInfo = new TreeInfo(0);
            return ConstructBST(Int32.MinValue, Int32.MaxValue, preorder, treeInfo);
        }
        private TreeNode ConstructBST(int lowerBound, int upperBound, int[] preOrderTraversalValues, TreeInfo currentSubtree)
        {
            if (currentSubtree.RootIdx == preOrderTraversalValues.Length)
                return null;

            int currentSubtreeRootIdx = currentSubtree.RootIdx;
            int currentSubtreeVal = preOrderTraversalValues[currentSubtreeRootIdx];

            if (currentSubtreeVal < lowerBound || currentSubtreeVal >= upperBound)
                return null;

            currentSubtree.RootIdx = currentSubtree.RootIdx + 1;
            var leftSubtree = ConstructBST(lowerBound, currentSubtreeVal, preOrderTraversalValues, currentSubtree);
            var rightSubtree = ConstructBST(currentSubtreeVal, upperBound, preOrderTraversalValues, currentSubtree);
            TreeNode root = new TreeNode(currentSubtreeVal);
            root.left = leftSubtree;
            root.right = rightSubtree;
            return root;
        }

    }
}
