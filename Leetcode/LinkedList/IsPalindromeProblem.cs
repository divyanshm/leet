namespace Leetcode.LinkedList
{
    public class IsPalindromeProblem
    {
        public bool IsPalindrome(ListNode head)
        {
            if(head == null || head.next == null)
            {
                return true;
            }

            var length = 0;
            ListNode temp = head;
            while(temp != null)
            {
                length++;
                temp = temp.next;
            }

            int tailPosition = length % 2 == 0 ? length / 2 : length / 2 + 1;
            ListNode secondList = null, firstListTail = null, current = head; int currentNode = 1;
            while(currentNode < tailPosition)
            {
                current = current.next;
                currentNode++;
            }

            firstListTail = current;
            secondList = current.next;
            firstListTail.next = null;

            var secondHalfReversed = Reverse(secondList);
            bool isPalindrome = true;
            while(head != null && secondHalfReversed != null && isPalindrome)
            {
                isPalindrome = isPalindrome && head.val == secondHalfReversed.val;
                head = head.next;
                secondHalfReversed = secondHalfReversed.next;
            }

            return isPalindrome;
        }

        private ListNode Reverse(ListNode head)
        {
            ListNode prev = null, current = head, next;
            while(current != null)
            {
                next = current.next;

                current.next = prev;

                prev = current;
                current = next;
            }

            return prev;
        }
    }
}
