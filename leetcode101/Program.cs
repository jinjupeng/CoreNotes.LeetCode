using System;

namespace leetcode101
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree();
            /*
            var root = new TreeNode(1) {left = new TreeNode(2), right = new TreeNode(2)};
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(4);
            root.right.left = new TreeNode(4);
            root.right.right = new TreeNode(3);
            */
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(2);
            root.left.left = new TreeNode(2);
            root.right.left = new TreeNode(2);
            var data = tree.IsSymmetric(root); // false
            Console.WriteLine("Hello World!");
        }
    }
}
