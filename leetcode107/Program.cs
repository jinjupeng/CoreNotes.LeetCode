using System;

namespace leetcode107
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Tree();

            var root = new TreeNode(3)
            {
                left = new TreeNode(9), right = new TreeNode(20) {left = new TreeNode(15), right = new TreeNode(7)}
            };
            /*
            var root = new TreeNode(1) {left = new TreeNode(2), right = new TreeNode(3)};
            root.left.left = new TreeNode(4);
            root.right.right = new TreeNode(5);
            */
            pro.LevelOrderBottom(root);
            Console.WriteLine("Hello World!");
        }
    }
}
