namespace Leetcode.LinkedList
{
    internal class PartitionListProblem
    {
        public ListNode Partition(ListNode head, int x)
        {
            if (head?.next == null)
            {
                return head;
            }

            ListNode firstGreater = null, lastSmaller = null;
            ListNode current = head, previous = null;
            while (current != null)
            {
                if (current.val < x)
                {
                    if (firstGreater == null)
                    {
                        // do nothing, we haven't encountered any element greater than or equal to X
                    }
                    else
                    {
                        var nextNode = current.next;
                        if(lastSmaller != null)
                        { 
                            lastSmaller.next = current;
                        }
                        else
                        {
                            head = current;
                        }
                        current.next = firstGreater;
                        previous.next = nextNode;

                        lastSmaller = current;
                        current = nextNode;
                        continue;
                    }
                }
                else
                {
                    if (firstGreater == null)
                    {
                        firstGreater = current;
                        lastSmaller = previous;
                    }
                }

                previous = current;
                current = current.next;
            }

            return head;
        }
    }
}
