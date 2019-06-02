using System;
using System.Collections.Generic;

namespace Leetcode.LinkedList
{
    // Q.725, Medium
    internal class SpliListToPartsProblem
    {
        public ListNode[] SplitListToParts(ListNode root, int k)
        {
            if (k == 1)
            {
                return new[] {root};
            }

            var length = 0;
            var trav = root;
            while(trav != null)
            {
                length++;
                trav = trav.next;
            }

            var averageNumberOfUnitsPerPart = (int)Math.Floor((double)length / k);
            int spareUnits = 0;

            if (averageNumberOfUnitsPerPart == 0)
            {
                averageNumberOfUnitsPerPart = 1;
                spareUnits = 0;
            }
            else
            {
                spareUnits = length % k;
            }

            var outputParts = new List<ListNode>();

            ListNode current = root;
            bool startNewSection = true;
            bool spareTaken = false;
            int currentSectionSize = 0;
            ListNode sectionHead = null;

            while (current != null)
            {
                // set current system state
                currentSectionSize++;

                if (startNewSection)
                {
                    spareTaken = false;
                    sectionHead = current;
                    startNewSection = false;
                }

                if (currentSectionSize >= averageNumberOfUnitsPerPart)
                {
                    // Let us take in one more if there are spares
                    if (spareUnits > 0 && !spareTaken)
                    {
                        spareUnits--;
                        spareTaken = true;
                    }
                    else
                    {
                        // Add section to output list
                        var temp = current.next;
                        current.next = null;
                        outputParts.Add(sectionHead);
                        k--;

                        if (k == 1)
                        {
                            outputParts.Add(temp);
                            k--;
                            break;
                        }

                        // Set current to next and force next iteration
                        currentSectionSize = 0;
                        startNewSection = true;
                        current = temp;
                        continue;
                    }
                }

                current = current.next;
            }

            if (k > 0)
            {
                while (k != 0)
                {
                    outputParts.Add(null);
                    k--;
                }
            }

            return outputParts.ToArray();
        }
    }
}
