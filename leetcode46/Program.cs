using System;
using System.Collections.Generic;

namespace leetcode46
{
    /// <summary>
    /// 46. 全排列
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            var nums = new int[] {1, 2, 3};
            var data = pro.Permute(nums);
            Console.WriteLine("Hello World!");
        }

        public IList<IList<int>> Permute(int[] nums)
        {
            var list = new List<IList<int>>();
            Permutation(nums, 0, list);
            return list;
        }

        private void Permutation(int[] array, int begin, IList<IList<int>> list)
        {
            // 遍历完了一个全排列结果
            if (begin == array.Length)
            {
                list.Add(new List<int>(array));
            }
            else
            {
                Permutation(array, begin + 1, list);
                int i;
                for (i = begin + 1; i < array.Length; i++)
                {
                    // 交换数组下标位置
                    var t = array[begin];
                    array[begin] = array[i];
                    array[i] = t;
                    Permutation(array, begin + 1, list);
                    // 交换数组下标位置
                    t = array[begin];
                    array[begin] = array[i];
                    array[i] = t;
                }
            }
        }
    }
}
