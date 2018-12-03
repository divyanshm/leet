using System.Collections.Generic;

namespace Leetcode.LinkedList
{
    internal static class NumComponentsProblem
    {
        public static int NumComponents(ListNode head, int[] G)
        {
            if (head == null)
            {
                return 0;
            }

            if (G == null || G.Length == 0)
            {
                return 0;
            }

            var lookup = new HashSet<int>();
            foreach (var i in G)
            {
                lookup.Add(i);
            }

            bool isComponentActive = false;
            int componentCount = 0;
            ListNode currNode = head;
            while (currNode != null)
            {
                if (isComponentActive)
                {
                    if (!lookup.Contains(currNode.val))
                    {
                        isComponentActive = false;
                    }
                }
                else
                {
                    // New component starts here
                    if (lookup.Contains(currNode.val))
                    {
                        isComponentActive = true;
                        componentCount++;
                    }
                }

                currNode = currNode.next;
            }

            return componentCount;
        }
    }
}
