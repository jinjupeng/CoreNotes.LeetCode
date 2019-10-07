using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode1
{
    /*
    Given an array of integers, return indices of the two numbers such that they add up to a specific target.
    You may assume that each input would have exactly one solution, and you may not use the same element twice.

    Example:

    Given nums = [2, 7, 11, 15], target = 9,

    Because nums[0] + nums[1] = 2 + 7 = 9,
    return [0, 1].
    */
    public class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Count(); i++)
            {
                var pass = target - nums[i];
                if (dict.ContainsKey(pass))
                {
                    return new[] { dict[pass], i };
                }
                dict[nums[i]] = i;
            }
            throw new ArgumentException("error");
        }

        static void Main(string[] args)
        {
            int[] nums = new[] { 3, 3, 6 };
            int target = 6;
            int[] result = TwoSum(nums, target);
            Console.WriteLine(result);
        }
    }
}
