using System;
using System.Globalization;

namespace leetcode28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 28. 实现 strStr()
        /// </summary>
        /// <param name="haystack"></param>
        /// <param name="needle"></param>
        /// <returns></returns>
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }

            if (haystack.Length < needle.Length)
            {
                return -1;
            }

            return haystack.IndexOf(needle);
        }
    }
}
