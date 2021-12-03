using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int lilyAge = int.Parse(Console.ReadLine());
            double washerPrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());

            //затруднението ми беше само в това кога брат й взима по едно левче - делим годините й на две за да получим четните рождени дни и умножаваме по 10 лв за общата сума, от която вадим по левче
            int toys = 0;
            double savings = 0;
            for (int i = 1; i <= lilyAge; i++)
            {
                if (i % 2 == 0)
                {
                    savings += ((i / 2) * 10) - 1; 
                }
                else
                {
                    toys++;
                }
            }
            double moneyFromToys = toysPrice * toys;
            double totalMoneyLeft = savings + moneyFromToys;
            if (totalMoneyLeft >= washerPrice)
            {
                Console.WriteLine($"Yes! {totalMoneyLeft - washerPrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washerPrice - totalMoneyLeft:f2}");
            }
        }
    }
}
