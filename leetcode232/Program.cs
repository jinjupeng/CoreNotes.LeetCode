using System;
using System.Collections;

namespace leetcode232
{
    /// <summary>
    /// 用栈实现队列
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue queue = new MyQueue();

            queue.Push(1);
            queue.Push(2);
            queue.Push(11);
            queue.Push(9);
            queue.Push(8);
            queue.Push(23);
            var a = queue.Peek();  // 返回 1
            var b = queue.Pop();   // 返回 1
            var c= queue.Empty(); // 返回 false
            var d = queue.Pop();   // 返回 1
            var e = queue.Pop();   // 返回 1
            var f = queue.Pop();   // 返回 1
            Console.WriteLine("Hello World!");
        }

    }
}
