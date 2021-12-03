using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        public List<T> List { get; set; }
        int internalIndex = 0;
        public ListyIterator(T[] list)
        {
            List = new List<T>(list);
        }
        public ListyIterator()
        {
            List = new List<T>();
        }
        public bool Move()
        {
            if (internalIndex < List.Count - 1)
            {
                internalIndex++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool HasNext() => internalIndex < List.Count - 1;
        
        public void Print()
        {
            if (List.Count == 0)
            {
                throw new ArgumentException("Invalid operation!");
            }
            Console.WriteLine(List[internalIndex]);
        }
        public IEnumerator<T> GetEnumerator() 
        {
            for (int i = 0; i < List.Count; i++)
            {
                yield return List[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return List.GetEnumerator();
        }
    }
}
