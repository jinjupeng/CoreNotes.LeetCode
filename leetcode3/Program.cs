using System;
using System.Collections.Generic;

namespace leetcode3
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            var str = "pwwkew";
            var data = pro.LengthOfLongestSubstring(str);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 3. 无重复字符的最长子串
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstring(string s)
        {
            // 思路：双指针、哈希表、滑动窗口
            var window = new Dictionary<char, int>(26);

            int left = 0, right = 0;
            var res = 0; // 记录结果
            while (right < s.Length)
            {
                var c = s[right];
                right++;
                // 进行窗口内数据的一系列更新
                if (!window.ContainsKey(c))
                {
                    window.Add(c, 1);
                }
                else
                {
                    window[c]++;
                }
                // 判断左侧窗口是否要收缩
                while (window[c] > 1) // 当window[c]值大于 1 时，说明窗口中存在重复字符，不符合条件，移动left缩小窗口
                {
                    var d = s[left];
                    left++;
                    if (!window.ContainsKey(d))
                    {
                        window.Add(d, 1);
                    }
                    else
                    {
                        window[d]--;
                    }
                }
                res = Math.Max(res, right - left);
            }
            return res;
        }
    }
}
