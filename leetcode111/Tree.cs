using System;

namespace leetcode111
{
    public class Tree
    {

        /// <summary>
        /// 111. 二叉树的最小深度
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MinDepth(TreeNode root)
        {
            /*
             * 最小深度定义为到最近叶子节点的深度,当左右子树都为空时，最小深度才为1，否则最小深度为2
             */
            if (root == null)
            {
                return 0;
            }
            // 思路：深度优先遍历搜索(就是递归)
            var leftDepth = MinDepth(root.left);
            var rightDepth = MinDepth(root.right);

            return leftDepth == 0 || rightDepth == 0 ? 1 + leftDepth + rightDepth : 1 + Math.Min(leftDepth, rightDepth);
        }
    }

    /// <summary>
    /// 树节点
    /// </summary>
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}