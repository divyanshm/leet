namespace Leetcode.Trees
{
    // Problem 1038, Medium
    public class GreaterSumTreeProblem
    {
        public TreeNode BstToGst(TreeNode root)
        {
            int sum = 0;
            Traverse(root, ref sum);
            return root;
        }

        private void Traverse(TreeNode node, ref int sum)
        {
            if (node == null)
            {
                return;
            }

            Traverse(node.right, ref sum);

            sum += node.val;
            node.val = sum;

            Traverse(node.left, ref sum);
        }
    }
}
