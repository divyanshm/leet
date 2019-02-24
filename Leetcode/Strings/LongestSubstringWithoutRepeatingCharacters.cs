using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Strings
{
    // Q3, Medium
    class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            var set = new HashSet<char>();
            var longestLength = 0;
            var currentWindowLength = 0;

            int length = s.Length;
            int windowStart = 0, windowEnd = 0;
            while (windowStart < length && windowEnd < length)
            {
                // current window does not contain this character
                if (!set.Contains(s[windowEnd]))
                {
                    set.Add(s[windowEnd]);
                    windowEnd++;

                    currentWindowLength++;
                    if (currentWindowLength > longestLength)
                    {
                        longestLength = currentWindowLength;
                    }
                }
                else
                {
                    // Whoops, encountered an element which was already in the sliding window
                    // start reducing size of sliding window
                    set.Remove(s[windowStart]);
                    windowStart++;
                    currentWindowLength--;
                }
            }

            return longestLength;
        }
    }
}
