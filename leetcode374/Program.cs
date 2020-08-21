using System;

namespace leetcode374
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 374. 猜数字大小
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int GuessNumber(int n)
        {
            // 二分查找
            var left = 1;
            var right = n;
            int mid = 1;
            while (left <= right)
            {
                mid = left + (right - left) / 2;
                // guess() 方法由leetcode测试系统提供
                if (guess(mid) == 1)
                {
                    left = mid + 1;
                }
                else if (guess(mid) == -1)
                {
                    right = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return mid;
        }
    }
}
