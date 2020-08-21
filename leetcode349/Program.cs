using System;
using System.Linq;

namespace leetcode349
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            var nums1 = new int[] { 2, 1 };
            var nums2 = new int[] { 1, 1 };
            var data = program.Intersection(nums1, nums2);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 349. 两个数组的交集
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            // 注意：必须要将nums1排序，之后才能使用二分查找
            Array.Sort(nums1);
            var array = new int[0];
            foreach (var t in nums2)
            {
                var low = 0;
                var high = nums1.Length - 1;
                int mid;

                while (low <= high)
                {
                    mid = (low + high) / 2;
                    if (nums1[mid] == t)
                    {
                        if (!array.Contains(t))
                        {
                            Array.Resize(ref array, array.Length + 1);
                            array[array.Length - 1] = t;
                        }
                    }

                    if (nums1[mid] < t)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
            }

            return array;
        }
    }
}
