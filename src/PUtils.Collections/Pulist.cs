using System.Collections.Generic;
using System.Collections;
using System;

namespace PUtils.Collections
{
    public class pulist : IEnumerable<Special>, IList<Special>
    {
        private static Special[] _val;
        private int _size;
        private bool _readonly;
        private static readonly Special[] _emptyArray = new Special[0];
        public int Count
        {
            get
            {
                return _size;
            }
        }
        public bool IsReadOnly
        {
            get
            {
                return _readonly;
            }
        }
        public Special this[int index]
        { 
            get 
            {
                return _val[index];
            }
            set
            {
                _val[index] = value;
            }
        }
        public pulist()
        {
            _val = _emptyArray;
            _size = 0;
            _readonly = false;
        }
        public void Add(Special val)
        {
            if (_size == 0)
            {
                _size++;
                _val = new Special[1] {val};
                return;
            }
            Special[] result = new Special[_size + 1];
            for (int x = 0; x < _size; x++)
            {
                result[x] = _val[x];
            }
            _val = result;
            _val[_size] = val;
            _size++;
        }
        public void Clear()
        {
            _val = _emptyArray;
            _size = 0;
        }
        public bool Contains(Special item)
        {
            foreach (Special s in _val)
            {
                if (s.ToNative() == item.ToNative())
                {
                    return true;
                }
            }
            return false;
        }
        public void CopyTo(Special[] array, int arrayIndex)
        {
            Special[] result = new Special[array.Length + _val.Length];
            for (int x = 0; x < array.Length; x++)
            {
                result[x] = array[x];
            }
            for (int x = 0; x < _val.Length; x++)
            {
                result[x + array.Length] = _val[x];
            }
        }
        public IEnumerator<Special> GetEnumerator()
        {
            foreach (Special s in _val)
            {
                yield return s;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public int IndexOf(Special item)
        {
            for (int x = 0; x < _val.Length; x++)
            {
                if (_val[x] == item)
                {
                    return x;
                }
            }
            return 0;
        }
        public void Insert(int index, Special item)
        {
            _val[index] = item;
        }
        public bool Remove(Special item)
        {
            int removed = 0;
            for (int x = 0; x < _size; x++)
            {
                if (_val[x] == item)
                {
                    _val[x] = null;
                }
            }
            if (removed > 0)
            {
                _size -= removed;
                Reorder();
                return true;
            }
            return false;
        }
        public void RemoveAt(int index)
        {
            _val[index] = null;
            _size--;
            Reorder();
        }
        private void Reorder()
        {
            int index = 0;
            Special[] result = new Special[_size];
            for (int x = 0; x < _val.Length; x++)
            {
                if (_val[x] != null)
                {
                    result[index] = _val[x];
                    index++;
                }
            }
            _val = result;
        }
    }
}