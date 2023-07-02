using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class GenList<T> where T : Car 
    {
        private List<T> _list;

        public GenList() {
            _list = new List<T>();
        }

        public List<T> List { get { return _list; } }

        public void Add(T element)
        {
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
            _list.Sort(new CarComp());
        }

        public int IndexOf(T element)
        {
            return _list.IndexOf(element);
        }

        public int IndexOf(T element, int index)
        {
            return _list.IndexOf(element, index);
        }

        public int IndexOf(T element, int index, int count)
        {
            return _list.IndexOf(element, index, count);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            foreach(T element in _list)
            {
                sb.Append(element.Mark);
                sb.Append(";");
            }

            return sb.ToString();
        }
    }
}
