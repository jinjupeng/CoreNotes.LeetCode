using System;
using System.Collections.Generic;

namespace leetcode94
{
    class Program
    {
        List<int> list = new List<int>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 94. 二叉树的中序遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> InorderTraversal(TreeNode root)
        {
            #region 1. 递归方法
            // 左->根->右
            
            if (root == null)
            {
                return list;
            }

            InorderTraversal(root.left);
            list.Add(root.val);
            InorderTraversal(root.right);


            return list;

            #endregion

            #region 2. 非递归（使用栈）



            #endregion
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
