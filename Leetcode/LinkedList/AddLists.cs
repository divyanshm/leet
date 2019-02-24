namespace Leetcode.LinkedList
{
    // Q2, Medium
    class AddLists
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = null, tail = null;
            int carry = 0;

            while (true)
            {
                if (l1 == null && l2 == null && carry == 0)
                {
                    break;
                }

                var num1 = l1?.val ?? 0;
                var num2 = l2?.val ?? 0;

                var sum = num1 + num2 + carry;
                carry = sum / 10;

                if (carry == 1)
                {
                    sum = sum - 10;
                }

                if (result == null)
                {
                    result = new ListNode(sum);
                    tail = result;
                }
                else
                {
                    tail.next = new ListNode(sum);
                    tail = tail.next;
                }

                l1 = l1?.next;
                l2 = l2?.next;
            }

            return result;
        }
    }
}
