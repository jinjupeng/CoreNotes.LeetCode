using System.Collections.Generic;

namespace leetcode47
{
    public class Permute
    {
        private readonly IList<IList<int>> _list = new List<IList<int>>();
        /// <summary>
        /// 47. 全排列 II
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            PermuteDfs(nums, 0);
            return _list;
        }

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
                    // 全排列搜索前，先判断是否交换过
                    if (CanSwap(array, cur, i))
                    {
                        Swap(array, cur, i);
                        PermuteDfs(array, cur + 1);
                        Swap(array, cur, i);
                    }
                }
            }
        }

        private bool CanSwap(int[] nums, int begin, int end)
        {
            for (var i = begin; i < end; i++)
            {
                if (nums[i] == nums[end])
                {
                    return false;
                }
            }

            return true;
        }

        private void Swap(int[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}