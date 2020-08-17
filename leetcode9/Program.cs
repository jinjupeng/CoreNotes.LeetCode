using System;
using System.Linq;
using System.Net.Security;

namespace leetcode9
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            var result = pro.IsPalindrome(121);
            Console.WriteLine("result: ");
        }

        /**
         * 回文数
         */
        public bool IsPalindrome(int x)
        {
            var result = true;
            var str = x.ToString();
            if (str.StartsWith('-'))
            {
                return false;
            }

            var reverse = str.Reverse().ToArray();
            var array = str.ToArray();
            for (int i = 0; i < str.Length; i++)
            {
                if (array[i] != reverse[i])
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}
