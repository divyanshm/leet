namespace Leetcode.LinkedList
{
    // Q. 430 , Medium
    public class FlattenDoublyLinkedList
    {
        public Node Flatten(Node head)
        {
            Node traverse = head;
            while(traverse != null)
            {
                if(traverse.child != null)
                {
                    var currentNext = traverse.next;

                    var flattenedChild = Flatten(traverse.child);
                    traverse.child = null;
                    traverse.next = flattenedChild;
                    flattenedChild.prev = traverse;

                    if (currentNext != null)
                    {
                        while (traverse.next != null)
                        {
                            traverse = traverse.next;
                        }

                        traverse.next = currentNext;
                        currentNext.prev = traverse;
                    }
                }

                traverse = traverse.next;
            }

            return head;
        }
    }
}

// Optimization: if we can return tail of the flattened child, then we would not need to traverse the nodes multiple times. This is not O(n) for now
