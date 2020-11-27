using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class RemoveDuplicatesFromSortedLinkedListLC83
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode node = head;
            while (node != null)
            {
                ListNode nextNode = node.next;
                while (nextNode != null && node.val == nextNode.val)
                {
                    nextNode = nextNode.next;
                }
                node.next = nextNode;
                node = nextNode;
            }
            return head;
        }
    }
}
