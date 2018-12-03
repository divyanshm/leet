
namespace Leetcode.LinkedList
{
    class ReverseListProblem
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            ListNode prev = null, current = head;
            while (current != null)
            {
                var next = current.next;
                current.next = prev;

                prev = current;
                current = next;
            }

            return prev;
        }
    }
}
