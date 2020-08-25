using System;

namespace leetcode125
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            // var str = "A man, a plan, a canal: Panama";
            var str = "0P";
            var data = pro.IsPalindrome(str);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 125. 验证回文串
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsPalindrome(string s)
        {
            if (s.Length == 0)
            {
                return true;
            }
            // 思路：双指针
            var charArray = s.ToCharArray();
            for (int i = 0, j = s.Length - 1; i < j;)
            {
                var tempChar = charArray[i];
                var tempChar2 = charArray[j];
                if ((tempChar >= 'a' && tempChar <= 'z') || (tempChar >= 'A' && tempChar <= 'Z') || (tempChar >= '0') && (tempChar <= '9'))
                {
                    if ((tempChar2 >= 'a' && tempChar2 <= 'z') || (tempChar2 >= 'A' && tempChar2 <= 'Z') || (tempChar2 >= '0') && (tempChar2 <= '9'))
                    {
                        if (tempChar.ToString().ToLower() == tempChar2.ToString().ToLower())
                        {
                            i++;
                            j--;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        j--;
                    }
                }
                else
                {
                    i++;
                }
            }

            return true;
        }
    }
}
