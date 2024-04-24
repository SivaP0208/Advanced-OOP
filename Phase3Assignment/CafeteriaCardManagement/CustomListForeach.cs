using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    public partial class CustomList<Type> : IEnumerable, IEnumerator
    {
        int index;
        public IEnumerator GetEnumerator()
        {
            index = -1;
            return (IEnumerator)this;
        }

        public bool MoveNext()
        {
            if (index < _count - 1)
            {
                index++;
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            index = -1;
        }

        public object Current { get { return _array[index]; } }
    }
}