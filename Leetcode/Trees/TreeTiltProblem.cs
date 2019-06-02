using System;

namespace Leetcode.Trees
{
    class TreeTiltProblem
    {
        public int FindTilt(TreeNode root)
        {
            int totalTilt = 0;
            GetSum(ref totalTilt, root);
            return totalTilt;
        }

        private int GetSum(ref int totalTilt, TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            int leftSubtreeSum = 0;
            int rightSubtreeSum = 0;

            leftSubtreeSum = GetSum(ref totalTilt, node.left);
            rightSubtreeSum = GetSum(ref totalTilt, node.right);

            totalTilt += Math.Abs(leftSubtreeSum - rightSubtreeSum);
            return leftSubtreeSum + rightSubtreeSum + node.val;
        }
    }
}
