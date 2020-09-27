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
            /*
             * 需要一个指针指向当前已排序的最后一个位置，这里用的是head指针
               需要另外一个指针pre,每次从表头循环，这里用的是dummy表头指针。
               每次拿出未排序的节点，先和前驱比较，如果大于或者等于前驱，就不用排序了，直接进入下一次循环
               如果前驱小，则进入内层循环，依次和pre指针比较，插入对应位置即可。
             */
            var dummy = new ListNode(-1) {next = head};

            while (head != null && head.next != null)
            {
                if (head.val <= head.next.val)
                {
                    head = head.next;
                    continue;
                }
                var pre = dummy;

                while (pre.next.val < head.next.val)
                {
                    pre = pre.next;
                }

                var cur = head.next;
                head.next = cur.next;
                cur.next = pre.next;
                pre.next = cur;
            }
            return dummy.next;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
