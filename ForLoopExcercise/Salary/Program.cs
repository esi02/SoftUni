using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int openTabsCount = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int i = 0; i < openTabsCount; i++)
            {
                string website = Console.ReadLine();
                switch (website)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }
            Console.WriteLine(Math.Abs(salary));
        }
    }
}
