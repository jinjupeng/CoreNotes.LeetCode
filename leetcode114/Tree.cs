using System;

namespace leetcode114
{
    public class Tree
    {
        /// <summary>
        /// TODO：114. 二叉树展开为链表
        /// </summary>
        /// <param name="root"></param>
        public void Flatten(TreeNode root)
        {
            // 思路：前序遍历，并且将左子树置null
            
        }

        /// <summary>
        /// 前序遍历
        /// </summary>
        /// <param name="node"></param>
        public void PreOrder(TreeNode node)
        {
            if (node != null)
            {
                // 根->左->右
                Console.Write(node.val + " ");
                PreOrder(node.left);
                PreOrder(node.right);
            }
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}