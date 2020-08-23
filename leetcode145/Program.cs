using System;
using System.Collections.Generic;

namespace leetcode145
{
    class Program
    {
        List<int> list = new List<int>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 145. 二叉树的后序遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> PostorderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return list;
            }
            // 左->右->根
            PostorderTraversal(root.left);
            PostorderTraversal(root.right);
            list.Add(root.val);

            return list;
        }
    }

    /// <summary>
    /// 二叉树节点定义
    /// </summary>
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
