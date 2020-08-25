using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode13
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            var str = "V";
            var data = pro.RomanToInt(str);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 13. 罗马数字转整数
        /// </summary>
        /// <param name='s'></param>
        /// <returns></returns>
        public int RomanToInt(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }
            var dict = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };
            var dict2 = new Dictionary<string, int>
            {
                {"IV", 4},
                {"IX", 9},
                {"XL", 40},
                {"XC", 90},
                {"CD", 400},
                {"CM", 900}
            };
            var sum = 0;
            var charArray = s.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if ((charArray[i] == 'I' || charArray[i] == 'X' || charArray[i] == 'C') && i < charArray.Length - 1)
                {
                    var str = charArray[i] + charArray[i + 1].ToString();
                    if (dict2.Keys.Contains(str))
                    {
                        sum += dict2[str];
                        i += 1;
                    }
                    else
                    {
                        sum += dict[charArray[i]];
                    }
                }
                else
                {
                    sum += dict[charArray[i]];
                }
                
            }

            return sum;
        }
    }
}
