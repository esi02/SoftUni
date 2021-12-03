using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        public List<T> stack { get; set; }
        public Stack()
        {
            stack = new List<T>();
        }
        public void Push(params T[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                stack.Insert(0, elements[i]);
            }
        }
        public void Pop()
        {
            if (stack.Count == 0)
            {
                Console.WriteLine($"No elements");
            }
            else
            {
                var last = stack.First();
                stack.Remove(last);
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < stack.Count; i++)
            {
                yield return stack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

    }
}
