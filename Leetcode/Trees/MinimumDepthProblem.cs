using System;
namespace Leetcode.Trees
{
    class MinimumDepthProblem
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            if (root.left == null && root.right == null)
            {
                return 1;
            }

            var leftSubtreeDepth = root.left == null ? int.MaxValue : MinDepth(root.left);
            var rightSubtreeDepth = root.right == null ? int.MaxValue : MinDepth(root.right);

            return Math.Min(leftSubtreeDepth, rightSubtreeDepth) + 1;
        }
    }
}
