using System.Collections.Generic;

namespace Leetcode.LinkedList
{
    internal class ReorderListProblem
    {
        public void ReorderList(ListNode head)
        {
            if (head?.next?.next == null)
            {
                return;
            }

            Stack<ListNode> nodeStack = new Stack<ListNode>();
            ListNode trav = head;
            while (trav != null)
            {
                nodeStack.Push(trav);
                trav = trav.next;
            }

            ListNode current = head;
            while (current.next != null)
            {
                ListNode nextNode = current.next;
                var lastnode = nodeStack.Pop();
                if (nextNode == lastnode)
                {
                    break;
                }

                var secondLastNode = nodeStack.Peek();
                if (secondLastNode != null)
                {
                    secondLastNode.next = null;
                }

                current.next = lastnode;
                lastnode.next = nextNode;

                current = nextNode;
            }
        }
    }
}
