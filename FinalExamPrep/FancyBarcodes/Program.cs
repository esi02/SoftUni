using System;
using System.Text.RegularExpressions;

namespace FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex barcodePattern = new Regex(@"@#+[A-Z]{1}[A-Za-z0-9]{4,}[A-Z]{1}@#+");

            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                bool isValid = barcodePattern.IsMatch(input);
                string concatDigits = string.Empty;

                if (isValid)
                {
                    for (int j = 0; j < input.Length; j++)
                    {
                        if (char.IsDigit(input[j]))
                        {
                            concatDigits += input[j];
                        }
                    }
                    if (concatDigits == string.Empty)
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {concatDigits}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }
        }
    }
}
