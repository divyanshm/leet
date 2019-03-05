using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.LinkedList;
using Leetcode.Random;
using Leetcode.Strings;
using Leetcode.Trees;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            //var node7 = new ListNode(7);
            //var node6 = new ListNode(6) {next = node7};
            //var node5 = new ListNode(5) {next = node6};
            //var node4 = new ListNode(4) { next = null };
            /*var node3 = new ListNode(3) { next = null };
            var node2 = new ListNode(2) { next = node3 };
            var node1 = new ListNode(1) { next = node2 };
            // new ReorderListProblem().ReorderList(node1);

            var node4a = new ListNode(4) { next = null };
            var node3a = new ListNode(3) { next = node4a };
            var node1a = new ListNode(1) { next = node3a };

            new MergedListsProblem().MergeTwoLists(node1, node1a);*/

            /*int[][] two = new int[8][];
            two[0] = new[] {1, 1, 0, 0, 0, 0, 0, 0};
            two[1] = new[] {1, 1, 0, 0, 0, 0, 0, 0};
            two[2] = new[] {1, 1, 0, 0, 0, 0, 1, 1};
            two[3] = new[] {1, 1, 0, 0, 0, 0, 1, 1};
            two[4] = new[] {0, 0, 0, 0, 0, 0, 1, 1};
            two[5] = new[] {0, 0, 0, 0, 0, 0, 1, 1};
            two[6] = new[] {1, 1, 1, 1, 1, 1, 0, 0};
            two[7] = new[] {1, 1, 1, 1, 1, 1, 0, 0};

            var foo = new QuadTreeProblem().Construct(two);*/

            /*var seven = new TreeNode(7, null, null);
            var four = new TreeNode(4, null, null);
            var two = new TreeNode(2, seven, four);
            var six = new TreeNode(6, null, null);
            var five = new TreeNode(5, six, two);
            var zero = new TreeNode(0, null, null);
            var eight = new TreeNode(8, null, null);
            var one = new TreeNode(1, zero, eight);
            var three = new TreeNode(3, five, one);

            var lca = new LeastCommonAncestor().LowestCommonAncestor(three, four, seven);*/

            //var isIncluded = new PermutationInStringProblem().CheckInclusion("adc", "dcda");

            /*var nums = new int[]
            {
                230, 863, 916, 585, 981, 404, 316, 785, 88, 12, 70, 435, 384, 778, 887, 755, 740, 337, 86, 92, 325, 422,
                815, 650, 920, 125, 277, 336, 221, 847, 168, 23, 677, 61, 400, 136, 874, 363, 394, 199, 863, 997, 794,
                587, 124, 321, 212, 957, 764, 173, 314, 422, 927, 783, 930, 282, 306, 506, 44, 926, 691, 568, 68, 730,
                933, 737, 531, 180, 414, 751, 28, 546, 60, 371, 493, 370, 527, 387, 43, 541, 13, 457, 328, 227, 652,
                365, 430, 803, 59, 858, 538, 427, 583, 368, 375, 173, 809, 896, 370, 789
            };

            var sol = new TwoSumProblem().TwoSum(nums.ToArray(), 9);*/

            var answer = new StoneGameProblem().StoneGame(new[] { 3, 7, 2, 3 });
        }
    }
}
