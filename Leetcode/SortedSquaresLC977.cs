using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class SortedSquaresLC977
    {
        public int[] SortedSquares(int[] A)
        {
            if (A == null || A.Length == 0)
                return null;

            if (A.Length == 1)
                return new int[] { A[0] * A[0] };

            int i = 0;
            int j = 0;
            while (A[j] < 0)
            {
                j++;
            }
            if (j > 0)
                i = j - 1;

            int[] result = new int[A.Length];

            if ( j == 0)
            {
                for (int k = 0; k < A.Length; k++)
                {
                    result[k] = A[k] * A[k];
                }
                return result;
            }

            int counter = 0;
            while (j < A.Length && i >= 0)
            {
                if (Math.Abs(A[i]) < Math.Abs(A[j]))
                {
                    result[counter++] = A[i] * A[i];
                    i--;
                }
                else
                {
                    result[counter++] = A[j] * A[j];
                    j++;
                }
            }

            while (j < A.Length)
            {
                result[counter++] = A[j] * A[j];
                j++;
            }

            while (i >= 0)
            {
                result[counter++] = A[i] * A[i];
                i--;
            }


            return result;
        }
    }
}
