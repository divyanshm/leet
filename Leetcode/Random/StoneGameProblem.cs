using System;
using System.Collections.Generic;

namespace Leetcode.Random
{
    // Q. 877, Medium
    class StoneGameProblem
    {
        public bool StoneGame(int[] piles)
        {
            return StoneGameInternal(piles, 0, piles.Length - 1, 0, 0, true);
        }

        public bool StoneGameInternal(int[] piles, int startIndex, int endIndex, int alexCount, int leeCount, bool isAlexPlaying)
        {
            if (piles == null || startIndex >= endIndex)
            {
                return alexCount > leeCount;
            }


            if (isAlexPlaying)
            {
                if (StoneGameInternal(piles, startIndex + 1, endIndex, alexCount + piles[startIndex], leeCount, !isAlexPlaying))
                {
                    return true;
                }
                else if (StoneGameInternal(piles, startIndex, endIndex - 1, alexCount + piles[endIndex], leeCount, !isAlexPlaying))
                {
                    return true;
                }
            }
            else
            {
                if (StoneGameInternal(piles, startIndex + 1, endIndex, alexCount, leeCount + piles[startIndex], !isAlexPlaying))
                {
                    return true;
                }

                else if (StoneGameInternal(piles, startIndex, endIndex - 1, alexCount, leeCount + piles[endIndex], !isAlexPlaying))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
