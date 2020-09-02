using System;
using System.Collections.Generic;

namespace leetcode148
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            var head = new ListNode(4) {next = new ListNode(2) { next = new ListNode(1) { next = new ListNode(3) } } };
            var data = pro.SortList(head);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// [148] 排序链表
        /// 在 O(n log n) 时间复杂度和常数级空间复杂度下，对链表进行排序。
        /// O(n log n)：快速排序、归并排序
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode SortList(ListNode head)
        {
            /*
             * 归并排序版本：
             * 知识点1：归并排序的整体思想
             * 知识点2：快慢指针找到链表的中间节点
             * 知识点3：合并两个已排好序的链表为一个新的有序链表
             */
            if (head == null)
            {
                return null;
            }

            return MergeSort(head);
        }

        private ListNode MergeSort(ListNode head)
        {
            if (head.next == null)
            {
                return head;
            }
            // 找到中间节点
            var fast = head;
            var slow = head;

            // 标记节点
            ListNode sign = null;
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

                sign = slow;
                slow = slow.next;
            }

            // 断开链表
            sign.next = null;

            var left = MergeSort(head);
            var right = MergeSort(slow);

            return Merge(left, right);
        }
        private ListNode Merge(ListNode left, ListNode right)
        {
            // 临时头节点
            var resultNode = new ListNode(default);
            // 链表指针
            var cur = resultNode;
            while (left != null && right != null)
            {
                if (left.val < right.val)
                {
                    cur.next = left;
                    cur = cur.next;
                    left = left.next;
                }
                else
                {
                    cur.next = right;
                    cur = cur.next;
                    right = right.next;
                }
            }

            if (left != null)
            {
                cur.next = left;
            }

            if (right!= null)
            {
                cur.next = right;
            }
            return resultNode.next;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
