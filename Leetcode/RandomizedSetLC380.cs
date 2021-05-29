using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// #RememberPattern
// #ingenious way to use list.RemoveAt(idx) in O(1) operation
// #TODO LC 381 (Hard variant of the same).

namespace Leetcode
{
    public class RandomizedSet
    {
        private Dictionary<int, int> valueIndexMap;
        List<int> numList;

        /** Initialize your data structure here. */
        public RandomizedSet()
        {
            valueIndexMap = new Dictionary<int, int>();
            numList = new List<int>();

        }

        /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
        public bool Insert(int val)
        {
            if (valueIndexMap.ContainsKey(val)) return false;

            valueIndexMap.Add(val, numList.Count);
            numList.Add(val);
            return true;

        }

        /** Removes a value from the set. Returns true if the set contained the specified element. */
        public bool Remove(int val)
        {
            if (!valueIndexMap.ContainsKey(val)) return false;

            int pos = valueIndexMap[val];
            
            //Copy lastItem on the position of elementToBeRemoved. Also update map.
            int lastItem = numList[numList.Count - 1];
            numList[pos] = lastItem;
            valueIndexMap[lastItem] = pos;
            
            //Actual remove. 
            valueIndexMap.Remove(val);
            numList.RemoveAt(numList.Count - 1);

            return true;

        }

        /** Get a random element from the set. */
        public int GetRandom()
        {
            return numList[new Random().Next(0, numList.Count)];
        }
    }

    /**
     * Your RandomizedSet object will be instantiated and called as such:
     * RandomizedSet obj = new RandomizedSet();
     * bool param_1 = obj.Insert(val);
     * bool param_2 = obj.Remove(val);
     * int param_3 = obj.GetRandom();
     */
}
