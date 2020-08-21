using System;

namespace leetcode704
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            var array = new int[] { -1, 0, 3, 5, 9, 12 };
            var data = pro.Search(array, 2);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 704 二分查找
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int Search(int[] nums, int target)
        {
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

            return -1;
        }
    }
}
