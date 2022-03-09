using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using SpaceStation.Models.Bags.Contracts;

namespace SpaceStation.Models.Bags
{
    public class Backpack : IBag
    {
        private List<string> items;
        public ICollection<string> Items => this.items;

        public Backpack()
        {
            this.items = new List<string>();
        }
    }
}
