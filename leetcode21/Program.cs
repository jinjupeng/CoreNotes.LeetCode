using System;

namespace leetcode21
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            var l1 = new ListNode(1, new ListNode(2, new ListNode(4, null)));
            var l2 = new ListNode(1, new ListNode(3, new ListNode(4, null)));
            pro.MergeTwoLists(l1, l2);

            Console.WriteLine("----------------------------");
        }

        /// <summary>
        /// 21. 合并两个有序链表
        /// 输入：1->2->4, 1->3->4
        /// 输出：1->1->2->3->4->4
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            // 创建一个新的结果链表,只有一个头结点
            var head = new ListNode(0);
            // 遍历过程中新链表的最后一个节点
            var currentNode = head;
            while (l1 != null && l2 != null)
            {
                if (l1.Val < l2.Val)
                {
                    currentNode.Next = l1;
                    l1 = l1.Next;
                }
                else
                {
                    currentNode.Next = l2;
                    l2 = l2.Next;
                }
                // 更新结果链表的最后一个节点
                currentNode = currentNode.Next;
            }

            // 遍历完成后，肯定有一个不为空的链表，将其直接连接到结果链表的最后
            if (l1 == null)
            {
                currentNode.Next = l2;
            }
            else
            {
                currentNode.Next = l1;
            }

            return head.Next;
        }
    }

    /// <summary>
    /// 单链表节点
    /// </summary>
    public class ListNode
    {
        public int Val;
        public ListNode Next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.Val = val;
            this.Next = next;
        }
    }
}
