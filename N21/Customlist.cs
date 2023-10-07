using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21
{
    public class CustomList<T>  // Generic
    {
        private readonly List<T> _items;

        public CustomList()
        {
            _items = new List<T>();
        }
        public CustomList(int capacity)
        {

        }
        public void Add(T item) 
        {
            _items.Add(item);
        }
        public void AddRange(IEnumerable<T> items) 
        {
            _items?.AddRange(items);
        }
        public bool Contains(T item) 
        {
           return _items.Contains(item);
        }
        public Array CopyTo(List<T> list )
        {
            if(list!=null)// List elementlarini arrayga copyto qilish
            {
                return list.ToArray();
            }
            return null;
        }
        public bool IndexOf(T item)
        {
            return _items?.IndexOf(item)!=-1;
        }
        public void Insert(int index, T item) 
        {
            if(_items.Equals(item))
            {
                _items.Insert(index, item);
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public bool Remove(T item) 
        {
           if( _items.Contains(item))
            _items.Remove(item);
            return false;
        }
        public bool RemoveAt(int index)
        {
            if (_items.Contains(_item[index]))
        }
        








    }
}
