using System;

namespace leetcode155
{
    class Program
    {
        static void Main(string[] args)
        {
            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            var getMin = minStack.GetMin();  
            minStack.Pop();
            var c = minStack.Top();
            var getMin2 = minStack.GetMin();

            Console.WriteLine("Hello World!");
        }
    }
}
