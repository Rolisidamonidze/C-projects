using System;
using System.Collections;
using System.Collections.Generic;

namespace G18_LinkedList
{
    class MyLinkedList<T> : IEnumerable<T>
    {
        private MyLinkedListItem<T> First;
        private MyLinkedListItem<T> Last;
        public int Count { get; private set; }

        public MyLinkedList()
        {
            Count = 0;
        }

        public MyLinkedListItem<T> AddFirst(T value)
        {
            var newItem = new MyLinkedListItem<T>(value);
            newItem.Next = First;
            First = newItem;
            if (newItem.Next != null)
            {
                newItem.Next.Previous = newItem;
            }
            else
            {
                Last = newItem;
            }
            Count++;
            return newItem;
        }

        public MyLinkedListItem<T> AddLast(T value)
        {
            var newItem = new MyLinkedListItem<T>(value);
            newItem.Previous = Last;
            if (Last != null)
            {
                Last.Next = newItem;
            }
            else
            {
                First = newItem;
            }
            Last = newItem;
            Count++;
            return newItem;
        }

        public MyLinkedListItem<T> AddAfter(MyLinkedListItem<T> item, T value)
        {
            var newItem = new MyLinkedListItem<T>(value);
            var saveElement = item.Next;
            if (item.Next != null)
            {
                item.Next.Previous = newItem;
            }
            else
            {
                Last = newItem;
            }
            newItem.Previous = item;
            item.Next = newItem;
            newItem.Next = saveElement;
            Count++;
            return newItem;
        }

        public void AddBefore(MyLinkedListItem<T> item, T value)
        {
            var newItem = new MyLinkedListItem<T>(value);
            var saveElement = item.Previous;
            if (item.Previous != null)
            {
                item.Previous = newItem;
                newItem.Previous = saveElement;
                newItem.Previous.Next = newItem;
            }
            else
            {
                First = newItem;
            }
            newItem.Next = item;
            item.Previous = newItem;
            Count++;
        }

        public void RemoveFirst()
        {
            if (First != null)
            {
                if (First.Next != null)
                {
                    First = First.Next;
                    First.Previous = null;
                }
                else
                {
                    First = null;
                    Last = null;
                }
                Count--;
            }
            else
            {
                throw new Exception("No element in MyLinkedList");
            }
        }

        public void RemoveLast()
        {
            if (Last != null)
            {
                if (Last.Previous != null)
                {
                    Last = Last.Previous;
                    Last.Next = null;
                }
                else
                {
                    Last = null;
                    First = null;
                }
                Count--;
            }
            else
            {
                throw new Exception("No element in MyLinkedList");
            }
        }

        public bool Remove(T value)
        {
            var _item = Find(value);
            if (_item != null)
            {
                Remove(_item);
                Count--;
                return true;
            }
            return false;
        }

        public void Remove(MyLinkedListItem<T> item)
        {
            if (item.Equals(First))
            {
                RemoveFirst();
            }
            else if (item.Equals(Last))
            {
                RemoveLast();
            }
            else
            {
                item.Previous.Next = item.Next;
                item.Next.Previous = item.Previous;
            }
            Count--;
        }

        public bool Contains(T value)
        {
            var _current = First;
            while (_current != null)
            {
                if (_current.Value.Equals(value))
                {
                    return true;
                }
                _current = _current.Next;
            }
            return false;
        }

        public MyLinkedListItem<T> Find(T value)
        {
            var _current = First;
            while (_current != null)
            {
                if (_current.Value.Equals(value))
                {
                    return _current;
                }
                _current = _current.Next;
            }
            return _current;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new MyEnumerator<T>(First);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new MyEnumerator<T>(First);
        }
    }

    class MyLinkedListItem<T>
    {
        public MyLinkedListItem()
        {

        }

        public MyLinkedListItem(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
        public MyLinkedListItem<T> Next { get; set; }
        public MyLinkedListItem<T> Previous { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
