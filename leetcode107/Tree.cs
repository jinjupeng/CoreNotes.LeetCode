using System.Collections.Generic;
using System.Linq;

namespace leetcode107
{
    public class Tree
    {
        /// <summary>
        /// 107. 二叉树的层次遍历 II
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            IList<IList<int>> list = new List<IList<int>>();
            if (root == null)
            {
                return list;
            }

            var queueNodes = new Queue<TreeNode>();
            queueNodes.Enqueue(root);

            while (queueNodes.Count > 0)
            {
                var size = queueNodes.Count;
                var item = new List<int>();

                for (var i = 0; i < size; i++)
                {
                    var tempNode = queueNodes.Dequeue();
                    item.Add(tempNode.val);
                    if (tempNode.left != null)
                    {
                        queueNodes.Enqueue(tempNode.left);
                    }

                    if (tempNode.right != null)
                    {
                        queueNodes.Enqueue(tempNode.right);
                    }
                }
                if (item.Count > 0)
                {
                    list.Add(new List<int>(item));
                }
            }

            var data = list.ToArray().Reverse().ToList();
            return data;
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