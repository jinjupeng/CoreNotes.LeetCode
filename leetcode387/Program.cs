using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode387
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            var data = pro.FirstUniqChar("aabb");
            Console.WriteLine(data);
        }

        /// <summary>
        /// 387. 字符串中的第一个唯一字符
        /// 给定一个字符串 s ，找到 它的第一个不重复的字符，并返回它的索引 。如果不存在，则返回 -1 。
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int FirstUniqChar(string s)
        {
            var strArr = s.ToCharArray();
            var dict = new Dictionary<char, int>();
            var hashSet = new LinkedList<char>(); // 一定要有序
            for (int i = 0; i < strArr.Length; i++)
            {
                if (!hashSet.Contains(strArr[i]) && !dict.ContainsKey(strArr[i]))
                {
                    hashSet.AddLast(strArr[i]);
                    dict.Add(strArr[i], i);
                }
                else
                {
                    hashSet.Remove(strArr[i]);
                }
            }

            if (hashSet.Count == 0)
            {
                return -1;
            }
            else
            {
                dict.TryGetValue(hashSet.First(), out int value);
                return value;
            }
        }
    }
}
