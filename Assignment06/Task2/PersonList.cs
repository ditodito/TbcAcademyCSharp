using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task2
{
    internal class PersonList
    {
        private Person[] _persons;

        public PersonList()
        {
            _persons = new Person[0];
        }

        public int Cuunt
        {
            get { return _persons.Length; }
        }

        public Person[] items 
        { 
            get { return _persons; } 
        }

        public Person this[int index]
        {
            get
            {
                if (index >= _persons.Length || index < 0)
                {
                    throw new IndexOutOfRangeException("Index " + index + " isn't in range");
                }

                return _persons[index];
            }

            set
            {
                if (index >= _persons.Length || index < 0)
                {
                    throw new IndexOutOfRangeException("Index " + index + " isn't in range");
                }

                _persons[index] = value;
            }
        }

        public void AddElement(Person element)
        {
            Array.Resize(ref _persons, _persons.Length + 1);

            _persons[_persons.Length - 1] = element;
        }

        public void AddList(Person[] persons)
        {
            if (persons.Length == 0)
            {
                return;
            }

            Array.Resize(ref _persons, _persons.Length + persons.Length);

            for (int i = 0; i < persons.Length; i++)
            {
                _persons[_persons.Length - persons.Length + i] = persons[i];
            }
        }

        public bool InsertElement(Person person, int index)
        {
            if (index > _persons.Length || index < 0)
            {
                return false;
            }

            Person[] persons = new Person[_persons.Length + 1];

            for (int i = 0; i < persons.Length; i++) 
            {
                if (i < index)
                {
                    persons[i] = _persons[i];
                }
                else if (i == index)
                {
                    persons[i] = person;
                }
                else
                {
                    persons[i] = _persons[i - 1];
                }
            }

            _persons = persons;

            return true;
        }

        public bool InsertList(Person[] items, int index)
        {

            if (index > _persons.Length || index < 0 || items.Length == 0)
            {
                return false;
            }

            Person[] persons = new Person[_persons.Length + items.Length];

            int j = 0;

            for (int i = 0; i < persons.Length; i++) 
            {
                if (i < index)
                {
                    persons[i] = _persons[i];
                }
                else if (i >= index && i < items.Length + index)
                {
                    persons[i] = items[j];
                    j++;
                }
                else
                {
                    persons[i] = _persons[i - items.Length];
                }
            }

            _persons = persons;

            return true;
        }

        public bool GetElement(int index, out Person person)
        {
            person = default;

            if (index > _persons.Length || index < 0)
            {
                return false;
            }

            person = _persons[index];
            return true;
        }

        public bool GetList(int index, int elementNumber, out Person[] elements)
        {
            elements = default;

            if (index > _persons.Length || index < 0 || _persons.Length == 0)
            {
                return false;
            }

            int elementsLength = (index + elementNumber > _persons.Length) ? _persons.Length - index : elementNumber;

            elements = new Person[elementsLength];

            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = _persons[index + i];
            }

            return true;
        }

        public void RemoveElement(Person element)
        {
            int deletedElements = 0;

            for (int i = 0; i < _persons.Length; i++)
            {
                if (Object.ReferenceEquals(_persons[i], element))
                {
                    deletedElements++;
                }
            }

            if (deletedElements == 0)
            {
                return;
            }

            Person[] elements = new Person[_persons.Length - deletedElements];

            for (int i = 0, j = 0; i < _persons.Length; i++)
            {
                if (!Object.ReferenceEquals(_persons[i], element))
                {
                    elements[j] = _persons[i];
                    j++;
                }
            }

            _persons = elements;

            /*bool elementFound = false;

            for (int i = 0; i < _persons.Length - 1; i++)
            {
                if (Object.ReferenceEquals(_persons[i], element))
                {
                    Person temp = _persons[i];
                    _persons[i] = _persons[i + 1];
                    _persons[i + 1] = temp;
                    elementFound = true;
                }
            }

            // Check for last element wich need to delete 
            if (!elementFound && Object.ReferenceEquals(_persons[_persons.Length - 1], element))
            {
                elementFound = true;
            }

            if (elementFound)
            {
                Array.Resize(ref _persons, _persons.Length - 1);
            }*/
        }

        public void RemoveList(Person[] items)
        {
            if (items.Length == 0)
            {
                return;
            }

            int deletedElements = 0;

            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < _persons.Length; j++)
                {
                    if (Object.ReferenceEquals(_persons[j], items[i]))
                    {
                        deletedElements++;
                    }
                }
            }

            if (deletedElements == 0)
            {
                return;
            }

            Person[] elements = new Person[_persons.Length - deletedElements];

            for (int i = 0, k = 0; i < _persons.Length; i++)
            {
                bool exclude = false;

                for (int j = 0; j < items.Length; j++)
                {
                    if (Object.ReferenceEquals(_persons[i], items[j]))
                    {
                        exclude = true;
                        break;
                    }
                }

                if (!exclude)
                {
                    elements[k] = _persons[i];
                    k++;
                }
            }

            _persons = elements;
        }

        public void Clear()
        {
            Array.Resize(ref _persons, 0);
        }

        public Person Find(string name)
        {
            Person person = default;

            for (int i = 0; i < _persons.Length; i++)
            {
                if (String.Equals(_persons[i].Name, name, StringComparison.OrdinalIgnoreCase))
                {
                    person = _persons[i];
                    break;
                }
            }

            return person;
        }
    }
}
