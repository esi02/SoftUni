using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgnChecker
{
    public class EgnGenerator
    {
        public string DateOfBirth_SixDigits(string dateOfBirth)
        {
            string yearDigits = dateOfBirth.Substring(0, 2);
            string monthDigits = dateOfBirth.Substring(2, 5);
            string dayDigits = dateOfBirth.Substring(5, 7);

            int year = int.Parse(yearDigits);
            int month = int.Parse(monthDigits);
            int day = int.Parse(dayDigits);

            if (year < 1900)
            {
                month += 20;
            }
            else if (year > 1999 && year <= 2099)
            {
                month += 40;
            }

            monthDigits = month.ToString();
            string sixDigits = string.Concat(yearDigits, monthDigits, dayDigits);

            return sixDigits;
        }
    }
}
