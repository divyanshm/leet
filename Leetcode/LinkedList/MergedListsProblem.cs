namespace Leetcode.LinkedList
{
    public class MergedListsProblem
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }
            else if (l2 == null)
            {
                return l1;
            }
            else
            {
                ListNode head = null;
                ListNode current = null;
                ListNode previous = null;
                while (l1 != null && l2 != null)
                {
                    if (l1.val <= l2.val)
                    {
                        current = l1;

                        l1 = l1.next;
                    }
                    else
                    {
                        current = l2;

                        l2 = l2.next;
                    }

                    if (head == null)
                    {
                        head = current;
                        previous = head;
                    }
                    if(previous != null)
                    {
                        previous.next = current;
                        previous = current;
                    }

                }

                if (l1 != null)
                {
                    previous.next = l1;
                }
                else if (l2 != null)
                {
                    previous.next = l2;
                }

                return head;
            }
        }
    }
}
