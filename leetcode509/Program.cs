using System;

namespace leetcode509
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            var data = pro.Fib(4);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 509. 斐波那契数
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public int Fib(int N)
        {
            if (N == 0)
            {
                return 0;
            }
            if (N == 1)
            {
                return 1;
            }
            return Fib(N - 1) + Fib(N - 2);
        }
    }
}
