using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Trees
{
    class GreaterTreeProblem
    {
        public TreeNode ConvertBST(TreeNode root)
        {
            int sum = 0;
            ConvertBSTInternal(ref sum, root);
            return root;
        }

        private void ConvertBSTInternal(ref int sum, TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            ConvertBSTInternal(ref sum, node.right);
            sum = sum + node.val;
            node.val = sum;
            ConvertBSTInternal(ref sum, node.left);
        }
    }
}
