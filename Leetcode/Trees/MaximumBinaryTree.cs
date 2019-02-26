using System;
namespace Leetcode.Trees
{
    class MaximumBinaryTree
    {
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            if(nums == null)
            {
                return null;
            }

            var tree = ConstructTree(nums, 0, nums.Length);
            return tree;
        }

        private TreeNode ConstructTree(int[] nums, int left, int right)
        {
            if (left >= right)
            {
                return null;
            }

            var maxElementIndex = GetMaxElementIndex(nums, left, right);
            var rootNode = new TreeNode(nums[maxElementIndex]);

            rootNode.left = ConstructTree(nums, left, maxElementIndex - 1);
            rootNode.right = ConstructTree(nums, maxElementIndex + 1, right);

            return rootNode;
        }

        private int GetMaxElementIndex(int[] nums, int left, int right)
        {
            var elementIndex = -1;
            var maxelement = int.MinValue;
            for (int i = left; i < right; i++)
            {
                if(nums[i] > maxelement)
                {
                    maxelement = nums[i];
                    elementIndex = i;
                }
            }

            return elementIndex;
        }
    }
}
