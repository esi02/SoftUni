using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            bool ifCity = city == "Sofia" || city == "Varna" || city == "Plovdiv";
            double comission = 0;
            if (city == "Sofia")
            {
                if (0 <= sales && sales <= 500)
                {
                    comission = sales * 0.05;
                    Console.WriteLine($"{comission:f2}");
                }
                else if (500 < sales && sales <= 1000)
                {
                    comission = sales * 0.07;
                    Console.WriteLine($"{comission:f2}");
                }
                else if (1000 < sales && sales <= 10000)
                {
                    comission = sales * 0.08;
                    Console.WriteLine($"{comission:f2}");
                }
                else if (sales > 10000)
                {
                    comission = sales * 0.12;
                    Console.WriteLine($"{comission:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
                
            }
            else if (city == "Varna")
            {
                if (0 <= sales && sales <= 500)
                {
                    comission = sales * 0.045;
                    Console.WriteLine($"{comission:f2}");
                }
                else if (500 < sales && sales <= 1000)
                {
                    comission = sales * 0.075;
                    Console.WriteLine($"{comission:f2}");
                }
                else if (1000 < sales && sales <= 10000)
                {
                    comission = sales * 0.10;
                    Console.WriteLine($"{comission:f2}");
                }
                else if (sales > 10000)
                {
                    comission = sales * 0.13;
                    Console.WriteLine($"{comission:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
                
            }
            else if (city == "Plovdiv")
            {
                if (0 <= sales && sales <= 500)
                {
                    comission = sales * 0.055;
                    Console.WriteLine($"{comission:f2}");
                }
                else if (500 < sales && sales <= 1000)
                {
                    comission = sales * 0.08;
                    Console.WriteLine($"{comission:f2}");
                }
                else if (1000 < sales && sales <= 10000)
                {
                    comission = sales * 0.12;
                    Console.WriteLine($"{comission:f2}");
                }
                else if (sales > 10000)
                {
                    comission = sales * 0.145;
                    Console.WriteLine($"{comission:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
                
            }
            else if (!ifCity || sales < 0)
            {
                Console.WriteLine("error");
            }
            
        }
    }
}
