using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //difference between jagged array and 2d array.
    // jagged array in .NET is int[][]. Array of array. Each array (inside the "master array") can be of differnet length
    //2d array (rectangular) in .NET is int[,]
    public class RottingOrangesLC994
    {
        public int OrangesRotting(int[][] grid)
        {
            HashSet<string> rottenOranges = new HashSet<string>();
            HashSet<string> freshOranges = new HashSet<string>();

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 2)
                        rottenOranges.Add(i + "," + j);
                    if (grid[i][j] == 1)
                        freshOranges.Add(i + "," + j);
                }

            }

            int[,] directions = new int[,] { { 1, 0 }, { 0, 1 }, { -1, 0 }, { 0, -1 } };

            HashSet<string> infectedOranges = null;
            int minutes = 0;
            while (freshOranges.Count > 0)
            {
                infectedOranges = new HashSet<string>();
                foreach (var rottenOrange in rottenOranges)
                {
                    int i = Convert.ToInt32(rottenOrange.Split(new string[] { "," },StringSplitOptions.RemoveEmptyEntries)[0]);
                    int j = Convert.ToInt32(rottenOrange.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)[1]);

                    for (int u = 0; u <= directions.GetUpperBound(0); u++)
                    {
                        int newI = i + directions[u, 0];
                        int newJ = j + directions[u, 1];

                        if (freshOranges.Contains(newI + "," + newJ))
                        {
                            infectedOranges.Add(newI + "," + newJ);
                            freshOranges.Remove(newI + "," + newJ);
                        }
                    }                    
                }

                if (infectedOranges.Count == 0)
                    return -1;

                minutes++;
                rottenOranges = infectedOranges;
            }
            return minutes;
        }
    }
}
