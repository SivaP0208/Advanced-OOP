using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
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
            _capacity = 5;
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
            _capacity = _capacity * 2;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }

        public void AddRange(CustomList<Type> elementList)
        {
            _capacity = _count + elementList.Count + 3;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            int j = 0;
            for (int i = _count; i < _count + elementList.Count; i++)
            {
                temp[i] = elementList[j++];
            }
            _array = temp;
            _count = _count + elementList.Count;
        }

        public bool Insert(int index, Type element)
        {
            _capacity = _count + 1;
            Type[] temp = new Type[_capacity];
            bool isInsert = false;
            if (index <= _count && index >= 0)
            {
                isInsert = true;
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
            }
            return isInsert;
        }

        public bool RemoveAt(int index)
        {
            bool isRemoved = false;
            if (index < _count && index >= 0)
            {
                isRemoved = true;
                for (int i = 0; i < _count - 1; i++)
                {
                    if (i >= index)
                    {
                        _array[i] = _array[i + 1];
                    }
                }
            }
            return isRemoved;
        }

        public void Reverse()
        {
            Type[] temp = new Type[_capacity];
            int j = 0;
            for (int i = _count - 1; i >= 0; i--)
            {
                temp[i] = _array[j++];
            }
            _array = temp;
        }
    }
}