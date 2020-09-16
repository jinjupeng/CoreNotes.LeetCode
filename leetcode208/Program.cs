using System;

namespace leetcode208
{
    class Program
    {
        static void Main(string[] args)
        {
            TrieTest();
        }

        public static void TrieTest()
        {
            Trie trie = new Trie();
            trie.Insert("apple");
            var a = trie.Search("apple");   // 返回 true
            var b = trie.Search("app");     // 返回 false
            var c = trie.StartsWith("app"); // 返回 true
            trie.Insert("app");
            var d = trie.Search("app");     // 返回 true

        }
    }
}
