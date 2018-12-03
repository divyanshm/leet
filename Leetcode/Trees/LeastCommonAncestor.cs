namespace Leetcode.Trees
{
    class LeastCommonAncestor
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
            {
                return null;
            }

            if (p == q)
            {
                return p;
            }

            TreeNode lcaNode = null;

            var doesLcaNodeExist = DoesSubtreeHaveLcaNode(root, ref lcaNode, p, q);
            if (doesLcaNodeExist)
            {
                return lcaNode;
            }
            else
            {
                return null;
            }
        }

        private bool DoesSubtreeHaveLcaNode(TreeNode node, ref TreeNode lcaNode, TreeNode p, TreeNode q)
        {
            if (node == null)
            {
                return false;
            }

            // Stop recursive evaluation if this was found already
            if (lcaNode != null)
            {
                return false;
            }

            // leaf node
            if (node.left == null && node.right == null)
            {
                return node == q || node == p;
            }

            var doesLeftSubtreeHaveANode = DoesSubtreeHaveLcaNode(node.left, ref lcaNode, p, q);
            var doesRightSubtreeHaveANode = DoesSubtreeHaveLcaNode(node.right, ref lcaNode, p, q);

            // Both Subtrees have one each
            if (doesLeftSubtreeHaveANode && doesRightSubtreeHaveANode)
            {
                lcaNode = node;
                return true;
            }

            if (doesLeftSubtreeHaveANode || doesRightSubtreeHaveANode)
            {
                if (node == q || node == p)
                {
                    lcaNode = node;
                }

                return true;
            }

            return node == q || node == p;
        }
    }
}
