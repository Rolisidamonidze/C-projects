using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericMyList
{
    class MyEnumerator<T> : IEnumerator<T>, IEnumerator
    {
        public MyEnumerator(T[] items, int count)
        {
            Reset();
            _count = count;
            _items = items;
        }

        private int _index;
        private int _count;
        private T[] _items;
        public T Current => _items[_index];

        object IEnumerator.Current => _items[_index];

        public void Dispose()
        {

        }

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
