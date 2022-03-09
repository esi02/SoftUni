using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : IBrowsable, ICallable
    {
        public string CallOtherPhones(string number)
        {
            if (number.Any(Char.IsLetter) || number.Any(Char.IsWhiteSpace))
            {
                return "Invalid number!";
            }
            return $"Calling... {number}";
        }

        public string BrowseWeb(string url)
        {
            if (url.Any(Char.IsDigit) || url.Any(Char.IsWhiteSpace))
            {
                return "Invalid URL!";
            }

            return $"Browsing: {url}!";
        }

    }
}
