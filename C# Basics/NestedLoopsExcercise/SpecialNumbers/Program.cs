using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //понеже не се дели на нула, трябва да сложим continue за да я игнорира и да не се стига до деленето
            int n1 = 1111;
            int n2 = 9999;
            int counter = 0;
            for (int i = n1; i <= n2; i++)
            {
                string currentNum = i.ToString();
                counter = 0;
                for (int j = 0; j < currentNum.Length; j++)
                {
                    int currentDigit = int.Parse(currentNum[j].ToString());
                    if (currentDigit == 0)
                    {
                        continue;
                    }
                    if (n % currentDigit == 0)
                    {
                        counter++;
                        if (counter == 4)
                        {
                            Console.Write(i + " ");
                            counter = 0;
                        }
                        
                    }
                }
            }
        }
    }
}

