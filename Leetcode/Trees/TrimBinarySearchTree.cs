namespace Leetcode.Trees
{
    class TrimBinarySearchTree
    {
        public TreeNode TrimBST(TreeNode root, int L, int R)
        {
            // Null
            if (root == null)
            {
                return null;
            }

            // Root is in range
            if (root.val >= L && root.val <= R)
            {
                root.left = TrimBST(root.left, L, R);
                root.right = TrimBST(root.right, L, R);
                return root;
            }

            if (root.val < L && root.right != null)
            {
                root = TrimBST(root.right, L, R);
                return root;
            }

            if (root.val > R && root.left != null)
            {
                root = TrimBST(root.left, L, R);
                return root;
            }

            return null;
        }
    }
}
