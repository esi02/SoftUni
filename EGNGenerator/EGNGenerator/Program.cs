using System;

namespace EGNGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 9;
            int year2 = 9;

            for (int month1 = 0; month1 <= 1; month1++)
            {
                for (int month2 = 1; month2 <= 9; month2++)
                {
                    for (int days1 = 0; days1 <= 3; days1++)
                    {
                        for (int days2 = 1; days2 <= 9; days2++)
                        {
                            for (int region1 = 0; region1 <= 9; region1++)
                            {
                                for (int region2 = 0; region2 <= 9; region2++)
                                {
                                    for (int gender = 1; gender <= 9; gender++)
                                    {
                                        int tenthNumSum = year * 2 + year2 * 4 + month1 * 8 + month2 * 5 + days1 * 10 + days2 * 9 + region1 * 7 + region2 * 3 + gender * 6;
                                        int tenthNumSum1 = tenthNumSum / 11;
                                        int tenthNum = tenthNumSum - 11 * tenthNumSum1;
                                        if (tenthNum >= 10)
                                        {
                                            tenthNum = 0;
                                        }
                                        Console.Write($"{year}{year2}{month1}{month2}{days1}{days2}{region1}{region2}{gender}{tenthNum} ");
                                        tenthNum = 0;
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
