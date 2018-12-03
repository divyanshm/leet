using System;
using System.Collections.Generic;

namespace Leetcode.Strings
{
    class PermutationInStringProblem
    {
        // Problem 567-> Permutation in Strings
        public bool CheckInclusion(string s1, string s2)
        {
            var original = new int[26];
            foreach (var ch in s1)
            {
                original[ch - 'a']++;
            }

            var slidingWindowSize = s1.Length;

            for (int i = 0; i <= s2.Length - slidingWindowSize; i++)
            {
                bool isIncluded = true;

                var substring = new int[26];
                for (int c = i; c < i + slidingWindowSize; c++)
                {
                    substring[s2[c] - 'a']++;
                }

                for (int j = 0; j < 26; j++)
                {
                    if (original[j] == 0) continue;
                    isIncluded = isIncluded & (original[j] == substring[j]);
                }

                if (isIncluded)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
