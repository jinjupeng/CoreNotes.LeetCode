using System;
using System.Collections;

namespace leetcode234
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            ListNode head = null;
            /*
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(2);
            head.next.next.next = new ListNode(1);
            */
            var data = pro.IsPalindrome(head);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 234.回文链表
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool IsPalindrome(ListNode head)
        {
            // 思路：链表转数组，然后使用双指针判断
            if (head == null)
            {
                return true;
            }

            var array = new ArrayList();
            while (head != null)
            {
                array.Add(head.val);
                head = head.next;
            }

            // 双指针
            for (int i = 0, j = array.Count - 1; i < j;)
            {
                if ((int)array[i] != (int)array[j])
                {
                    return false;
                }
                i++;
                j--;
            }

            return true;
        }
    }


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
