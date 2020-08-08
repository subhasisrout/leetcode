//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Leetcode
//{
//    public class ReorganizeStringLC767
//    {
//        public string ReorganizeString(string S)
//        {
//            char[] arr = S.ToCharArray();
//            Dictionary<char, int> map = new Dictionary<char, int>();
//            for (int i = 0; i < arr.Length; i++)
//            {
//                map.Add(arr[i], !map.ContainsKey(arr[i]) ? 1 : map[arr[i]] + 1);
//            }

            

//            StringBuilder output = new StringBuilder();
//            while (priorityQueue.Count > 1)
//            {
//                char current = priorityQueue.Dequeue().Char;
//                map[current] = map[current] - 1;
//                char next = priorityQueue.Dequeue().Char;
//                map[next] = map[next] - 1;
//                output.Append(current);
//                output.Append(next);

//                if (map[current] > 0)
//                    priorityQueue.Enqueue(current);

//                if (map[next] > 0)
//                    priorityQueue.Enqueue(next);

//            }



//        }
//    }
//    public class CharCount : IComparable<CharCount>
//    {
//        public char Char { get; set; }
//        public int Count { get; set; }

//        public int CompareTo(CharCount other) //low to high
//        {
//            return this.Count.CompareTo(other.Count);
//        }
//    }
//}
