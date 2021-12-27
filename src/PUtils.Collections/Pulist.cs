using System.Collections.Generic;
using System.Collections;
using System;

namespace PUtils.Collections
{
    public class pulist : IEnumerable<SpecialObject>, IList<SpecialObject>
    {
        private static SpecialObject[] _val;
        private int _size;
        private bool _readonly;
        private static readonly SpecialObject[] _emptyArray = new SpecialObject[0];
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
        public SpecialObject this[int index]
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
        public void Add(SpecialObject val)
        {
            if (_size == 0)
            {
                _size++;
                _val = new SpecialObject[1] {val};
                return;
            }
            SpecialObject[] result = new SpecialObject[_size + 1];
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
        public bool Contains(SpecialObject item)
        {
            foreach (SpecialObject s in _val)
            {
                if (s.ToObject() == item.ToObject())
                {
                    return true;
                }
            }
            return false;
        }
        public void CopyTo(SpecialObject[] array, int arrayIndex)
        {
            SpecialObject[] result = new SpecialObject[array.Length + _val.Length];
            for (int x = 0; x < array.Length; x++)
            {
                result[x] = array[x];
            }
            for (int x = 0; x < _val.Length; x++)
            {
                result[x + array.Length] = _val[x];
            }
        }
        public IEnumerator<SpecialObject> GetEnumerator()
        {
            foreach (SpecialObject s in _val)
            {
                yield return s;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public int IndexOf(SpecialObject item)
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
        public void Insert(int index, SpecialObject item)
        {
            _val[index] = item;
        }
        public bool Remove(SpecialObject item)
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
            SpecialObject[] result = new SpecialObject[_size];
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