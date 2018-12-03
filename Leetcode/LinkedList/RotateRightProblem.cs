using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.LinkedList
{
    // problem 61
    class RotateRightProblem
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head?.next == null)
            {
                return head;
            }

            var reversedList = ReverseList(head, out var listLength);
            var newTail = head;

            k = k % listLength;

            while (k > 0)
            {
                var nextHead = reversedList.next;
                newTail.next = reversedList;
                reversedList.next = null;

                newTail = reversedList;
                reversedList = nextHead;
                k--;
            }

            var answer = ReverseList(reversedList, out listLength);
            return answer;
        }

        private ListNode ReverseList(ListNode head, out int count)
        {
            ListNode previous = null, current = head;
            count = 0;
            while (current != null)
            {
                var next = current.next;
                current.next = previous;

                previous = current;
                current = next;
                count++;
            }

            return previous;
        }
    }
}
