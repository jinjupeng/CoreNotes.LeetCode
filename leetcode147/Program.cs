using System;

namespace leetcode147
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            var head = new ListNode(4) { next = new ListNode(2) { next = new ListNode(1) { next = new ListNode(3) } } };
            var data = pro.InsertionSortList(head);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 147. 对链表进行插入排序
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode InsertionSortList(ListNode head)
        {
            // 思路：插入排序
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
