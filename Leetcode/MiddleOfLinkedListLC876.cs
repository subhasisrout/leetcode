namespace Leetcode
{
    public class MiddleOfLinkedListLC876
    {
        public ListNode MiddleNode(ListNode head)
        {
            if (head == null)
                return null;

            ListNode slow = head;
            ListNode fast = head.next;

            while (fast != null)
            {
                slow = slow.next;

                if (fast.next != null)
                    fast = fast.next.next;
                else
                    fast = null; // come out of while loop
            }
            return slow;
        }
    }
}
