using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359( |-)2\1(\d{3})\1(\d{4})\b";

            string phones = Console.ReadLine();

            MatchCollection matchedPhones = Regex.Matches(phones, pattern);

            string[] toPrint = matchedPhones
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", toPrint));
        }
    }
}
