using System;
using System.Linq;

namespace leetcode66
{
    class Program
    {
        static void Main(string[] args)
        {
            // var param = new int[] {9, 8, 7, 6, 5, 4, 3, 2, 1, 0};
            // var param = new int[] { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 };
            // var param = new int[] { 8, 9, 9, 9 };
            // param = new int[] { 9 };
            var param = new[] { 2, 4, 9, 3, 9 };
            //var param = new[] { 1, 2, 3 };
            var pro = new Program();
            var value = pro.PlusOne(param);
            var str = "";
            foreach (var i in value)
            {
                str += i.ToString();
            }
            Console.WriteLine("value: ", str);
        }

        /// <summary>
        /// 66. 加一
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public int[] PlusOne(int[] digits)
        {
            // TODO：必须要考虑到int最大值
            /*
             // 没有考虑到int最大值问题
            var length = digits.Length;
            var value = 0;
            for (int i = 0; i < length; i++)
            {
                value += (int)(Math.Pow(10, length - i - 1) * digits[i]);
            }

            value += 1;

            var str = value.ToString();
            var array = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                int item = (int)(value / Math.Pow(10, str.Length - i - 1));
                array[i] = item;
                value -= (int) (Math.Pow(10, str.Length - i - 1) * item);
            }

            return array;
            */
            int n = digits.Length;
            for (int i = n - 1; i >= 0; i--)
            {
                if (digits[i] != 9)
                {
                    digits[i]++;
                    return digits;
                }
                else
                {
                    digits[i] = 0;
                }
            }
            digits = new int[n + 1];
            digits[0] = 1;
            return digits;
        }
    }
}
