using System;
using System.Collections.Generic;

namespace leetcode103
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.right.right = new TreeNode(5);
            var data = pro.ZigzagLevelOrder(root);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 103. 二叉树的锯齿形层次遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            // 思路：使用队列
            var list = new List<IList<int>>();
            if (root == null)
            {
                return list;
            }
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            // 标记：用来判断左右
            var flag = false; // true：左，：右 
            while (queue.Count > 0)
            {
                var size = queue.Count;
                var level = new List<int>();
                for (int i = 0; i < size; i++)
                {
                    var outQueue = queue.Dequeue();
                    level.Add(outQueue.val);

                    if (outQueue.left != null)
                    {
                        queue.Enqueue(outQueue.left);
                    }

                    if (outQueue.right != null)
                    {
                        queue.Enqueue(outQueue.right);
                    }

                    if (flag)
                    {
                        level.Reverse();
                    }

                }

                flag = !flag;
                list.Add(level);
            }

            return list;
        }
    }

    /// <summary>
    /// 自定义树节点
    /// </summary>
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
