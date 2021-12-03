using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.	Депозирана сума – реално число в интервала [100.00 … 10000.00];
            double deposit = double.Parse(Console.ReadLine());
            //2.Срок на депозита(в месеци) – цяло число в интервала[1…12];
            int months = int.Parse(Console.ReadLine());
            //3.Годишен лихвен процент – реално число в интервала[0.00 …100.00];
            double interest = double.Parse(Console.ReadLine());
            //Изчисляваме сумата
            //сума = депозирана сума  + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)
            double result = deposit + months * ((deposit * (interest / 100) / 12));
            Console.WriteLine(result);
        }
    }
}
