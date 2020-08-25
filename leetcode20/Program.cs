using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode20
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            // var str = "()[]{}";
            // var str = "{[]}";
            // var str = "([)]";
            var str = "(";
            var data = pro.IsValid(str);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 20. 有效的括号
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsValid(string s)
        {
            if (s.Length == 0)
            {
                return true;
            }
            // 思路：使用栈

            var dict = new Dictionary<char, char> { {'(', ')'}, {'[', ']'}, {'{', '}'} };
            var charArray = s.ToCharArray();

            var stack = new Stack<char>();
            if (charArray[0] == '(' || charArray[0] == '{' || charArray[0] == '[')
            {
                stack.Push(charArray[0]);
                for (int i = 1; i < charArray.Length; i++)
                {
                    if (stack.Count > 0)
                    {
                        var outStack = stack.Peek();
                        if (dict[outStack] == charArray[i])
                        {
                            stack.Pop();
                        }
                        else
                        {
                            // 入栈之前必须判断是否是(、[、{
                            if (dict.Keys.Contains(charArray[i]))
                            {
                                stack.Push(charArray[i]);
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    else
                    {
                        // 入栈之前必须判断是否是(、[、{
                        if (dict.Keys.Contains(charArray[i]))
                        {
                            stack.Push(charArray[i]);
                        }
                        else
                        {
                            return false;
                        }
                    }
                }

                if (stack.Count == 0)
                {
                    return true;
                }

                return false;
            }

            return false;
        }
    }
}
