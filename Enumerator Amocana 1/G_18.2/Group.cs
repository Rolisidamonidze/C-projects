using System;
using System.Collections;

namespace G_18._2
{
    class Group : IEnumerable, IEnumerator
    {
        private object[] _names = { "Mari", "Madona", "Guga", "Rolandi", "Lasha", "Zura", "Shalva", "Misho" };
        private int _index;

        public IEnumerator GetEnumerator()
        {
            Reset();
            return this;
        }

        public object Current
        {
            get
            {
                return _names[_index];
            }
        }

        public bool MoveNext()
        {
            if (_index + 1 < _names.Length)
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
