using System;
using System.Collections.Generic;

namespace leetcode589
{
    class Program
    {
        List<int> list = new List<int>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 589. N叉树的前序遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> Preorder(Node root)
        {
            #region 递归版

            /*
             * 思路：
             * 1. 参考二叉树的递归遍历方式：先遍历根节点，然后递归遍历左子树，再递归遍历右子树。
             * 2. N叉树的前序遍历就是先遍历根节点，然后依次递归遍历每个子树。
             * 3. 时间复杂度O（N）,空间复杂度O（N）
             */
            if (root == null)
            {
                return list;
            }

            list.Add(root.val);
            foreach (var child in root.children)
            {
                Preorder(child);
            }

            return list;

            #endregion

            #region 非递归版解题思路

            /*
             * 1. 二叉树的非递归遍历是每次将当前结点右孩子节点和左孩子节点依次压入栈中，注意是先右后左。
             * 2. 然后将出栈节点输出，并且在将其右子节点和左子节点压入栈中。
             * 3. 推广到N叉树，就是将当前结点的孩子节点由右到左依次压入栈中。
             * 4. 然后将出栈节点输出，并且将其孩子节点依次压入栈中。
             * 5. 时间复杂度O（N），空间复杂度O（N）
             */

            // TODO：...
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
