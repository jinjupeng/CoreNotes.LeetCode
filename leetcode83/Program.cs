using System;

namespace leetcode83
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
            var data = pro.DeleteDuplicates(head);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 83. 删除排序链表中的重复元素
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            if (head.next == null)
            {
                return head;
            }
            var cur = head;
            while (cur.next != null)
            {
                if (cur.val == cur.next.val)
                {
                    cur.next = cur.next.next;
                }
                else
                {
                    cur = cur.next;
                }
            }

            return head;
        }
    }


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
