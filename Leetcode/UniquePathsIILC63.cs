using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// #DP
namespace Leetcode
{
    public class UniquePathsIILC63
    {
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            int m = obstacleGrid.Length;
            int n = obstacleGrid[0].Length;

            int[,] dpArray = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                if (obstacleGrid[i][0] == 0)
                    dpArray[i, 0] = 1;
                else
                    break;
            }
            for (int i = 0; i < n; i++)
            {
                if (obstacleGrid[0][i] == 0)
                    dpArray[0, i] = 1;
                else
                    break;
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (obstacleGrid[i][j] == 0)
                        dpArray[i, j] = dpArray[i, j - 1] + dpArray[i - 1, j];
                    else
                        dpArray[i, j] = 0;
                }
            }
            return dpArray[m - 1, n - 1];
        }

    }
}
