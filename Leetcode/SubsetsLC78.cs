﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This is a dfs PLUS backtrackking problem. For visuals, use SubsetsLC78.jpg
// Use DFS plus backtrackking, whenever the problem is like - "possible number of", "all exhaustive list of"
// On the contrary, if the problem is maximum/minimum #'s of, its "greedy"
// #DFS #Backtrack #Graph
// #RememberPattern

namespace Leetcode
{
    public class SubsetsLC78
    {
        IList<IList<int>> retval = new List<IList<int>>();
        public IList<IList<int>> Subsets(int[] nums)
        {
            dfsAndBackTrack(0, nums, new List<int>());
            return retval;
        }
        void dfsAndBackTrack(int index, int[] nums, List<int> current)
        {
            retval.Add(new List<int>(current)); //new List() is for making DEEPCOPY, as current reference keep on changing.
            for (int i = index; i < nums.Length; i++) // This corresponds to the 3 main branches in the visual [1 -- 2 -- 3]
            {
                //There is one extra check here in Subsets 2 if (i > index && nums[i] == nums[i-1]) continue;
                current.Add(nums[i]);
                dfsAndBackTrack(i + 1, nums, current);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}