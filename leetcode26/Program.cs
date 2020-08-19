using System;

namespace leetcode26
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            var array = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var data = program.RemoveDuplicates(array);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 26. 删除排序数组中的重复项
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int RemoveDuplicates(int[] nums)
        {

            if (nums.Length == 0)
            {
                return 0;
            }

            var a = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[a])
                {
                    a++;
                    nums[a] = nums[i];
                    
                }
            }

            return a + 1;
        }
    }
}
