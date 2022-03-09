using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int doctorsCount = 7;
            int treatedPatients = 0;
            int untreatedPatients = 0;
            //ако пациентите са по-малко от лекарите, сумираме ги с прегледаните пациенти защото всички ще са прегледани
            //ако са повече тоест else-а събираме прегледаните с лекарите за да получим прегледаните и за непрегледаните събираме разликата на пациентите и лекарите
            for (int i = 1; i <= days; i++)
            {
                int patientsPerDay = int.Parse(Console.ReadLine());
                if (i % 3 == 0 && untreatedPatients > treatedPatients)
                {
                    doctorsCount++;
                }
                if (patientsPerDay < doctorsCount)
                {
                    treatedPatients += patientsPerDay;
                }
                else
                {
                    treatedPatients += doctorsCount;
                    untreatedPatients += patientsPerDay - doctorsCount;
                }
            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
