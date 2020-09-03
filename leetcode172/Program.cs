using System;
using System.Linq;

namespace leetcode172
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            var data = pro.TrailingZeroes(5);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 172. 阶乘后的零
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int TrailingZeroes(int n)
        {
            if (n < 5)
            {
                return 0;
            }
            else
            {
                return n / 5 + TrailingZeroes(n / 5);
            }
        }

    }
}
