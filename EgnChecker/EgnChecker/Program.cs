using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace EgnChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string timeGreeting = string.Empty;
            int usersHour = DateTime.Now.Hour;

            if (usersHour < 12)
            {
                timeGreeting = "Добро утро!";
            }
            else if (usersHour > 12 && usersHour < 17)
            {
                timeGreeting = "Добър ден!";
            }
            else
            {
                timeGreeting = "Добър вечер!";
            }

            Console.WriteLine($"{timeGreeting} Добре дошли в ЕГН Валидатор v1.0. Моля, изберете една от следните опции: ");

            int validation = 1;
            int generation = 2;

            Console.WriteLine("1. Валидация на ЕГН");
            Console.WriteLine("2. Генериране на случайно ЕГН според региона");
            int chosenOption = 0;

            while (chosenOption != 1 && chosenOption != 2)
            {
                try
                {
                    chosenOption = int.Parse(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.WriteLine("Моля, въведете валиден номер спрямо избраната опция!");
                }

            }

            if (chosenOption == 1)
            {
                Console.WriteLine("Въведете вашето ЕГН:");
                string egn = Console.ReadLine();
                EgnValidator validator = new EgnValidator(egn);
                
                if (validator.IsValid())
                {
                    Console.WriteLine("ЕГН-то е валидно!");
                }
                else
                {
                    Console.WriteLine("ЕГН-то НЕ Е валидно!");
                }

            }
            else
            {

            }
        }
    }
}
