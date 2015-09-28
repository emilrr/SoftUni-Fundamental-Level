using System;

namespace _02.InterestCalculator
{
    class InterestCalculatorMain
    {
        static void Main()
        {
            InterestCalculator compoundInterest = new InterestCalculator(500m, 0.056m, 10, GetCompoundInterest);
            Console.WriteLine(compoundInterest.Balance);

            InterestCalculator simpleInterest = new InterestCalculator(2500m, 0.072m, 15, GetSimpleInterest);
            Console.WriteLine(simpleInterest.Balance);
        }

        public const int MonthsInYear = 12;

        public static decimal GetSimpleInterest(decimal sum, decimal interest, int year)
        {
            var interestFactor = 1 + (interest * year);
            var result = sum * interestFactor;

            return decimal.Round(result, 4);
        }

        public static decimal GetCompoundInterest(decimal sum, decimal interest, int year)
        {
            decimal interestFactorBase = 1 + (interest / MonthsInYear);
            int interestFactorPower = year * MonthsInYear;

            decimal interestFactor = 1;
            for (int i = 0; i < interestFactorPower; i++)
            {
                interestFactor *= interestFactorBase;
            }

            decimal balance = sum * interestFactor;

            return decimal.Round(balance, 4);
        }


    }
}
