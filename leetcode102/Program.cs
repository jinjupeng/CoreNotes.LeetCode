using System;
using System.Collections.Generic;

namespace leetcode102
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            var root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);
            var data = pro.LevelOrder(root);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 102. 二叉树的层序遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            // 思路：使用队列
            var list = new List<IList<int>>();
            if (root == null)
            {
                return list;
            }
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
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
                    
                }
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
