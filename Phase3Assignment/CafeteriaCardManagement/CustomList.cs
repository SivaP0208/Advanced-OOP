using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    public partial class CustomList<Type>
    {
        int _count;
        int _capacity;
        public int Count { get { return _count; } }
        public int Capacity { get { return _capacity; } }

        Type[] _array;

        public Type this[int index] { get { return _array[index]; } set { _array[index] = value; } }

        public CustomList()
        {
            _count = 0;
            _capacity = 6;
            _array = new Type[_capacity];
        }

        public CustomList(int size)
        {
            _count = 0;
            _capacity = size;
            _array = new Type[_capacity];
        }

        public void Add(Type element)
        {
            if (_count == _capacity)
            {
                GrowSize();
            }
            _array[_count] = element;
            _count++;
        }

        void GrowSize()
        {
            _capacity *= 2;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }

        public void AddRange(CustomList<Type> elements)
        {
            _capacity = _capacity + elements.Count + 2;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            int j = 0;
            for (int i = _count; i < _count + elements.Count; i++)
            {
                temp[i] = elements[j++];
            }
            _count = _count + elements.Count;
            _array = temp;
        }

        public bool Contains(Type element)
        {
            bool contains = false;
            foreach (Type value in _array)
            {
                if (value.Equals(element))
                {
                    contains = true;
                    break;
                }
            }
            return contains;
        }

        public int IndexOf(Type element)
        {
            int index = -1;
            for (int i = 0; i < _count; i++)
            {
                if (_array[i].Equals(element))
                {
                    index = i;
                }
            }
            return index;
        }

        public void Insert(int index, Type element)
        {
            _capacity = _capacity + 1 + 2;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < _count + 1; i++)
            {
                if (i < index)
                {
                    temp[i] = _array[i];
                }
                else if (i == index)
                {
                    temp[i] = element;
                }
                else
                {
                    temp[i] = _array[i - 1];
                }
            }
            _count++;
            _array = temp;
        }

        public void RemoveAt(int index)
        {
            if (index < _count && index >= 0)
            {
                for (int i = 0; i < _count - 1; i++)
                {
                    if (i >= index)
                    {
                        _array[i] = _array[i + 1];
                    }
                }
                _count--;
            }
        }

        public bool Remove(Type element)
        {
            int position = IndexOf(element);
            if (position >= 0)
            {
                RemoveAt(position);
                return true;
            }
            return false;
        }

        public void Reverse()
        {
            Type[] temp = new Type[_count];
            int i = 0;
            for (int j = _count - 1; j >= 0; j--)
            {
                temp[i] = _array[j];
                i++;
            }
            _array = temp;
        }

        public void InsertRange(int index, CustomList<Type> elements)
        {
            _capacity = _capacity + elements.Count + 2;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < index; i++)
            {
                temp[i] = _array[i];
            }
            int j = 0;
            for (int i = index; i < index + elements.Count; i++)
            {
                temp[i] = elements[j++];
            }
            for (int i = index + elements.Count; i < _count + elements.Count; i++)
            {
                temp[i] = _array[index++];
            }
            _count += elements.Count;
            _array = temp;
        }

        public void Sort()
        {
            for (int i = 0; i < _count - 1; i++)
            {
                for (int j = i + 1; j < _count; j++)
                {
                    if (IsGreater(_array[i], _array[j]))
                    {
                        Type temp = _array[j];
                        _array[j] = _array[i];
                        _array[i] = temp;
                    }
                }
            }
        }

        bool IsGreater(Type element1, Type element2)
        {
            int result = Comparer<Type>.Default.Compare(element1, element2);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
    }
}