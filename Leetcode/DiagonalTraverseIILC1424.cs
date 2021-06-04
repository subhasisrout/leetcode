﻿using System;
using System.Collections.Generic;
using System.Linq;

// #RememberPattern
// #FirstSolution :: All cells having (rowIndex + colIndex) same can be clubbed together and sorted.
// #SecondSolution :: Use a queue and traverse until queue is not empty. (Idea taken from Leetcode other submissions)
// Check the diagram which shows the sequencing of row and column index in the queue

namespace Leetcode
{
    public class DiagonalTraverseIILC1424
    {
        public int[] FindDiagonalOrder(IList<IList<int>> nums)
        {
            Queue<int[]> queue = new Queue<int[]>();
            queue.Enqueue(new int[] { 0, 0 });
            IList<int> result = new List<int>();

            while (queue.Count > 0)
            {
                int[] current = queue.Dequeue();
                result.Add(nums[current[0]][current[1]]);

                //current[1]==0 this is needed because you need to go down ONLY if you are in the FIRST ROW (i.e. top most)
                if (current[1] == 0 && nums.Count > current[0] + 1)
                    queue.Enqueue(new int[] { current[0] + 1, 0 });

                if (current[1] + 1 < nums[current[0]].Count)
                    queue.Enqueue(new int[] { current[0], current[1] + 1 });
            }
            return result.ToArray();
        }
        public int[] FindDiagonalOrder2(IList<IList<int>> nums)
        {
            int rows = nums.Count;
            IList<int> result = new List<int>();
            Dictionary<int, List<Tuple<int, int, int>>> map = new Dictionary<int, List<Tuple<int, int, int>>>();

            for (int i = 0; i < rows; i++)
            {
                IList<int> numsInAGivenRow = nums[i];
                for (int j = 0; j < numsInAGivenRow.Count; j++)
                {
                    int sum = i + j;
                    if (map.ContainsKey(sum))
                        map[sum].Add(new Tuple<int, int, int>(i, j, nums[i][j]));
                    else
                        map.Add(sum, new List<Tuple<int, int, int>>() { new Tuple<int, int, int>(i, j, nums[i][j]) });
                }
            }

            var diagonals = map.Count;
            for (int i = 0; i < diagonals; i++)
            {
                map[i].Sort(new TupleNumbersComparer());
                List<Tuple<int, int, int>> tupleNumbers = map[i];
                foreach (var tupleNum in tupleNumbers)
                {
                    result.Add(tupleNum.Item3);
                }
            }
            return result.ToArray();
        }

        private class TupleNumbersComparer : IComparer<Tuple<int, int, int>>
        {
            public int Compare(Tuple<int, int, int> x, Tuple<int, int, int> y)
            {
                return y.Item1.CompareTo(x.Item1);
            }
        }
    }

}
