using System;

namespace leetcode12
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            var data = pro.IntToRoman(123);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 12. 整数转罗马数字
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string IntToRoman(int num)
        {
            var values = new[]{ 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            var reps = new[]{ "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            var res = "";
            for (var i = 0; i < 13; i++)
            {
                while (num >= values[i])
                {
                    num -= values[i];
                    res += reps[i];
                }
            }
            return res;
        }
    }
}
