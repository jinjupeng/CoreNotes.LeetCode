using System;

namespace leetcode14
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            var strs = new string[] { "dalower", "fblow", "fvlight" };
            var data = pro.LongestCommonPrefix(strs);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 14. 最长公共前缀
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public string LongestCommonPrefix(string[] strs)
        {
            // 思路：以第一个字符串为最大公共前缀，从第二个字符串开始判断是否存在该前缀，不存在时将字符串从后开始缩减直到存在，然后挨个遍历字符串数组。
            if (strs.Length == 0)
            {
                return "";
            }

            var str = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(str) != 0)
                {
                    str = str.Substring(0, str.Length - 1);
                }
            }
            return str;
        }
    }
}
