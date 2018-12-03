using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Trees
{
    class SymmetricTreeProblem
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            return AreSymmetric(root.left, root.right);
        }

        private bool AreSymmetric(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
            {
                return true;
            }

            if (left == null || right == null)
            {
                return false;
            }

            return left.val == right.val 
                   && AreSymmetric(left.left, right.right)
                   && AreSymmetric(left.right, right.left);
        }
    }
}
