using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class ArrL<T> 
    {
        private ArrayList _list;

        public ArrL() : this(4) {}

        public ArrL(int initialSize) {
           _list = new ArrayList(initialSize);
        }

        public ArrayList List { get { return _list; } }

        public void Add(T element) {
            _list.Add(element);
        }

        public void Add(T[] elements)
        {
            _list.AddRange(elements);
        }

        public void Insert(int index, T element)
        {
            _list.Insert(index, element);
        }

        public void Insert(int index, T[] element)
        {
            _list.InsertRange(index, element);
        }

        public void Remove(T element)
        {
            _list.Remove(element);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public void RemoveAt(int index, int count)
        {
            _list.RemoveRange(index, count);
        }

        public int Search(T element)
        {
            return _list.BinarySearch(element);
        }

        public void Sort()
        {
            _list.Sort();
        }

        public void Reverse()
        {
            _list.Reverse();
        }

        public void Reverse(int index, int count)
        {
            _list.Reverse(index, count);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public override string ToString()
        {
            return String.Join(",", _list.ToArray());
        }
    }
}
