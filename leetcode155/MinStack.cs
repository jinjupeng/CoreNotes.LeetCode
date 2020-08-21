using System;

namespace leetcode155
{
    /// <summary>
    /// 155. 最小栈
    /// 使用数组实现栈
    /// </summary>
    public class MinStack
    {
        private int[] _array;

        // 注意：最小值应该是栈中的值，而不是0
        public MinStack()
        {
            // 初始化为空栈
            this._array = new int[0];
            this.Min = default(int);
        }

        /// <summary>
        /// 入栈
        /// </summary>
        /// <param name="x"></param>
        public void Push(int x)
        {
            Array.Resize(ref _array, _array.Length + 1);
            _array[_array.Length - 1] = x;
            if (_array.Length == 1)
            {
                Min = _array[0];
            }
            else
            {
                if (x < Min)
                {
                    Min = x;
                }
            }
        }

        /// <summary>
        /// 出栈
        /// </summary>
        public void Pop()
        {
            // 出栈时，先赋初值
            Min = _array[0];
            if (_array.Length >= 1)
            {
                var newArray = new int[_array.Length - 1];
                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = _array[i];
                    if (newArray[i] < Min)
                    {
                        Min = newArray[i];
                    }
                }

                _array = newArray;
            }
        }

        public int Top()
        {
            // 栈为null返回默认值
            if (_array.Length == 0)
            {
                return default(int);
            }

            return _array[_array.Length - 1];

        }

        public int GetMin()
        {
            // 栈为null返回默认值
            if (_array.Length == 0)
            {
                Min = default(int);
            }
            return Min;
        }

        public int Min
        {
            get;
            private set;
        }
    }
}