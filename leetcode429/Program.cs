using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode429
{
    class Program
    {

        static void Main(string[] args)
        {
            var pro = new Program();
            var listNode = new List<Node>();
            var listNode2 = new List<Node>();
            listNode2.Add(new Node(5));
            listNode2.Add(new Node(6));

            listNode.Add(new Node(3, listNode2));
            listNode.Add(new Node(2));
            listNode.Add(new Node(4));
            var node = new Node(1, listNode);
            var data = pro.LevelOrder(node);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 429. N叉树的层序遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<IList<int>> LevelOrder(Node root)
        {
            /*
             * 思路：广度优先遍历（队列）
             */
            var list = new List<IList<int>>();

            if (root == null)
            {
                return list;
            }

            Queue<Node> queueNodes = new Queue<Node>();
            queueNodes.Enqueue(root);

            // 利用队列先进先出的特性存储节点并输出
            while (queueNodes.Count > 0)
            {
                var size = queueNodes.Count;
                var data = new List<int>();

                for (int i = 0; i < size; i++)
                {
                    var tempNode = queueNodes.Dequeue();
                    data.Add(tempNode.val);
                    if (tempNode.children != null && tempNode.children.Any())
                    {
                        foreach (var child in tempNode.children)
                        {
                            queueNodes.Enqueue(child);
                        }
                    }
                }
                list.Add(data);
            }
            return list;
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
