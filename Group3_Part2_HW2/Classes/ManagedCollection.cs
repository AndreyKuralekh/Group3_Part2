using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group3_Hw8
{
    public class ManagedCollection<T> : IManagedCollection<T>, IEnumerable<T>, IList<T>
    {
        private List<T> collection;
        public ManagedCollection()
        {
            collection = new List<T>();
        }
        public void Add(T course)
        {
            collection.Add(course);
        }
        public bool Remove(T course)
        {
            return collection.Remove(course);
        }
        public int IndexOf(T course)
        {
            return collection.IndexOf(course);
        }
        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)collection).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)collection).GetEnumerator();
        }

        // Implementing IList<T> methods
        public T this[int index] { get => collection[index]; set => collection[index] = value; }

        public int Count => collection.Count;

        public bool IsReadOnly => ((IList<T>)collection).IsReadOnly;

        public void Clear()
        {
            collection.Clear();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            collection.CopyTo(array, arrayIndex);
        }

        public void Insert(int index, T item)
        {
            collection.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            collection.RemoveAt(index);
        }

        bool ICollection<T>.Contains(T item)
        {
            throw new NotImplementedException();
        }
    }
}