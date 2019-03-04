using System;
using System.Collections.Generic;

namespace Leetcode.Random
{
    // Q. 735, Medium
    class PartitionLabelsProblem
    {
        public IList<int> PartitionLabels(string S)
        {
            var result = new List<int>();

            for(int i = 0; i< S.Length; i++)
            {
                int repeatPosition = -1;
                var startIndex = i;
                var currentRun = new Dictionary<char, int>();
                currentRun.Add(S[i], i);

                for (int j = startIndex+1;j < S.Length; j++)
                {
                    // First character repeats, window is identified
                    if(S[j] == S[startIndex])
                    {
                        repeatPosition = j;
                    }
                    else if (currentRun.ContainsKey(S[j]))
                    {
                        // An item from the window repeats, expand the window
                        if (currentRun[S[j]] <= repeatPosition)
                        {
                            repeatPosition = j;
                        }

                        currentRun[S[j]] = j;
                    }
                    else
                    {
                        currentRun.Add(S[j], j);
                    }
                }

                if (repeatPosition > -1)
                {
                    result.Add(repeatPosition - startIndex + 1);
                    i = repeatPosition;
                }
                else
                {
                    result.Add(1);
                }
            }

            return result.ToArray();
        }
    }
}
