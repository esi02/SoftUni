using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace FakeAxeAndDummy
{
    public interface IWeapon
    {
        public int durabilityPoints
        {
            get;
        }
        public int attackPoints
        {
            get;
        }
    }
}
