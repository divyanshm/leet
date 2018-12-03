using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.LinkedList;
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
            var node3 = new ListNode(3) { next = null };
            var node2 = new ListNode(2) { next = node3 };
            var node1 = new ListNode(1) { next = node2 };
            // new ReorderListProblem().ReorderList(node1);

            var node4a = new ListNode(4) { next = null };
            var node3a = new ListNode(3) { next = node4a };
            var node1a = new ListNode(1) { next = node3a };

            new MergedListsProblem().MergeTwoLists(node1, node1a);

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
        }
    }
}
