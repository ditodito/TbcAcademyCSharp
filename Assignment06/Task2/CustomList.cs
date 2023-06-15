using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task2
{
    internal class CustomList<T>
    {
        private T[] _elements;

        public CustomList() {
            _elements = new T[0];
        }

        public int Cuunt 
        {
            get { return _elements.Length; }
        }

        public T[] items 
        { 
            get { return _elements; } 
        }

        public T this[int index] {
            get { 
                if (index >= _elements.Length)
                {
                    throw new IndexOutOfRangeException("Index " + index + " isn't in range");
                }

                return _elements[index];
            }

            set {
                if (index >= _elements.Length)
                {
                    throw new IndexOutOfRangeException("Index " + index + " isn't in range");
                }

                _elements[index] = value;
            }
         }

        public void AddElement(T element)
        {
            Array.Resize(ref _elements, _elements.Length + 1);

            _elements[_elements.Length - 1] = element;
            //_elements.Append(element);
            //Array.Fill(_elements, element);
        }

        public void AddList(T[] elements)
        {
            if (elements.Length == 0)
            {
                return;
            }

            Array.Resize(ref _elements, _elements.Length + elements.Length);

            for (int i = 0;  i < elements.Length; i++)
            {
                _elements[_elements.Length - elements.Length + i] = elements[i];
            }
        }

        public bool InsertElement(T element, int index)
        {
            if (index > _elements.Length || index < 0)
            {
                return false;
            }

            T[] elements = new T[_elements.Length + 1];

            for (int i = 0; i < elements.Length; i++)
            {
                if (i < index)
                {
                    elements[i] = _elements[i];
                }
                else if (i == index)
                {
                    elements[i] = element;
                }
                else
                {
                    elements[i] = _elements[i - 1];
                }
            }

            _elements = elements;

            return true;
        }

        public bool InsertList(T[] items, int index)
        {

            if (index > _elements.Length || index < 0 || items.Length == 0)
            {
                return false;
            }

            T[] elements = new T[_elements.Length + items.Length];

            int j = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                if (i < index)
                {
                    elements[i] = _elements[i];
                }
                else if (i >= index && i < items.Length + index)
                {
                    elements[i] = items[j];
                    j++;
                }
                else
                {
                    elements[i] = _elements[i - items.Length];
                }
            }

            _elements = elements;

            return true;
        }

        public bool GetElement(int index, out T element)
        {
            element = default;

            if (index > _elements.Length || index < 0)
            {
                return false;
            }

            for (int i = 0; i < _elements.Length; i++)
            {
                if (i == index)
                {
                    element = _elements[i];
                    return true;
                }
            }

            return false;
        }

        public bool GetList(int index, int elementNumber, out T[] elements)
        {
            elements = default;

            if (index > _elements.Length || index < 0 || _elements.Length == 0)
            {
                return false;
            }

            int elementsLength = (index + elementNumber > _elements.Length) ? _elements.Length - index : elementNumber;

            elements = new T[elementsLength];

            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = _elements[index + i];
            }

            return true;
        }

        public void RemoveElement(T element)
        {
            int deletedElements = 0;

            for (int i = 0; i < _elements.Length; i++)
            {
                if (Object.ReferenceEquals(_elements[i], element))
                {
                    deletedElements++;
                }
            }

            if (deletedElements == 0) {
                return;
            }

            T[] elements = new T[_elements.Length - deletedElements];

            for (int i = 0, j = 0; i < _elements.Length; i++)
            {
                if (!Object.ReferenceEquals(_elements[i], element))
                {
                    elements[j] = _elements[i];
                    j++;
                }
            }

            _elements = elements;

            //bool elementFound = false;

            /*for (int i = 0; i < _elements.Length - 1; i++)
            {
                if (Object.ReferenceEquals(_elements[i], element)) {
                    T temp = _elements[i];
                    _elements[i] = _elements[i + 1];
                    _elements[i + 1] = temp;
                    elementFound = true;
                }
            }

            // Check for last element wich need to delete  
            if (!elementFound && Object.ReferenceEquals(_elements[_elements.Length - 1], element))
            {
                elementFound = true;
            }

            if (elementFound) {
                Array.Resize(ref _elements, _elements.Length - 1);
            }*/
        }

        public void RemoveList(T[] items)
        {
            if (items.Length == 0) {
                return;
            }

            int deletedElements = 0;

            for (int i = 0; i < items.Length; i++) {
                for (int j = 0; j < _elements.Length; j++)
                {
                    if (Object.ReferenceEquals(_elements[j], items[i]))
                    {
                        deletedElements++;
                    }
                }
            }

            if (deletedElements == 0)
            {
                return;
            }

            T[] elements = new T[_elements.Length - deletedElements];

            for (int i = 0, k = 0; i < _elements.Length; i++)
            {
                bool exclude = false;

                for (int j = 0; j < items.Length; j++)
                {
                    if (Object.ReferenceEquals(_elements[i], items[j]))
                    {
                        exclude = true;
                        break;
                    }
                }

                if (!exclude)
                {
                    elements[k] = _elements[i];
                    k++;
                }
            }
            
            _elements = elements;
        }

        public void Clear()
        {
            Array.Resize(ref _elements, 0);
        }

        public T Find(string name)
        {
            T element = default;

            /*for (int i = 0; i < _elements.Length; i++)
            {
                if (_elements[i].Name.ToLower() == name.ToLower())
                {
                    element = _elements[i];
                    break;
                }
            }*/

            return element;
        }
    }
}
