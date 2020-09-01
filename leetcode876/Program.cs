using System;

namespace leetcode876
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var head = new ListNode(1)
            {
                next = new ListNode(2) { next = new ListNode(3) { next = new ListNode(4) { next = new ListNode(5)  } } }
            };
            var data = p.MiddleNode(head);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 876. 链表的中间结点
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode MiddleNode(ListNode head)
        {
            // 快慢指针
            ListNode fast = head;
            ListNode slow = head;

            if (head == null)
            {
                return null;
            }
            while (fast.next != null)
            {
                if (fast.next.next != null)
                {
                    fast = fast.next.next;
                }
                else
                {
                    fast = fast.next;
                }
                
                slow = slow.next;
            }

            return slow;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
