using System;
using System.Collections.Generic;

namespace leetcode15
{
    public class Solution
    {
        /*
        Given an array nums of n integers, are there elements a, b, c in nums such that a + b + c = 0? Find all unique triplets in the array which gives the sum of zero.

        Note:

        The solution set must not contain duplicate triplets.

        Example:

        Given array nums = [-1, 0, 1, 2, -1, -4],

        A solution set is:
        [
          [-1, 0, 1],
          [-1, -1, 2]
        ]
        */
        /// <summary>
        /// 注意IList和List的区别？在这里使用IList是为了节省空间
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            /*
            IList ilist = new List();
            List list = new List();
            这两行代码，从操作上来看，实际上都是创建了一个List对象的实例，也就是说，他们的操作没有区别。
            只是用于保存这个操作的返回值变量类型不一样而已。
            那么，我们可以这么理解，这两行代码的目的不一样。
            List list = new List();
            是想创建一个List，而且需要使用到List的功能，进行相关操作。
            而IList ilist = new List();
            只是想创建一个基于接口IList的对象的实例，只是这个接口是由List实现的。所以它只是希望使用到IList接口规定的功能而已，由于规定的功能较少，所以比较节省空间。 

            注意：IList ilist = new IList(); // 报错，因为IList()是抽象的，无法实例化
            */
            IList<IList<int>> result = new List<IList<int>>();
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] <= 0 && (i == 0 || (i > 0 && nums[i] != nums[i - 1])))
                {
                    int secondIdx = i + 1;
                    int thirdIdx = nums.Length - 1;
                    int searchSum = 0 - nums[i];
                    while (secondIdx < thirdIdx)
                    {
                        if (nums[secondIdx] + nums[thirdIdx] == searchSum)
                        {
                            result.Add(new List<int> { nums[i], nums[secondIdx], nums[thirdIdx] });
                            while (secondIdx < thirdIdx && nums[secondIdx] == nums[secondIdx + 1]) secondIdx++;
                            while (secondIdx < thirdIdx && nums[thirdIdx] == nums[thirdIdx - 1]) thirdIdx--;
                            secondIdx++;
                            thirdIdx--;
                        }
                        else if (nums[secondIdx] + nums[thirdIdx] < searchSum)
                        {
                            secondIdx++;
                        }
                        else
                        {
                            thirdIdx--;
                        }
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            var sol = new Solution();
            int[] input = { -1, 0, 1, 2, -1, -4 };
            Console.WriteLine(sol.ThreeSum(input));
        }
    }
}
