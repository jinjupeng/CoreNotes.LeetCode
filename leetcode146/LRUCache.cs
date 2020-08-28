using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode146
{
    /// <summary>
    /// 146. LRU缓存机制
    /// </summary>
    public class LRUCache
    {
        /*
         * 实现LRU缓存淘汰算法思路：
         * 维护一个有序单链表，越靠近链尾的数据是最早访问的。
         * 当有一个新的数据被访问时，
         * 1. 如果数据在缓存中，则将其从原位置删除，然后插入到表头；
         * 2. 如果数据不在缓存中，有两种情况：
         *     1) 链表未满，则将数据插入到表头；
         *     2) 链表已满，则删除尾结点，将新数据插入到表头。
         */

        private readonly int _capacity;
        Dictionary<int, int> _dict = new Dictionary<int, int>();

        /// <summary>
        /// 思路：双向链表 + 字典
        /// </summary>
        /// <param name="capacity"></param>
        public LRUCache(int capacity)
        {
            _capacity = capacity;
        }

        public int Get(int key)
        {
            if (_dict.ContainsKey(key))
            {
                DoubleLinkedList.Delete(DoubleLinkedList.Find(key));
                DoubleLinkedList.AddFirst(key);

                return _dict[key];
            }

            return -1;
        }

        private MyDoubleLinkedList<int> DoubleLinkedList { get; } = new MyDoubleLinkedList<int>();
        public void Put(int key, int value)
        {
            // 数据不存在
            if (!_dict.ContainsKey(key))
            {
                // 容量已满
                if (_capacity == _dict.Count)
                {
                    var deleteValue = DoubleLinkedList.RemoveLast();
                    _dict.Remove(deleteValue);
                    DoubleLinkedList.AddFirst(key);
                }
                else
                {
                    DoubleLinkedList.AddFirst(key);
                }
                _dict.Add(key, value);
            }
            else
            {
                _dict[key] = value;
                // 将该节点从原位置移除并移动到头部插入
                DoubleLinkedList.Delete(DoubleLinkedList.Find(key));
                DoubleLinkedList.AddFirst(key);
            }
        }
    }

    /// <summary>
    /// 双链表的模拟实现
    /// </summary>
    public class MyDoubleLinkedList<T> where T : IComparable
    {
        private DbNode<T> _head; // 字段：当前链表的头结点

        // 属性：当前链表节点个数
        public int Count { get; set; }

        public T this[int index]
        {
            get => this.GetNodeByIndex(index).Item;
            set => this.GetNodeByIndex(index).Item = value;
        }

        public MyDoubleLinkedList()
        {
            this.Count = 0;
            this._head = null;
        }


        public bool CheckIndex(int index)
        {
            if (index < 0 || index >= Count)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 获取指定位置节点
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public DbNode<T> GetNodeByIndex(int index)
        {
            if (!CheckIndex(index))
            {
                return null;
            }
            DbNode<T> tempNode = _head;
            for (int i = 0; i < index; i++)
            {
                tempNode = tempNode.Next;
            }

            return tempNode;
        }

        /// <summary>
        /// 根据值查找节点
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int Find(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (GetNodeByIndex(i).Item.CompareTo(item) == 0)
                {
                    return i;
                }
            }

            return default(int);
        }

        /// <summary>
        /// 头节点之前添加数据
        /// </summary>
        /// <param name="item"></param>
        public void AddFirst(T item)
        {
            DbNode<T> tempNode;
            if (_head == null)
            {
                tempNode = new DbNode<T>(item);
                _head = tempNode;
            }
            else
            {
                var lastNode = GetNodeByIndex(Count - 1);
                tempNode = new DbNode<T>(item) { Next = _head, Prev = lastNode };
                lastNode.Next = tempNode;
                _head.Prev = tempNode;
                _head = tempNode;
            }

            Count++;
        }

        /// <summary>
        /// 尾节点之后添加数据
        /// </summary>
        /// <param name="item"></param>
        public void AddLast(T item)
        {
            DbNode<T> newNode = new DbNode<T>(item);
            if (_head == null)
            {
                // 如果链表当前为空则置为头结点
                _head = newNode;
            }
            else
            {
                DbNode<T> lastNode = GetNodeByIndex(Count - 1);
                // 调整插入节点与前驱节点指针关系
                lastNode.Next = newNode;
                newNode.Prev = lastNode;
                newNode.Next = _head;
                _head.Prev = newNode;
            }
            Count++;
        }

        /// <summary>
        /// 删除指定位置节点
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T Delete(int index)
        {
            DbNode<T> deleteNode = GetNodeByIndex(index);
            if (deleteNode.Next == null)
            {
                if (index == 0)
                {
                    return deleteNode.Item;
                }
                throw new ArgumentOutOfRangeException(nameof(index), "索引超出范围");
            }

            DbNode<T> prevNode = deleteNode.Prev;
            DbNode<T> nextNode = deleteNode.Next;
            prevNode.Next = nextNode;
            if (nextNode != null)
            {
                nextNode.Prev = prevNode;
            }

            if (index == 0)
            {
                _head = nextNode;
            }
            Count--;
            return deleteNode.Item;
        }

        /// <summary>
        /// 移除尾节点
        /// </summary>
        /// <returns></returns>
        public T RemoveLast()
        {
            return Delete(Count - 1);
        }

        /// <summary>
        /// 移除头节点
        /// </summary>
        /// <returns></returns>
        public T RemoveFirst()
        {
            return Delete(0);
        }
    }

    /// <summary>
    /// 双链表节点的定义
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DbNode<T>
    {
        public T Item { get; set; }

        /// <summary>
        /// 指向前驱节点的Prev指针域
        /// </summary>
        public DbNode<T> Prev { get; set; }

        /// <summary>
        /// 指向后继节点的Next指针域
        /// </summary>
        public DbNode<T> Next { get; set; }


        public DbNode(T item)
        {
            Item = item;
        }
    }
}