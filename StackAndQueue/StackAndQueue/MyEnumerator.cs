using System;
using System.Collections;


namespace StackAndQueue
{
    class MyEnumerator : IEnumerator
    {
        private int _count;
        private object[] _items;
        private int _index;

        public MyEnumerator(object[] items)
        {
            Reset();
            _items = items;
            _count = items.Length;
        }

        public MyEnumerator(object[] items, int count)
        {
            Reset();
            _items = items;
            _count = count;
        }
        public object Current => _items[_index];

        public bool MoveNext()
        {
            if (_index + 1 < _count)
            {
                _index++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}
