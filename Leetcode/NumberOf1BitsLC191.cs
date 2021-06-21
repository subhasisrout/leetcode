// Also called the HammingWeight
// #Bitwise


namespace Leetcode
{
    public class NumberOf1BitsLC191
    {
        public int HammingWeight(uint n)
        {
            int count = 0;
            while (n != 0)
            {
                count++;
                n = n & (n - 1);
            }
            return count;
        }
        public int HammingWeight2(uint n)
        {
            int mask = 1;
            int count = 0;
            for (int i = 0; i < 32; i++)
            {
                if ((n & mask) != 0)
                    count++;
                mask <<= 1;
            }
            return count;
        }
    }
}
