using Leetcode.SampleEntities;
using PriorityQueueFromCodeProject;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            //HappyNumberLC202 happyNumberLC202 = new HappyNumberLC202();
            //Console.WriteLine(happyNumberLC202.IsHappy(19));

            //SortArrayByParityLC905 sortArrayByParityLC905 = new SortArrayByParityLC905();
            //var res = sortArrayByParityLC905.SortArrayByParity2(new int[] { 3, 1, 2, 4 });

            //CountPrimesLC204 countPrimesLC204 = new CountPrimesLC204();           

            //PartitionLabelsLC763 partitionLabelsLC763 = new PartitionLabelsLC763();
            //var result = partitionLabelsLC763.PartitionLabels("ababcbacadefegdehijhklij");

            //LongestCommonPrefixLC14 longestCommonPrefixLC14 = new LongestCommonPrefixLC14();
            //var res = longestCommonPrefixLC14.LongestCommonPrefix(new string[] { "flower", "flow", "flight" });

            //PartitionEqualSubsetSumLC416 partitionEqualSubsetSumLC416 = new PartitionEqualSubsetSumLC416();
            //Console.WriteLine(partitionEqualSubsetSumLC416.CanPartition(new int[] { 1, 5, 5, 11, 8, 2, 6, 2, 1, 1, }));

            //RepeatedDNASequencesLC187 repeatedDNASequencesLC187 = new RepeatedDNASequencesLC187();
            //var retVal = repeatedDNASequencesLC187.FindRepeatedDnaSequences("AAAAAAAAAAA");

            //ListNode headA = new ListNode(1);
            //headA.next = new ListNode(2);
            //headA.next.next = new ListNode(4);
            //headA.next.next.next = new ListNode(4);
            //headA.next.next.next.next = new ListNode(5);

            //ListNode headB = new ListNode(1);
            //headB.next = new ListNode(3);
            //headB.next.next = new ListNode(4);
            //headB.next.next.next = headA.next.next;
            //headB.next.next.next.next = headA.next.next.next;
            //headB.next.next.next.next.next = headA.next.next.next.next;

            //ListNode headA = new ListNode(3);
            //ListNode headB = new ListNode(2);
            //headB.next = headA;

            //MergeSortedListLC21 mergeSortedListLC21 = new MergeSortedListLC21();
            //var res = mergeSortedListLC21.MergeTwoLists(headA, headB);

            //IntersectionOfTwoLinkedListLC160 intersectionOfTwoLinkedListLC160 = new IntersectionOfTwoLinkedListLC160();
            //var intersectionNode = intersectionOfTwoLinkedListLC160.GetIntersectionNode(headA, headB);

            //MinCostToConnectSticksLC1167Premium minCostToConnectSticksLC1167Premium = new MinCostToConnectSticksLC1167Premium();
            //var result = minCostToConnectSticksLC1167Premium.ConnectSticks(new int[] {1,8,3,5});

            //AddStringsLC415 addStringsLC415 = new AddStringsLC415();
            //var result = addStringsLC415.AddStrings("1", "9");

            //BagofTokensLC948 bagofTokensLC948 = new BagofTokensLC948();
            //var output = bagofTokensLC948.BagOfTokensScore(new int[] {100, 200 }, 150);

            //ReorganizeStringLC767 reorganizeStringLC767 = new ReorganizeStringLC767();
            //var res = reorganizeStringLC767.ReorganizeString("aaab");

            //PriorityQueue<Employee,Employee> maxHeap = new PriorityQueue<Employee,Employee>(EmployeeUtils.GetEmployees(), new EmployeeComparer());
            //var x = maxHeap.DequeueValue();

            //MinimumDominoRotationLC1007 minimumDominoRotationLC1007 = new MinimumDominoRotationLC1007();
            //var result = minimumDominoRotationLC1007.MinDominoRotations(new int[] { 1,2,3,4,6 }, new int[] { 6,6,6,6,5 });

            //VerifyAlienDictionaryLC953 verifyAlienDictionaryLC953 = new VerifyAlienDictionaryLC953();
            //bool result = verifyAlienDictionaryLC953.IsAlienSorted(new string[] { "word", "world", "row" }, "worldabcefghijkmnpqstuvxyz");

            //LargestValuesFromLabelLC1090 largestValuesFromLabelLC1090 = new LargestValuesFromLabelLC1090();
            //var r = largestValuesFromLabelLC1090.LargestValsFromLabels(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 1, 2, 2, 3 }, 3, 1);

            //CoinChangeLC322 coinChangeLC322 = new CoinChangeLC322();
            //var coins = coinChangeLC322.CoinChange(new int[] { 1,5,6,10 }, 18);


            //GroupAnagramsLC49 groupAnagramsLC49 = new GroupAnagramsLC49();
            //var tmp = groupAnagramsLC49.GroupAnagrams(new string[] {"ate","eat","abc","tea","ball","bat","tab" });

            //ValidAnagramLC242 validAnagramLC242 = new ValidAnagramLC242();
            //Console.WriteLine(validAnagramLC242.IsAnagram("eat","ate"));


            //int[][] jaggedArray = new int[1][];
            //jaggedArray[0] = new int[] { 1, 2 };

            //RottingOrangesLC994 rottingOrangesLC994 = new RottingOrangesLC994();
            //rottingOrangesLC994.OrangesRotting(jaggedArray);

            //AsteroidCollisionLC735 asteroidCollisionLC735 = new AsteroidCollisionLC735();
            //var asteriodCollisionOutput = asteroidCollisionLC735.AsteroidCollision(new int[] { -2,-2,-2,-2 });

            //ValidPalindrome2LC680 validPalindrome2LC680 = new ValidPalindrome2LC680();
            //Console.WriteLine(validPalindrome2LC680.ValidPalindrome("abca"));
            //MissingNumInArrayLC448 missingNumInArrayLC448 = new MissingNumInArrayLC448();
            //var results = missingNumInArrayLC448.FindDisappearedNumbers(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 });


            //SingleNumberXORLC136 singleNumberXORLC136 = new SingleNumberXORLC136();
            //Console.WriteLine(singleNumberXORLC136.SingleNumber(new int[] {1,2,1,2,9 }));

            //LastStoneWeightLC1046 lastStoneWeightLC1046 = new LastStoneWeightLC1046();
            //Console.WriteLine(lastStoneWeightLC1046.LastStoneWeight(new int[] { 2, 7, 4, 1, 8, 1 }));

            //                  20
            //          10               30
            //      4       12       21      50
            //                           45      55
            //TreeNode root = new TreeNode(20);
            //root.left = new TreeNode(10);
            //root.right = new TreeNode(30);

            //root.left.left = new TreeNode(4);
            //root.left.right = new TreeNode(12);

            //root.right.left = new TreeNode(21);
            //root.right.right = new TreeNode(50);

            //root.right.right.left = new TreeNode(45);
            //root.right.right.right = new TreeNode(55);

            //BSTRightSideViewLC199 bSTRightSideViewLC199 = new BSTRightSideViewLC199();
            //bSTRightSideViewLC199.RightSideView(root);

            //ValidateBSTLC98 validateBSTLC98 = new ValidateBSTLC98();
            //Console.WriteLine(validateBSTLC98.IsValidBST(root));

            //BinaryTreePathsLC257 binaryTreePathsLC257 = new BinaryTreePathsLC257();
            //var binaryTreePaths = binaryTreePathsLC257.BinaryTreePaths(root);
            //KthSmallestInBSTLeetcode230 kthSmallestInBSTLeetcode230 = new KthSmallestInBSTLeetcode230();
            //Console.WriteLine(kthSmallestInBSTLeetcode230.KthSmallest(root, 3));

            //KthSmallestInBSTLeetcode230 obj1 = new KthSmallestInBSTLeetcode230();
            //Console.WriteLine(obj1.FindMin(root));



            //ReverseOnlyLetterLeetcode917 reverseOnlyLetterLeetcode917 = new ReverseOnlyLetterLeetcode917();
            //Console.WriteLine(reverseOnlyLetterLeetcode917.ReverseOnlyLetters("s-ub-has-is"));

            //LRUCache.LRUCacheLeetCode146 lruCache = new LRUCache.LRUCacheLeetCode146(3);
            //lruCache.Put(1, 1);
            //lruCache.Put(2, 2);
            //lruCache.Put(3, 3);
            //lruCache.Put(2, 22);
            //lruCache.Print();

            //SortCharByFreqLeetcode451 sortCharByFreqLeetcode451 = new SortCharByFreqLeetcode451();
            //Console.WriteLine(sortCharByFreqLeetcode451.FrequencySort("subhasisrout"));

            //char[,] board = new char[,] {
            //{ 'A', 'B', 'C', 'E' },
            //{ 'S', 'F', 'C', 'S' },
            //{ 'A', 'D', 'E', 'E' }
            //};
            //WordsearchLC79 wordsearchLC79 = new WordsearchLC79();
            //Console.WriteLine(wordsearchLC79.Exist(board, "ABCCED"));

            //int[] groupSizes = { 2,1,3,3,3,2};
            //var res = GroupThePeople(groupSizes);

            //int[] arr = { 3, 7, 10, 11, 45, 78, 90, 110, 120, 130, 1000, 9999 };
            //Console.WriteLine(BinarySearch(arr, 130));

            //Console.WriteLine(NumberOfSteps(1));

            //https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/submissions/
            //concept of using more spaces and increasing runtime performance (frequency array, greaterThan array)
            //int[] nums = { 8,1,2,2,3 };

            //int[] freqArr = new int[101];
            //int[] gtArr = new int[101];
            //int[] resultsArr = new int[nums.Length];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    freqArr[nums[i]] = freqArr[nums[i]] + 1;
            //}
            //for (int i = 1; i < 101; i++)
            //{
            //    gtArr[i] = gtArr[i-1] + freqArr[i-1];
            //}
            //for (int i = 0; i < resultsArr.Length; i++)
            //{
            //    resultsArr[i] = gtArr[nums[i]];
            //}

            //int[] resultArr = new int[nums.Length];

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int numberToBeCompared = nums[i];
            //    int result = 0;
            //    for (int j = 0; j < nums.Length; j++)
            //    {
            //        if (i != j && numberToBeCompared > nums[j])
            //            result++;
            //    }
            //    resultArr[i] = result;
            //}
            //Dictionary<int, List<int>> dictPosition = new Dictionary<int, List<int>>();
            //for (int i = 0; i < nums.Length ; i++)
            //{
            //    if (!dictPosition.ContainsKey(nums[i]))
            //    {
            //        dictPosition.Add(nums[i], new List<int> { i });
            //    }
            //    else
            //    {
            //        dictPosition[nums[i]].Add(i);
            //    }

            //}

            //quickSort(nums, 0, nums.Length - 1);

            //int[] arr2 = new int[nums.Length];

            //for (int i = 0; i < nums.Length ; i++)
            //{
            //    if (i == 0)
            //        arr2[i] = 0;
            //    else
            //    {
            //        if (nums[i] == nums[i-1])
            //        {
            //            arr2[i] = arr2[i - 1];
            //        }
            //        else
            //        {
            //            arr2[i] = i;
            //        }
            //    }
            //}

            //int[] arr3 = new int[nums.Length];

            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    //get position
            //    int positionfinder = nums[i];
            //    List<int> actualpositions = dictPosition[positionfinder];

            //    foreach (var actualposition in actualpositions)
            //    {
            //        arr3[actualposition] = arr2[i];
            //    }

            //}





        }

        public static IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            IList<IList<int>> res = new List<IList<int>>();
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            for (int i = 0; i < groupSizes.Length; i++)
            {
                if (!dict.ContainsKey(groupSizes[i]))
                    dict.Add(groupSizes[i], new List<int> { i });
                else
                    dict[groupSizes[i]].Add(i);
            }


            foreach (var item in dict)
            {
                int grpSize = item.Key;
                List<int> grpMembers = item.Value;
                List<int> innerList = new List<int>();
                int counter = 0;
                foreach (var member in grpMembers)
                {
                    innerList.Add(member);
                    counter++;
                    if (counter == grpSize)
                    {
                        res.Add(innerList);
                        innerList = new List<int>();
                        counter = 0;
                    }
                }
            }


            return res;
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                        return new int[] { i, j };
                }
            }
            return new int[] { -1, -1 };
        }

        static int BinarySearch(int[] arr, int num)
        {
            int left = 0;
            int right = arr.Length;

            while (left < right - 1)
            {
                int mid = (left + right) / 2;

                if (num == arr[mid])
                    return mid;
                if (num > arr[mid])
                {
                    left = mid;
                }
                else
                {
                    right = mid;
                }
            }
            return -1;

        }

        public static int NumberOfSteps(int num)
        {
            if (num == 0)
                return 0;
            if (num == 1)
                return 1;

            if (num % 2 == 0)
                return 1 + NumberOfSteps(num / 2);
            else
                return 1 + NumberOfSteps(num - 1);
        }

        static void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = qs_partition(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }
        static int qs_partition(int[] arr, int low,
                                   int high)
        {
            int pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (arr[j] < pivot)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
    }
}