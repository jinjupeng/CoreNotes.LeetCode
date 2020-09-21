using System;
using System.Collections.Generic;

namespace leetcode101
{
    public class Tree
    {
        private readonly List<int> _list;
        public Tree()
        {
            _list = new List<int>();
        }

        /// <summary>
        /// 101. 对称二叉树
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool IsSymmetric(TreeNode root)
        {
            // 思路：递归
            if (root == null)
            {
                return true;
            }
            
            return Check(root, root);
        }

        private bool Check(TreeNode left, TreeNode right)
        {
            // 判断左树和右树是否对称
            // 判断左树的左子树和右树的右子树是否对称，判断左树的右子树和右树的左子树是否对称
            if (left == null && right == null)
            {
                return true;
            }
            if (left == null || right == null || left.val != right.val)
            {
                return false;
            }
            return Check(left.left, right.right) && Check(left.right, right.left);
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}