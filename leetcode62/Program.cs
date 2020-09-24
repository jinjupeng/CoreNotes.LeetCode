using System;

namespace leetcode62
{
    class Program
    {
        private int[,] _cache;
        static void Main(string[] args)
        {
            var pro = new Program();
            var data = pro.UniquePaths(7, 3);
            Console.WriteLine("Hello World!");
        }

        /*
        /// <summary>
        /// 62. 不同路径
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int UniquePaths(int m, int n)
        {
            return dfs(m, n);
        }

        /// <summary>
        /// 深度优先遍历（递归）
        /// 超出时间限制
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private int dfs(int m, int n)
        {
            if (m < 1 || n < 1) return 0;
            if (m == 1 && n == 1) return 1;
            return dfs(m - 1, n) + dfs(m, n - 1);
        }*/

        /// <summary>
        /// 62. 不同路径
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int UniquePaths(int m, int n)
        {
            // 使用二维数组当备忘录，去除重复的计算
            _cache = new int[m,n];
            _cache[0,0] = 1;
            return dfs(m - 1, n - 1);
        }

        /// <summary>
        /// 深度优先遍历（递归）+ 备忘录
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private int dfs(int m, int n)
        {
            if (m < 0 || n < 0) return 0;
            if (m == 0 || n == 0) return 1;
            if (_cache[m,n] > 0) return _cache[m,n];
            return _cache[m,n] = dfs(m - 1, n) + dfs(m, n - 1);
        }
    }
}
