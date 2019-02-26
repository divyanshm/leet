namespace Leetcode.LinkedList
{
    public class RemoveListValue
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode prev = null, current = head, newHead = head;
            if(head == null)
            {
                return null;
            }

            while(current != null)
            {
                if(current.val == val)
                {
                    if(prev != null)
                    {
                        prev.next = current.next;
                    }
                    else
                    {
                        newHead = current.next;
                    }
                }
                else
                {
                    prev = current;
                }

                current = current.next;
            }

            return newHead;
        }
    }
}
