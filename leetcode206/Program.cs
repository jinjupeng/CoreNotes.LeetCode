using System;
using System.Collections;
using System.Collections.Generic;

namespace leetcode206
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new ListNode(-1);
            head.next = new ListNode(0);
            head.next.next = new ListNode(0);
            head.next.next.next = new ListNode(0);
            head.next.next.next.next = new ListNode(0);
            head.next.next.next.next.next = new ListNode(3);
            head.next.next.next.next.next.next = new ListNode(3);
            var pro = new Program();
            var data = pro.ReverseList(head);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 206. 反转链表
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode ReverseList(ListNode head)
        {
            // 方法1：使用栈
            if (head == null || head.next == null)
            {
                return head;
            }
            var nodeStack = new Stack<int>();
            var cur = new ListNode(-1);
            // 入栈
            while (head != null)
            {
                nodeStack.Push(head.val);
                head = head.next;
            }

            foreach (var i in nodeStack)
            {
                var node = new ListNode(i);
                var temp = cur;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }

            return cur.next;

            // TODO：方法2：递归方式

            // TODO：方法3：迭代方式
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
