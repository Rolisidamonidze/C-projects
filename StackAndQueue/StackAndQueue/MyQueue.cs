using System.Collections;

namespace StackAndQueue
{
    class MyQueue : IEnumerable
    {
        #region Properties
        private object[] _queue;
        private int _capacity;
        public int Count { get; private set; }

        #endregion

        #region Constructors
        public MyQueue()
        {
            _capacity = 10;
            _queue = new object[_capacity];
        }

        #endregion

        #region Private Methods

        private void Resize()
        {
            object[] _tempArray = _queue;
            _capacity *= 2;
            _queue = new object[_capacity];
            for (int i = 0; i < Count; i++)
            {
                _queue[i] = _tempArray[i];
            }
        }

        #endregion

        #region Public Methods
        public void Enqueue(object item)
        {
            if (Count == _capacity)
            {
                Resize();
            }
            _queue[Count] = item;
            Count++;
        }

        public object Dequeue()
        {
            var first = Peek();
            for (int i = 0; i < Count; i++)
            {
                _queue[i] = _queue[i + 1];
            }
            Count--;
            return first;
        }

        public object Peek()
        {
            return _queue[0];
        }

        public void Clear()
        {
            _queue = new object[_capacity];
            Count = 0;
        }

        public void TrimToSize()
        {
            object[] _tempArray = _queue;
            _capacity = Count;
            _queue = new object[_capacity];
            for (int i = 0; i < Count; i++)
            {
                _queue[i] = _tempArray[i];
            }
        }

        public bool Contains(object obj)
        {
            for (int i = 0; i < Count; i++)
            {
                if (obj.Equals(_queue[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public object[] ToArray()
        {
            return _queue;
        }

        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(_queue, Count);
        }
        #endregion
    }
}

