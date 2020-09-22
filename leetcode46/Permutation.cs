using System.Collections.Generic;

namespace leetcode46
{
    public class Permutation
    {
        private readonly IList<IList<int>> _list = new List<IList<int>>();

        /// <summary>
        /// 46. 全排列
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<IList<int>> Permute(int[] nums)
        {
            PermuteDfs(nums, 0);
            return _list;
        }

        /// <summary>
        /// 深度优先搜索递归遍历
        /// </summary>
        /// <param name="array"></param>
        /// <param name="cur"></param>
        private void PermuteDfs(int[] array, int cur)
        {
            // 遍历完了一个全排列结果
            if (cur == array.Length)
            {
                _list.Add(new List<int>(array));
            }
            else
            {
                PermuteDfs(array, cur + 1);
                int i;
                for (i = cur + 1; i < array.Length; i++)
                {
                    Swap(array, cur, i);
                    PermuteDfs(array, cur + 1);
                    Swap(array, cur, i);
                }
            }
        }

        /// <summary>
        /// 交换数组下标元素值
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        private void Swap(int[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}