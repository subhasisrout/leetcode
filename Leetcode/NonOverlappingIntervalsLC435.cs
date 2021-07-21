using System;

// Took the idea of sorting by endTime from https://leetcode.com/problems/non-overlapping-intervals/discuss/91713/Java%3A-Least-is-Most
// Basically you want to greedily pick the the intervals which ends soon so as to accomodate more intervals (or remove less intervals)


namespace Leetcode
{
    public class NonOverlappingIntervalsLC435
    {
        public int EraseOverlapIntervals(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1])); // Single liner instead of using an #IComparer
            int count = 0;
            int closingTime = Int32.MinValue;
            for (int i = 0; i < intervals.Length; i++)
            {
                var curr = intervals[i];
                if (curr[0] >= closingTime)
                    closingTime = curr[1];
                else
                    count++;

            }
            return count;
        }
    }
}
