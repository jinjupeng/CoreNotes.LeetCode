using System;

namespace leetcode7
{
    public class Solution
    {
        /*
        Given a 32-bit signed integer, reverse digits of an integer.

        Example 1:

        Input: 123
        Output: 321
        Example 2:

        Input: -123
        Output: -321
        Example 3:

        Input: 120
        Output: 21
        Note:
        Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231(2的31次方),  231(2的31次方) − 1]. 
        For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.
        */
        public int Reverse(int x)
        {
            int res = 0;
            while (x != 0)
            {
                if (System.Math.Abs(res) > int.MaxValue / 10) return 0;
                res = res * 10 + x % 10;
                x /= 10;
            }
            return res;
        }
        public static void Main()
        {
            var sol = new Solution();
            int val = -123;
            Console.WriteLine(sol.Reverse(val));
        }
    }
}
