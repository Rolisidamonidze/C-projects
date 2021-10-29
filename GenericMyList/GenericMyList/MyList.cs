using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericMyList
{
    class MyList<T> : IList<T>
    {
        public MyList()
        {
            Count = 0;
            _capacity = 4;
            _items = new T[_capacity];
        }

        int _capacity;
        T[] _items;

        public int Count
        {
            get; private set;
        }

        private void Resize()
        {
            T[] temp = _items;
            _capacity *= 2;
            _items = new T[_capacity];
            for (int i = 0; i < Count; i++)
            {
                _items[i] = temp[i];
            }
        }

        public void Add(T item)
        {
            if (Count == _capacity)
            {
                Resize();
            }
            _items[Count] = item;
            Count++;
        }

        public void Clear()
        {
            Count = 0;
            _capacity = 4;
            _items = new T[_capacity];
        }

        public bool Contains(T item)
        {
            if (IndexOf(item) != -1)
            {
                return true;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            for (int i = arrayIndex; i < array.Length; i++)
            {
                Add(array[i]);
            }
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (item.Equals(_items[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            if (Count == _capacity)
            {
                Resize();
            }
            for (int i = Count; i < index; i--)
            {
                _items[i] = _items[i - 1];
            }
        }

        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if (index != -1)
            {
                RemoveAt(index);
                return true;
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < Count; i++)
            {
                _items[i] = _items[i + 1];
            }
            Count--;
        }

        public bool IsReadOnly => false;
        public T this[int index] { get => _items[index]; set => _items[index] = value; }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyEnumerator<T>(_items, Count);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
