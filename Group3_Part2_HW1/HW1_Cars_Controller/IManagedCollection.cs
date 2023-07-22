using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group3_Hw8
{
    public interface IManagedCollection<T> 
    {//add, remove, get the number
        public void Add(T course);

        public bool Remove(T course);

        public int IndexOf(T course);
    }
}
