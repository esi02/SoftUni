using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public Random random = new Random();
        public string RandomString()
        {
            int elementIndex = random.Next(this.Count);
            string toRemove = this[elementIndex];
            this.Remove(this[elementIndex]);
            return toRemove;
        }
    }
}
