using System;

namespace leetcode88
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new  Program();
            var nums1 = new int[] {1, 2, 3, 0, 0, 0 };
            var nums2 = new int[] {2, 5, 6};
            program.Merge(nums1, 3, nums2, 3);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 88. 合并两个有序数组
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param>
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            // 合并后最后一个数的索引为m+n-1
            int i = m - 1; int j = n - 1; int k = m + n - 1;
            while (i >= 0 && j >= 0)
            {
                // 将两个数组中从最后一位开始比较，较大的先插入
                // 当j先等于0时，说明nums2的数字已经全部复制到nums1中，此时合并完成(说明nums1中最小的元素比nums2小)
                // 当i先等于0时，说明nums1中原来的所有数字已经复制完毕，此时进入下面的循环(说明nums1中最小的元素比nums2大)
                nums1[k--] = nums1[i] > nums2[j] ? nums1[i--] : nums2[j--];
            }
            while (j >= 0)
            {
                nums1[k--] = nums2[j--];
            }
        }
    }
}
