using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Kevin's solution is more concise and clear.
namespace Leetcode
{
    public class MonotonicArrayLC896
    {
        public bool IsMonotonic(int[] A)
        {
            int i = 1;
            int isIncDec = 0;
            while (i < A.Length - 1)
            {
                if (A[i] == A[i - 1])
                {
                    i++;
                    continue;
                }

                if (A[i] > A[i - 1])
                {
                    isIncDec = 1;
                    break;
                }
                if (A[i] < A[i - 1])
                {
                    isIncDec = -1;
                    break;
                }
            }
            i++;
            if (isIncDec == 0)
                return true; //all same elements
            else if (isIncDec == 1) //inc sequence
            {
                while (i < A.Length)
                {
                    if (A[i] < A[i - 1])
                    {
                        return false;
                    }
                    else
                    {
                        i++;
                    }
                }
                return true;
            }
            else //dec sequence
            {
                while (i < A.Length)
                {
                    if (A[i] > A[i - 1])
                    {
                        return false;
                    }
                    else
                    {
                        i++;
                    }
                }
                return true;

            }


        }
    }
}
