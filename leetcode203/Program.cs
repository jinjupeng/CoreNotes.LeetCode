using System;

namespace leetcode203
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new ListNode(1, new ListNode(2, new ListNode(6, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6, null)))))));
            var pro = new Program();
            pro.RemoveElements(head, 6);
            
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 203. 移除链表元素
        /// </summary>
        /// <param name="head"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode header = new ListNode(-1, null);
            header.next = head;
            ListNode cur = header;
            while (cur.next != null)
            {
                if (cur.next.val == val)
                {
                    cur.next = cur.next.next;
                }
                else
                {
                    cur = cur.next;
                }
            }

            return header.next;
        }

    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x, ListNode node) 
        { 
            val = x;
            next = node;
        }
    }
}
