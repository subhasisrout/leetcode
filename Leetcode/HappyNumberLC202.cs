using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class HappyNumberLC202
    {
        public bool IsHappy(int n)
        {
            HashSet<int> calculatedSet = new HashSet<int>();
            return IsHappyUtil(n, calculatedSet);
        }

        private bool IsHappyUtil(int n, HashSet<int> calculatedSet)
        {
            if (calculatedSet.Contains(n))
                return false;
            else
                calculatedSet.Add(n);
            int sumSq = CalculateSumOfSquaresOfDigits(n);
            if (sumSq == 1)
                return true;
            return IsHappyUtil(sumSq, calculatedSet);
        }

        private int CalculateSumOfSquaresOfDigits(int n)
        {
            int sum = 0;
            int temp = -1;
            while (n != 0)
            {
                temp = n % 10;
                sum = sum + (temp * temp);
                n = n / 10;
            }
            return sum;
        }
    }
}
