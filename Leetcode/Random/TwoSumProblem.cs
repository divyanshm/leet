using System;
using System.Collections.Generic;

namespace Leetcode.Random
{
    // Easy. Q1.
    class TwoSumProblem
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var answer = new int[2];
            bool isAnswerFound = false;

            var lookup = new Dictionary<int, int>();
            for (int i=0; i<nums.Length; i++)
            {
                var diff = target - nums[i];
                if (lookup.ContainsKey(diff))
                {
                    isAnswerFound = true;
                    answer[0] = lookup[diff];
                    answer[1] = i;
                    break;
                }

                if (!lookup.ContainsKey(nums[i]))
                {
                    lookup.Add(nums[i], i);
                }
            }

            if (isAnswerFound)
            {
                return answer;
            }
            else
            {
                return null;
            }
        }
    }
}
