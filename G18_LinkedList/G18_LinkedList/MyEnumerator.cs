using System;
using System.Collections;
using System.Collections.Generic;

namespace G18_LinkedList
{
    class MyEnumerator<T> : IEnumerator<T>, IEnumerator
    {
        private MyLinkedListItem<T> _current;
        private MyLinkedListItem<T> _first;
        public MyEnumerator(MyLinkedListItem<T> first)
        {
            _first = first;
            Reset();
        }
        object IEnumerator.Current => _current.Value;

        T IEnumerator<T>.Current => _current.Value;
        bool skip = false;
        public bool MoveNext()
        {
            if (_current.Next != null)
            {
                if (skip)
                {
                    _current = _current.Next;
                }
                skip = true;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _current = _first;
        }

        public void Dispose()
        {
            
        }
    }
}
