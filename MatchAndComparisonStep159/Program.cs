using System;


namespace MatchAndComparisonStep159
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program\n\n" + "Person 1\n" + "Hourly Rate?");
            String fHourly = Console.ReadLine();
            Decimal hourlyRate = Convert.ToDecimal(fHourly);
            Console.WriteLine("Hours worked per week?");
            String fWork = Console.ReadLine();
            float workHours = float.Parse(fWork);


            Console.WriteLine("Person 2\n" + "Hourly Rate?");
            String sHourly = Console.ReadLine();
            Decimal sRate = Convert.ToDecimal(sHourly);
            Console.WriteLine("Hours worked per week?");
            String sWork = Console.ReadLine();
            float sWorkHours = float.Parse(sWork);


            Console.WriteLine("Annual salary of Person 1:");
            Decimal salOne = hourlyRate * (decimal)workHours;
            Console.WriteLine(salOne.ToString("c"));

            Console.WriteLine("Annual salary of Person 2:");
            Decimal salTwo = sRate * (decimal)sWorkHours;
            Console.WriteLine(salTwo.ToString("c"));

            Console.WriteLine("Does Person 1 make more money then Person 2?");
            bool moreMoney = salOne > salTwo;
            Console.WriteLine(moreMoney);
            Console.ReadLine();

        }
    }
}
