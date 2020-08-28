using System;
using System.Collections;

namespace leetcode2
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            var l1 = new ListNode(5);
            var l2 = new ListNode(5);
            var data = pro.AddTwoNumbers(l1, l2);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 2. 两数相加
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }
            if (l2 == null)
            {
                return l1;
            }

            int remainder = 0; // 余数
            var newNode = new ListNode(0);
            var currentNode = newNode;
            while (l1 != null || l2 != null)
            {
                if (l1 != null)
                {
                    if (l2 != null)
                    {
                        var sum = l1.val + l2.val + remainder;
                        if (sum >= 10)
                        {
                            currentNode.next = new ListNode(sum - 10);
                            remainder = 1;
                        }
                        else
                        {
                            currentNode.next = new ListNode(sum);
                            remainder = 0;
                        }
                        l2 = l2.next;
                        l1 = l1.next;
                    }
                    else
                    {
                        var sum = l1.val + remainder;
                        if (sum >= 10)
                        {
                            currentNode.next = new ListNode(sum - 10);
                            remainder = 1;
                        }
                        else
                        {
                            currentNode.next = new ListNode(sum);
                            remainder = 0;
                        }
                        l1 = l1.next;
                    }
                    
                }
                else // l1 == null
                {
                    // l2 != null
                    var sum = l2.val + remainder;
                    if (sum >= 10)
                    {
                        currentNode.next = new ListNode(sum - 10);
                        remainder = 1;
                    }
                    else
                    {
                        currentNode.next = new ListNode(sum);
                        remainder = 0;
                    }
                    l2 = l2.next;
                }

                currentNode = currentNode.next;
            }

            if (remainder == 1)
            {
                currentNode.next = new ListNode(1);
            }
            return newNode.next;
        }


    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
