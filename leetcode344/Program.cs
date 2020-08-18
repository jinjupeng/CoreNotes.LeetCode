using System;

namespace leetcode344
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            var charArray = new char[] { 'h', 'e', 'l', 'l', 'o' };
            program.ReverseString(charArray);
            Console.WriteLine("Hello World!");
        }

        /*
         * 344：反转字符串
         */
        public void ReverseString(char[] s)
        {
            /*
             * 输入：["h","e","l","l","o"]
             * 输出：["o","l","l","e","h"]
             */
            var length = s.Length;

            for (int i = 0; i < length / 2; i++)
            {
                var change = s[i];
                s[i] = s[length - 1 - i];
                s[length - 1 - i] = change;
            }
        }
    }
}
