using System;
using System.Collections.Generic;

// #Hard #Tricky #LC #Leetcode 128. #LC128

namespace Leetcode
{
    public class LargestRangeAE
    {
        //NLogN because of sorting, but no extra space.
        public static int[] LargestRange(int[] array)
        {
            if (array.Length == 1)
                return new int[] { array[0], array[0] };
            Array.Sort(array);
            int i = 0;
            int j = i + 1;
            int origI = i;
            int globalMaxRangeLength = 0;
            int[] result = new int[2];
            while (j < array.Length)
            {
                if (array[j] - array[i] == 0)
                {
                    i++;
                    j++;
                    continue;
                }
                else if (array[j] - array[i] == 1)
                {
                    if (j - origI > globalMaxRangeLength)
                    {
                        result[0] = array[origI];
                        result[1] = array[j];
                        globalMaxRangeLength = j - origI;
                    }
                    i++;
                    j++;
                }
                else
                {
                    i = j;
                    j = i + 1;
                    origI = i;
                }
            }
            return result;
        }

        //O(N) time, but extra space needed. A lot cleaner and intuitive too.
        public static int[] LargestRange2(int[] nums)
        {
            Dictionary<int, bool> map = new Dictionary<int, bool>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!map.ContainsKey(nums[i]))
                    map.Add(nums[i], true);
            }

            int longestLength = 0;
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                int currNum = nums[i];
                if (map[currNum] == false)
                    continue;
                map[currNum] = false;
                int currentLength = 1;

                int left = currNum - 1;
                int right = currNum + 1;
                while (map.ContainsKey(left))
                {
                    map[left] = false;
                    left -= 1;
                    currentLength += 1;
                }
                while (map.ContainsKey(right))
                {
                    map[right] = false;
                    right += 1;
                    currentLength += 1;
                }
                if (currentLength > longestLength)
                {
                    longestLength = currentLength;
                    result[0] = left + 1; //adjusting for while loop and assigning currNum - 1
                    result[1] = right - 1; //adjusting for while loop and assigning currNum + 1
                }
            }
            return result;


        }
    }
}
