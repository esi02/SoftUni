using System;
using System.Linq;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Pizza piza = null;
            Dough dough = null;
            Topping topping = null;

            string[] pizzaArgs = input.Split();
            string[] doughArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            try
            {
                dough = new Dough(doughArgs[1], doughArgs[2], double.Parse(doughArgs[3]));
                piza = new Pizza(pizzaArgs[1], dough);
            }
            catch (Exception ae)
            {
                Console.WriteLine(ae.Message);
                return;
            }

            input = Console.ReadLine();
            while (input != "END")
            {
                string[] toppingArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = toppingArgs[1];
                double weight = double.Parse(toppingArgs[2]);
                try
                {
                    topping = new Topping(type, weight);
                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee.Message);
                    return;
                }

                try
                {
                    piza.AddTopping(topping);
                }
                catch (Exception list)
                {
                    Console.WriteLine(list.Message);
                    return;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{piza.Name} - {piza.TotalCalories:f2} Calories.");
        }
    }
}
