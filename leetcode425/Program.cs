using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode425
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            var num1 = "408";
            var num2 = "5";
            var data = pro.AddStrings(num1, num2);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 415. 字符串相加
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public string AddStrings(string num1, string num2)
        {
            if (num1.Length == 0 || num2.Length == 0)
            {
                return num1 + num2;
            }

            var num1Array = num1.ToCharArray().Reverse().ToArray();
            var num2Array = num2.ToCharArray().Reverse().ToArray();
            // 最长的
            var length = num1.Length > num2.Length ? num1.Length : num2.Length;
            var shortLength = num1.Length > num2.Length ? num2.Length : num1.Length;
            var remainNum = 0; // 余数
            var strStack = new Stack<string>();
            var str = "";
            for (int i = 0; i < length; i++)
            {
                int sum;
                if (i >= shortLength)
                {
                    if (shortLength == num1.Length)
                    {
                        sum = int.Parse(num2Array[i].ToString()) + remainNum;
                        remainNum = 0;
                    }
                    else
                    {
                        sum = int.Parse(num1Array[i].ToString()) + remainNum;
                        remainNum = 0;
                    }
                    
                }
                else
                {
                    sum = int.Parse(num1Array[i].ToString()) + int.Parse(num2Array[i].ToString()) + remainNum;
                    remainNum = 0;
                }

                if (sum >= 10)
                {
                    remainNum = 1;
                    strStack.Push((sum - 10).ToString());
                }
                else
                {
                    strStack.Push(sum.ToString());
                }
            }

            if (remainNum > 0)
            {
                strStack.Push(remainNum.ToString());
            }

            foreach (var s in strStack)
            {
                str += s;
            }
            return str;
        }
    }
}
