using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public partial class CustomList<Type>:IEnumerable,IEnumerator
    {
        int index;
        public IEnumerator GetEnumerator()
        {
            index=-1;
            return (IEnumerator)this;
        }

        public void Reset()
        {
            index=-1;
        }

        public bool MoveNext()
        {
            if(index<_count-1)
            {
                index++;
                return true;
            }
            Reset();
            return false;
        }

        public object Current { get{return _array[index];} }

    }
}