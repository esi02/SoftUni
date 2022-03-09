using System;
using System.Linq;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] websites = Console.ReadLine().Split();
            var phone = new Smartphone();
            var stat = new StationaryPhone();

            foreach (var num in phoneNumbers)
            {
                if (num.Length == 10)
                {
                    Console.WriteLine(phone.CallOtherPhones(num));
                }
                else if (num.Length == 7)
                {
                    Console.WriteLine(stat.CallOtherPhones(num));
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }
            }

            foreach (var url in websites)
            {
                Console.WriteLine(phone.BrowseWeb(url));
            }
        }
    }
}
