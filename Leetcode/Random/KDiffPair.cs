using System.Collections.Generic;

namespace Leetcode.Random
{
    // Q.532, Easy
    class KDiffPair
    {
        public int FindPairs(int[] nums, int k)
        {
            if(nums == null)
            {
                return 0;
            }

            // Stupid test case
            if (k < 0)
            {
                return 0;
            }

            var encountered = new HashSet<int>();
            var registered = new HashSet<int>();

            for(int i = 0; i < nums.Length; i++)
            {
                var currentNumber = nums[i];
                if(encountered.Contains(currentNumber + k))
                {
                    if(!registered.Contains(currentNumber + currentNumber + k))
                    {
                        registered.Add(currentNumber + currentNumber + k);
                    }
                }
                else if(encountered.Contains(currentNumber - k))
                {
                    if (!registered.Contains(currentNumber + currentNumber - k))
                    {
                        registered.Add(currentNumber + currentNumber - k);
                    }
                }

                if(!encountered.Contains(currentNumber))
                {
                    encountered.Add(currentNumber);
                }
            }

            return registered.Count;
        }
    }
}
