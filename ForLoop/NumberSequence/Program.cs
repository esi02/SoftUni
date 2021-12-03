using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int smallest = int.MaxValue;
            int biggest = int.MinValue;
            //трябва и двете проверки да се извършат задължително, не се получава с else if
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
            //ако цифрата е по-малка от максимума и цифрата е по-голяма от минимума
                int num = int.Parse(Console.ReadLine());
                if (num > biggest)
                {
                    biggest = num;
                }    
                if (num < smallest)
                {
                    smallest = num;
                }
            }
            Console.WriteLine($"Max number: {biggest}");
            Console.WriteLine($"Min number: {smallest}");
        }
    }
}
