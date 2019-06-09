namespace Leetcode.Trees
{
    // Q. 814, Medium
    public class TreePruning
    {
        public TreeNode PruneTree(TreeNode root)
        {
            if(root == null)
            {
                return null;
            }

            var checkForRoot = CheckForOnes(root);
            if(!checkForRoot)
            {
                return null;
            }
            else
            {
                return root;
            }
        }

        private bool CheckForOnes(TreeNode node)
        {
            if(node.left == null && node.right == null)
            {
                return node.val == 1;
            }

            var isOnePresentInLeftChild = node.left != null ? CheckForOnes(node.left) : false;
            var isOnePresentInRightChild = node.right != null ? CheckForOnes(node.right) : false;

            if(!isOnePresentInLeftChild)
            {
                node.left = null;
            }

            if(!isOnePresentInRightChild)
            {
                node.right = null;
            }

            return isOnePresentInLeftChild || isOnePresentInRightChild || node.val == 1;
        }
    }
}
