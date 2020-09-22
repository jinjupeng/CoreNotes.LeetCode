using System;

namespace leetcode44
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex();
            var s = "acdcb";
            var p = "a*c?b";
            var data = regex.IsMatch(s, p);
            Console.WriteLine("Hello World!");
        }
    }
}
