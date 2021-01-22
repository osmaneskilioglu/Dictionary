using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyList<T>
    {
        T[] _items;
        T[] _temp;
        public MyList()
        {
            _items = new T[0];
        }
        public void Add(T item)
        {
            _temp = _items; 
            _items = new T[_items.Length + 1];

            for (int i = 0; i < _temp.Length; i++)
            {
                _items[i] = _temp[i];
            }
            _items[_items.Length - 1] = item;
        }
        public int Lenght
        {
            get { return _items.Length; }
        }
        public T[] Items
        {
            get { return _items; }
        }
    }
}
