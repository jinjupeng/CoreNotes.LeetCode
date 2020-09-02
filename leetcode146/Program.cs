using System;

namespace leetcode146
{
    class Program
    {
        static void Main(string[] args)
        {
            
            LRUCache cache = new LRUCache(2); // 缓存容量
            
            cache.Put(1, 1);
            cache.Put(2, 2);
            var a = cache.Get(1);       // 返回  1
            cache.Put(3, 3);    // 该操作会使得关键字 2 作废
            var b = cache.Get(2);       // 返回 -1 (未找到)
            cache.Put(4, 4);    // 该操作会使得关键字 1 作废
            var c = cache.Get(1);       // 返回 -1 (未找到)
            var d = cache.Get(3);       // 返回  3
            var e = cache.Get(4);       // 返回  4
            

            /*
            LRUCache cache = new LRUCache(1); // 缓存容量

            cache.Put(2, 1);
            var a = cache.Get(1);       // 返回  -1
            */

            /*
            LRUCache cache = new LRUCache(1); // 缓存容量

            cache.Put(2, 1);
            var a = cache.Get(2);       // 返回  1
            */

            /*
            LRUCache cache = new LRUCache(1); // 缓存容量

            cache.Put(2, 1);
            var a = cache.Get(2);       // 返回  1
            cache.Put(3, 2);
            var b = cache.Get(2);       // 返回 -1 (未找到)
            var c = cache.Get(3);       // 返回 2 
            */

            Console.WriteLine("Hello World!");
        }
    }
}
