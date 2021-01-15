// #TODO Absorb intuition
// #Looks like a pattern
// #NotWorking

using System;
using System.Collections.Generic;

namespace Leetcode
{
    public class MaxWidthRampLC962
    {
        public int MaxWidthRamp(int[] A)
        {
            int n = A.Length;
            int[] B = new int[n];
            for (int i = 0; i < A.Length; i++)
            {
                B[i] = i;
            }
            Array.Sort(B, new IndexPositionValueComparer(A));

            int ans = 0;
            int minIdx = B[0];
            for (int i = 0; i < B.Length; i++)
            {
                ans = Math.Max(ans, B[i] - minIdx);
                minIdx = Math.Min(minIdx, B[i]);
            }
            return ans;
        }
    }
    public class IndexPositionValueComparer : IComparer<int>
    {
        private int[] A;
        public IndexPositionValueComparer(int[] aValues)
        {
            A = aValues;
        }
        public int Compare(int x, int y)
        {
            return A[x] - A[y];
        }
    }
}
