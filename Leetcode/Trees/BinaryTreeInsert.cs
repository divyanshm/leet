namespace Leetcode.Trees
{
    // Problem 701, Medium
    public class BinaryTreeInsert
    {
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if(root == null)
            {
                return new TreeNode(val);
            }

            Traverse(root, val);

            return root;
        }

        private void Traverse(TreeNode node, int val)
        {
            if (val < node.val)
            {
                if (node.left != null)
                {
                    Traverse(node.left, val);
                }
                else
                {
                    node.left = new TreeNode(val);
                }
            }
            else
            {
                if (node.right != null)
                {
                    Traverse(node.right, val);
                }
                else
                {
                    node.right = new TreeNode(val);
                }
            }
        }
    }
}
