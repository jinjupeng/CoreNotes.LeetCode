using System;
using System.Collections.Generic;

namespace leetcode144
{
    class Program
    {
        List<int> list = new List<int>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 144. 二叉树的前序遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> PreorderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return list;
            }
            // 根->左->右
            list.Add(root.val);
            PreorderTraversal(root.left);
            PreorderTraversal(root.right);

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
