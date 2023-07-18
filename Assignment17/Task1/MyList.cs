using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task1
{
    public class MyList<T> 
    {
        //private T[] list;
        private List<T> _list;

        public MyList()
        {
            //list = new T[0];
            _list = new List<T>();
        }

        public T this[int index]
        {
            get {
                if (index < 0 || index >= _list.Count)
                {
                    throw new ArgumentOutOfRangeException("index");
                }

                return _list[index];
            }

            set
            {
                if (index < 0 || index >= _list.Count)
                {
                    throw new ArgumentOutOfRangeException("index");
                }

                _list[index] = value;
            }
        }

        public void Add(T item)
        {
            //Array.Resize(ref list, list.Length + 1);
            //list[list.Length - 1] = item;
            _list.Add(item);
        }

        public void AddRange(T[] items)
        {
            /*if (items.Length == 0) {
                throw new ArgumentException();
            }

            int initLength = list.Length;
            Array.Resize(ref list, list.Length + items.Length);
            list.Concat(items);
                        
            for(int i = 0; i < items.Length; i++)
            {
                list[initLength + i] = items[i];
            }*/

            if (items.Length == 0)
            {
                throw new ArgumentException("Items contains no elements");
            }

            _list.AddRange(items);
        }

        public void Remove(T item)
        {
            _list.Remove(item);
        }

        public void RemoveRange(T[] items)
        {
            if (items.Length == 0)
            {
                throw new ArgumentException("Items contains no elements");
            }

            foreach (T i in items)
            {
                Remove(i);
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _list.Count)
            {
                throw new ArgumentOutOfRangeException("index");
            }

            _list.RemoveAt(index);
        }

        public int Count()
        {
            //return list.Length;
            return _list.Count;
        }

        public bool Contains(T item)
        {
            //return list.Any(e => e.Equals(item));
            return _list.Any(e => e.Equals(item));
        }

        public T Single() {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("List contains no elements");
            }

            if (_list.Count > 1)
            {
               throw new InvalidOperationException("List contains more than one element");
            }

            return _list[0];
        }

        public T Single(Func<T, bool> func)
        {
            int count = 0;
            T element = default(T);

            foreach (T item in _list)
            {
                if (func(item))
                {
                    count++;
                    element = item;

                    if (count > 1)
                    {
                        throw new InvalidOperationException("List contains more than one matching element");
                    }
                }
            }

            if (count == 0)
            {
                throw new InvalidOperationException("List contains no matching elemen");
            }

            return element;
        }

        public T SingleOrDefault()
        {
            if (_list.Count == 0)
            {
                return default(T);
            }

            if (_list.Count > 1)
            {
                throw new InvalidOperationException("List contains more than one element");
            }

            return _list[0];
        }

        public T SingleOrDefault(Func<T, bool> func)
        {
            int count = 0;
            T element = default;

            foreach (T item in _list)
            {
                if (func(item))
                {
                    count++;
                    element = item;

                    if (count > 1)
                    {
                        throw new InvalidOperationException("List contains more than one matching element");
                    }
                }
            }

            return element;
        }

        public T Find(Predicate<T> predicate)
        {
            foreach (T item in _list)
            {
                if (predicate(item))
                {
                    return item;
                }
            }

            return default;

            //return list.ToList().Find(predicate);
            //return _list.Find(predicate);
        }

        public IEnumerable<T> Where(Func<T, bool> func)
        {
            List<T> result = new List<T>();

            foreach(T item in _list)
            {
                if (func(item))
                {
                    result.Add(item);
                }
            }

            return result;

            //return list.ToList().Select(func).ToArray();
            //return _list.Where(func);
        }

        public IEnumerable<T> GetEnumerable()
        {
            using (IEnumerator<T> enumerator = _list.GetEnumerator())
            {
                while(enumerator.MoveNext())
                {
                    yield return enumerator.Current;
                }
            }
        }

    }
}
