using System;
using System.Collections;

namespace G18
{
    class MyList : IList
    {
        #region Constructors
        public MyList()
        {
            Count = 0;
            Capacity = 4;
            _items = new object[Capacity];
        }
        #endregion

        #region Properties
        private object[] _items;
        public int Count { get; private set; }
        private int Capacity { get; set; }
        #endregion

        #region Private Methods

        private void Resize()
        {
            if (Count == Capacity)
            {
                object[] tempArray = _items;
                Capacity *= 2;
                _items = new object[Capacity];
                for (int i = 0; i < Count; i++)
                {
                    _items[i] = tempArray[i];
                }
            }
        }
        #endregion

        #region Public Methods
        public object GetItem(int index)
        {
            return _items[index];
        }

        public int Add(object value)
        {
            Resize();
            _items[Count] = value;
            Count++;
            return 1;
        }

        public void AddRange(object[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                Add(values[i]);
            }
        }

        public void Insert(int index, object value)
        {
            Resize();
            for (int i = Count; i > index; i--)
            {
                _items[i] = _items[i - 1];
            }
            _items[index] = value;
            Count++;
        }

        public void InsertRange(int index, params object[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                Insert(index, values[i]);
                index++;
            }
        }

        public void Remove(object value)
        {
            if (Contains(value))
            {
                RemoveAt(IndexOf(value));
            }
        }

        public void RemoveAll(object value)
        {
            while (Contains(value))
            {
                Remove(value);
            }
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < Count; i++)
            {
                _items[i] = _items[i + 1];
            }
            Count--;
        }

        public void Clear()
        {
            Capacity = 4;
            Count = 0;
            _items = new object[Capacity];
        }

        public bool Contains(object value)
        {
            return IndexOf(value) != -1;
        }

        public int IndexOf(object value)
        {
            return IndexOf(value, 0);
        }

        public int IndexOf(object value, int startIndex)
        {
            for (int i = startIndex; i < Count; i++)
            {
                if (_items[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }

        public int[] AllIndexOf(object value)
        {
            return AllIndexOf(value, 0);
        }

        public int[] AllIndexOf(object value, int startIndex)
        {
            int countValues = 0;
            for (int i = startIndex; i < Count; i++)
            {
                if (value == _items[i])
                {
                    countValues++;
                }
            }
            int[] indexes = new int[countValues];
            int j = 0;
            for (int i = 0; i < Count; i++)
            {
                if (value == _items[i])
                {
                    indexes[j] = i;
                    j++;
                }
            }
            return indexes;
        }

        //-----------------------------------------------------------------------------------\\

        public object this[int index] { get => _items[index]; set => _items[index] = value; }

        public bool IsReadOnly => throw new NotImplementedException();

        public bool IsFixedSize => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public void CopyTo(Array array, int index) { }

        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(_items, Count);
        }
        #endregion 
    }
    class MyEnumerator : IEnumerator
    {
        int _index;
        int _count;
        object[] _items;
        public MyEnumerator(object[] items, int  count)
        {
            _items = items;
            _index = -1;
            _count = count;
        }


        public object Current
        {
            get
            {
                return _items[_index];
            }
        }

        public bool MoveNext()
        {
            if(_index + 1 < _count)
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
