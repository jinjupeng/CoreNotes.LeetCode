using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode167
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            var array = new int[] { 2, 5, 4, 11, 15 };
            var data = program.TwoSum(array, 9);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 167：两数之和 II - 输入有序数组
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] numbers, int target)
        {
            /*
            // 测试用例不通过：显示超出时间限制
            var intArray = new int[2];
            for (int i = 0; i < numbers.Length; i++)
            {
                var num2 = target - numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (num2 == numbers[j])
                    {
                        intArray[0] = i + 1;
                        intArray[1] = j + 1;
                        break;
                    }
                }
            }
            return intArray;
            */

            // 另一种思路：双重指针（双重索引）【左右指针是指双指针中一个指针在数组的最左侧，而另一个在最右侧】
            // 初始化left = 0, right = numbers.Length，numbers[left] + numbers[right] > target时，right指针向左移动，减小两数之和。相反的情况时，left指针向右移动，增加两数之和。
            for (int i = 0, j = numbers.Length - 1; i < j;)
            {
                int sum = numbers[i] + numbers[j];
                if (sum == target)
                {
                    return new[] { i + 1, j + 1 };
                }

                if (sum > target)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }

            return null;
        }
    }
}
