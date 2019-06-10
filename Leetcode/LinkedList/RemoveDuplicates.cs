namespace Leetcode.LinkedList
{
    // Q.83, Easy
    public class RemoveDuplicates
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if(head == null)
            {
                return null;
            }

            ListNode trav1 = head, trav2 = head.next;
            while(trav2 != null)
            {
                if(trav1.val == trav2.val)
                {
                    var nextNode = trav2.next;
                    trav1.next = nextNode;
                    trav2.next = null;
                    trav2 = nextNode;
                }
                else
                {
                    trav1 = trav2;
                    trav2 = trav2.next;
                }
            }

            return head;
        }
    }
}
