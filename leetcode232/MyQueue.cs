using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace leetcode232
{
    /// <summary>
    /// 用栈实现队列
    /// </summary>
    class MyQueue
    {
        // TODO：另一种解决思路：使用两个栈：一个输入栈，一个输出栈
        private readonly Stack<int> _stack;
        /** Initialize your data structure here. */
        public MyQueue()
        {
            _stack = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            _stack.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            var array = _stack.ToArray().Reverse().ToArray();
            var p = array[0];
            _stack.Clear();
            for (int i = 1; i < array.Length; i++)
            {
                _stack.Push(array[i]);
            }
            return p;
        }

        /** Get the front element. */
        public int Peek()
        {
            var array = _stack.ToArray().Reverse().ToArray();
            return array[0];
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return _stack.Count == 0;
        }

        /*
        push(x) -- 将一个元素放入队列的尾部。
        pop() -- 从队列首部移除元素。
        peek() -- 返回队列首部的元素。
        empty() -- 返回队列是否为空。
        */
    }
}