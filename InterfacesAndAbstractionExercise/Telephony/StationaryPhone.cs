using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : ICallable
    {
        public string CallOtherPhones(string number)
        {
            if (number.Any(Char.IsLetter) || number.Any(Char.IsWhiteSpace))
            {
                return "Invalid number!";
            }
            return $"Dialing... {number}";
        }
    }
}
