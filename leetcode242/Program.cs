using System;
using System.Collections;

namespace leetcode242
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            var s = "rat";
            var t = "car";
            var data = pro.IsAnagram(s, t);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 242. 有效的字母异位词
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool IsAnagram(string s, string t)
        {
            // 思路：字母异位词，也就是两个字符串中的相同字符的数量要对应相等。
            if (s.Length != t.Length)
            {
                return false;
            }
            Hashtable hashS = new Hashtable(26);
            Hashtable hashT = new Hashtable(26);
            var charS = s.ToCharArray();
            var charT = t.ToCharArray();
            foreach (var ch in charS)
            {
                if (hashS.ContainsKey(ch))
                {
                    int i = (int)hashS[ch];
                    hashS.Remove(ch);
                    hashS.Add(ch, ++i);
                }
                else
                {
                    hashS.Add(ch, 1);
                }
            }
            foreach (var ch in charT)
            {
                if (hashT.ContainsKey(ch))
                {
                    int i = (int)hashT[ch];
                    hashT.Remove(ch);
                    hashT.Add(ch, ++i);
                }
                else
                {
                    hashT.Add(ch, 1);
                }
            }

            foreach (char key in hashS.Keys)
            {
                if (hashT.ContainsKey(key))
                {
                    int a = (int)hashS[key];
                    int b = (int)hashT[key];
                    if (a != b)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }

            return true;
        }
    }
}
