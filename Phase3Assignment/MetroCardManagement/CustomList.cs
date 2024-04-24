using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public partial class CustomList<Type>
    {
        int _count;
        int _capacity;
        public int Count { get{return _count;} }
        public int Capacity { get{return _capacity;}}

        Type[] _array;

        public Type this[int index] { get{return _array[index];} set{_array[index]=value;} }

        public CustomList()
        {
            _count=0;
            _capacity=5;
            _array=new Type[_capacity];
        }

        public CustomList(int size)
        {
            _count=0;
            _capacity=size;
            _array=new Type[_capacity];
        }

        public void Add(Type value)
        {
            if(_count==_capacity)
            {
                GrowSize();
            }
            _array[_count]=value;
            _count++;
        }

        void GrowSize()
        {
            _capacity=_capacity*2;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;
        }

        public void AddRange(CustomList<Type> values)
        {
            _capacity=_count+values.Count+3;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            int j=0;
            for(int i=_count;i<_count+values.Count;i++)
            {
                temp[i]=values[j++];
            }
            _array=temp;
            _count=_count+values.Count;
        }

        public int IndexOf(Type value)
        {
            int index=-1;
            for(int i=0;i<_count;i++)
            {
                if(_array[i].Equals(value))
                {
                    index=i;
                }
            }
            return index;
        }

        public void Insert(int index,Type value)
        {
            _capacity=_count+1;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count+1;i++)
            {
                if(i<index)
                {
                    temp[i]=_array[i];
                }
                else if(i==index)
                {
                    temp[i]=value;
                }
                else
                {
                    temp[i]=_array[i-1];
                }
            }
            _array=temp;
            _count++;
        }

        public bool Contains(Type value)
        {
            bool isPresent=false;
            foreach(Type element in _array)
            {
                if(value.Equals(element))
                {
                    isPresent=true;
                    break;
                }
            }
            return isPresent;
        }

        public void Reverse()
        {
            Type[] temp=new Type[_count];
            int j=0;
            for(int i=_count-1;i>=0;i--)
            {
                temp[i]=_array[j++];
            }
            _array=temp;
        }

        public void InsertRange(int index,CustomList<Type> values)
        {
            _capacity=_count+values.Count+2;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<index;i++)
            {
                temp[i]=_array[i];
            }
            int j=0;
            for(int i=index;i<index+values.Count;i++)
            {
                temp[i]=values[j++];
            }
            for(int i=index+values.Count;i<_count+values.Count;i++)
            {
                temp[i]=_array[index++];
            }
            _array=temp;
            _count=_count+values.Count;
        }

        public void RemoveAt(int index)
        {
            if(index>=0 && index<_count)
            {
                for(int i=0;i<_count-1;i++)
                {
                    if(i>=index)
                    {
                        _array[i]=_array[i+1];
                    }
                }
                _count--;
            }
        }

        public bool Remove(Type value)
        {
            int index=IndexOf(value);
            bool removed=false;
            if(index>=0)
            {
                RemoveAt(index);
                removed=true;
            }
            return removed;
        }
    }
}