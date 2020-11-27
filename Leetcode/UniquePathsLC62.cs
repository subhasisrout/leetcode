using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// #DP
namespace Leetcode
{
    public class UniquePathsLC62
    {
        public int UniquePaths(int m, int n)
        {
            int[,] dpArray = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                dpArray[i, 0] = 1;
            }
            for (int i = 0; i < n; i++)
            {
                dpArray[0, i] = 1;
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    dpArray[i, j] = dpArray[i, j - 1] + dpArray[i - 1, j];
                }
            }
            return dpArray[m - 1, n - 1];
        }

    }
}
