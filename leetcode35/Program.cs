using System;

namespace leetcode35
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            var array = new int[] {1, 3, 5, 6};
            var data = pro.SearchInsert(array, 0);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 35 搜索插入位置
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int SearchInsert(int[] nums, int target)
        {
            // 思路：二分查找
            var low = 0;
            var high = nums.Length - 1;
            int mid;

            while (low <= high)
            {
                mid = (low + high) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }

                if (nums[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return low;
        }
    }
}
