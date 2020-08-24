using System;
using System.Collections.Generic;

namespace leetcode590
{
    
    class Program
    {
        List<int> list = new List<int>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 590. N叉树的后序遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> Postorder(Node root)
        {
            #region n叉树后序遍历递归版

            /*
             * 思路：
             * 1. 参考二叉树的递归遍历方式：先遍历左子树，然后递归遍历右子树，再递归遍历根节点。
             * 2. N叉树的后序遍历就是先遍历每个子树，然后依次递归遍历根节点。
             * 3. 时间复杂度O（N）,空间复杂度O（N）
             */
            if (root == null)
            {
                return list;
            }

            foreach (var child in root.children)
            {
                Postorder(child);
            }
            list.Add(root.val);

            return list;

            #endregion
        }
    }

    /// <summary>
    /// n叉树的节点定义
    /// </summary>
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
}
