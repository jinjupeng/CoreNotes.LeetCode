using System;

namespace leetcode44
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex();
            // 该实例出现超出时间限制错误
            var s = "aaabbbaabaaaaababaabaaabbabbbbbbbbaabababbabbbaaaaba";
            var p = "a*******b";
            var data = regex.IsMatch(s, p);
            Console.WriteLine("Hello World!");
        }
    }
}
