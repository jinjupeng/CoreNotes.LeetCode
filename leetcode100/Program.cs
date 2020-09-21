using System;

namespace leetcode100
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new TreeNode(1) {left = new TreeNode(2)};
            var q = new TreeNode(1) {right = new TreeNode(2)};
            var tree = new Tree();
            var data = tree.IsSameTree(p, q);
            Console.WriteLine("Hello World!");
        }
    }
}
