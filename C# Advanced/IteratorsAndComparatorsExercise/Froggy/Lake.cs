using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        public List<int> Path { get; set; }
        public Lake(List<int> path)
        {
            Path = new List<int>(path);
            var evenPositions = Path.FindAll(x => path.IndexOf(x) % 2 == 0).ToList();
            var oddPositions = Path.FindAll(x => path.IndexOf(x) % 2 != 0).ToList();
            oddPositions.Reverse();
            Path.Clear();
            for (int i = 0; i < evenPositions.Count; i++)
            {
                Path.Add(evenPositions[i]);
            }
            for (int i = 0; i < oddPositions.Count; i++)
            {
                Path.Add(oddPositions[i]);
            }
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < Path.Count; i++)
            {
                yield return Path[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
        
    }
}
