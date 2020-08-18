using System;

namespace leetcode225
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(11);
            stack.Push(9);
            stack.Push(8);
            stack.Push(23);
            var a = stack.Top();  // 返回 1
            var b = stack.Pop();   // 返回 1
            var c = stack.Empty(); // 返回 false
            var d = stack.Pop();   // 返回 1
            var e = stack.Pop();   // 返回 1
            var f = stack.Pop();   // 返回 1
            var g = stack.Top();   // 返回 1
            Console.WriteLine("Hello World!");
        }

        /*
         * 用队列实现栈
         */
    }
}
