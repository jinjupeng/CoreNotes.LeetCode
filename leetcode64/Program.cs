using System;

namespace leetcode64
{
    class Program
    {
        private int[][] cache;
        static void Main(string[] args)
        {
            var pro = new Program();
            var grid = new int[][]
            {
                new[] {1, 3, 1},
                new[] {1, 5, 1},
                new[] {4, 2, 1}
            };
            var data = pro.MinPathSum(grid);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 64. 最小路径和
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public int MinPathSum(int[][] grid)
        {
            // 思路：dfs（递归）+ 备忘录
            var m = grid.Length; 
            if (m <= 0) return 0;
            var n = grid[0].Length;
            cache = new int[m][];
            // 初始化交叉数组
            for (var i = 0; i < m; i++)
            {
                cache[i] = new int[n];
                for (var j = 0; j < n; j++)
                {
                    // 初始化每个都为-1，因为权重可能为0
                    cache[i][j] = -1;
                }
            }
            return dfs(grid, m - 1, n - 1);
        }

        private int dfs(int[][] grid, int m, int n)
        {
            if (m < 0 || n < 0) return int.MaxValue;
            if (m == 0 && n == 0) return grid[m][n];
            return Min(GetOrUpdate(grid, m - 1, n), GetOrUpdate(grid, m, n - 1)) + grid[m][n];
        }
        private int Min(int m, int n)
        {
            return m < n ? m : n;
        }
        private int GetOrUpdate(int[][] grid, int m, int n)
        {
            if (m < 0 || n < 0) return int.MaxValue;
            if (m == 0 && n == 0) return grid[m][n];
            if (cache[m][n] >= 0) return cache[m][n];
            return cache[m][n] = dfs(grid, m, n);
        }
    }
}
