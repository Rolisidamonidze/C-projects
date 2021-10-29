using System.Collections;

namespace StackAndQueue
{
    class MyStack : IEnumerable
    {
        #region Properties

        private object[] _stack;
        private int _capacity;
        public int Count { get; private set; }

        #endregion

        #region Constructors
        public MyStack()
        {
            _capacity = 10;
            _stack = new object[_capacity];
            Count = 0;
        }

        public MyStack(ICollection col)
        {
            _capacity = col.Count;
            _stack = col as object[];
            Count = col.Count;
        }

        public MyStack(int initialCapacity)
        {
            _capacity = initialCapacity;
            _stack = new object[_capacity];
            Count = 0;
        }

        #endregion

        #region Private Methods
        private void Resize()
        {
            object[] _tempArray = _stack;
            _capacity *= 2;
            _stack = new object[_capacity];
            for (int i = 0; i < Count; i++)
            {
                _stack[i] = _tempArray[i];
            }
        }
        #endregion

        #region Public Methods
        public void Push(object item)
        {
            if (Count == _capacity)
            {
                Resize();
            }
            _stack[Count] = item;
            Count++;
        }

        public object Pop()
        {
            var _pop = Peek();
            _stack[Count - 1] = null;
            Count--;
            return _pop;
        }

        public object Peek()
        {
            return _stack[Count - 1];
        }

        public bool Contains(object obj)
        {
            for (int i = 0; i < Count; i++)
            {
                if (obj.Equals(_stack[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public object[] ToArray()
        {
            return _stack;
        }
        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(_stack, Count);
        }

        #endregion
    }
}
