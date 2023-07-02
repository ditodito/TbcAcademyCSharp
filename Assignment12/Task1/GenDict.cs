using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class GenDict<TKey, TValue> where TKey : class where TValue : Car
    {
        Dictionary<TKey, List<TValue>> _list;

        public GenDict()
        {
            _list = new Dictionary<TKey, List<TValue>>();
        }

        public void Add(TKey key, List<TValue> value)
        {
            if (_list.TryGetValue(key, out List<TValue> list))
            {
                _list[key].AddRange(value);
            } else
            {
                _list.Add(key, value);
            }
        }

        public void Add(TKey key, TValue value)
        {
            if (_list.TryGetValue(key, out List<TValue> list))
            {
                _list[key].Add(value);
            } else
            {
                _list.Add(key, new List<TValue>() { value });
            }
        }

        public void Remove(TKey key)
        {
            if (!_list.ContainsKey(key))
            {
                return;
            }

            _list.Remove(key);
        }

        public void Remove(TKey key, int index)
        {
            if (!_list.ContainsKey(key)) {
                return;
            }

            if (_list.TryGetValue(key, out List<TValue> list)) {
                if (index >= 0 && index < _list[key].Count)
                {
                    _list[key].RemoveAt(index);
                }
            }
        }

        public void Remove(TKey key, TValue value)
        {
            if (!_list.ContainsKey(key))
            {
                return;
            }

            if (_list.TryGetValue(key, out List<TValue> list))
            {
                if (_list[key].IndexOf(value) != -1)
                {
                    _list[key].Remove(value);
                }
            }
        }

        public void Append(KeyValuePair<TKey, List<TValue>> item)
        {
            _list = _list.Append<KeyValuePair<TKey, List<TValue>>>(item)
               .ToDictionary(value => value.Key, value => value.Value);
        }

        public bool HasMotorcycle()
        {
            return _list.Any<KeyValuePair<TKey, List<TValue>>>(kvp => ListHasMotorcycle(kvp.Value));
        }

        public bool HasMotorcycle(TKey key)
        {
            if(_list.TryGetValue(key, out List<TValue> list))
            {
                return ListHasMotorcycle(list);
            }

            return false;
        }

        public TValue FastestCar()
        {
            var d = _list.Aggregate((kp1, kp2) => GetFastestCar(kp1.Value).MaxSpeed > GetFastestCar(kp2.Value).MaxSpeed ? kp1 : kp2);
            return GetFastestCar(d.Value);
        }

        public TValue FastestCar(TKey key)
        {

            TValue value = default;

            if (_list.TryGetValue(key, out List<TValue> list))
            {
                return GetFastestCar(list);
            }

            return value;
        }

        public void Clear()
        {
            _list.Clear();
        }

        public void PrintList(TKey key)
        {
            if (!_list.ContainsKey(key))
            {
                return;
            }

            if (_list.TryGetValue(key, out List<TValue> list))
            {
                Console.WriteLine(GetListValues(list));
            }
        }

        public override string ToString()
        {
            string result = "";

            foreach (TKey k in _list.Keys)
            {
                result += k + " - " + GetListValues(_list[k]);
            }

            return result;
        }

        private string GetListValues(List<TValue> list)
        {
            StringBuilder sb = new StringBuilder();

            foreach (TValue t in list)
            {
                sb.Append(t.ToString());
                sb.Append("; ");
            }

            return sb.ToString();
        }

        private bool ListHasMotorcycle(List<TValue> list)
        {
            return list.Any<TValue>(value => value is Motorcycle);
        }

        private TValue GetFastestCar(List<TValue> list)
        {
            return list.Aggregate<TValue>((d, k) => d.MaxSpeed > k.MaxSpeed ? d : k);
        }
    }
}
