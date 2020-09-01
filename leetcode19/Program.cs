using System;

namespace leetcode19
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var head = new ListNode(1)
            {
                next = new ListNode(2) {next = new ListNode(3) {next = new ListNode(4) {next = new ListNode(5)}}}
            };
            // var data = p.KthToLast(head, 2);
            // var data = p.GetKthFromEnd(head, 2);
            var data = p.RemoveNthFromEnd(head, 2);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 19. 删除链表的倒数第N个节点，并返回删除后的链表
        /// </summary>
        /// <param name="head"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            // 思路：快慢指针
            ListNode slow = head;
            ListNode fast = head;
            if (fast == null)
            {
                return null;
            }
            // 先让 fast 先走 n 步
            for (int i = 0; i < n; i++)
            {
                // 如果要删除的节点是头节点
                if (fast.next == null)
                {
                    return head.next;
                }
                fast = fast.next;
            }

            // 当fast走完n步之后，fast和slow同时往下走，当fast到结尾时，slow刚好指向要删除的节点
            while (fast.next != null)
            {
                slow = slow.next;
                fast = fast.next;
            }

            slow.next = slow.next.next;
            return head;
        }

        /// <summary>
        /// 面试题 02.02. 返回倒数第 k 个节点的值
        /// </summary>
        /// <param name="head"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int KthToLast(ListNode head, int k)
        {
            // 思路：快慢指针
            ListNode slow = head;
            ListNode fast = head;
            if (fast == null)
            {
                throw new Exception("节点为null");
            }
            // 先让 fast 先走 k-1 步
            for (int i = 0; i < k - 1; i++)
            {
                if (fast.next == null)
                {
                    // 说明输入的 k 已经超过了链表长度，直接报错
                    throw new Exception("k值超过了链表长度");
                }
                fast = fast.next;

            }
            // 当fast走完k-1步之后，fast和slow同时往下走，当fast到结尾时，slow刚好指向倒数k节点
            while (fast.next != null)
            {
                slow = slow.next;
                fast = fast.next;
            }
            return slow.val;
        }

        /// <summary>
        /// 剑指 Offer 22. 链表中倒数第k个节点
        /// </summary>
        /// <param name="head"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public ListNode GetKthFromEnd(ListNode head, int k)
        {
            // 思路：快慢指针
            ListNode slow = head;
            ListNode fast = head;
            if (fast == null)
            {
                throw new Exception("节点为null");
            }
            // 先让 fast 先走 k-1 步
            for (int i = 0; i < k - 1; i++)
            {
                if (fast.next == null)
                {
                    // 说明输入的 k 已经超过了链表长度，直接报错
                    throw new Exception("k值超过了链表长度");
                }
                fast = fast.next;

            }
            // 当fast走完k-1步之后，fast和slow同时往下走，当fast到结尾时，slow刚好指向倒数k节点
            while (fast.next != null)
            {
                slow = slow.next;
                fast = fast.next;
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
