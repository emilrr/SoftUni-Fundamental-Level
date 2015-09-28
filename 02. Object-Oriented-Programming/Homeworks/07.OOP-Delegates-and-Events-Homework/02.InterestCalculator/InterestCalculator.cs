using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.InterestCalculator
{
    public delegate decimal CalculateInterest(decimal money, decimal interest, int year);
    public class InterestCalculator
    {
        private readonly CalculateInterest calculateInterest;
        private decimal money;
        private decimal interest;
        private int year;

        public InterestCalculator(decimal money, decimal interest, int year, CalculateInterest calculateInterest)
        {
            this.MoneyOfMoney = money;
            this.Interest = interest;
            this.Year = year;
            this.calculateInterest = calculateInterest;
        }
        public decimal MoneyOfMoney
        {
            get { return this.money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("sum", "Sum cannot be negative!");
                }
                this.money = value;
            }
        }

        public decimal Interest
        {
            get { return this.interest; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("interest", "Interest cannot be negative!");
                }
                this.interest = value;
            }
        }
        public int Year
        {
            get { return this.year; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("year", "Year cannot be negative!");
                }
                this.year = value;
            }
        }

        public decimal Balance
        {
            get { return this.calculateInterest(this.MoneyOfMoney, this.Interest, this.Year); }
            
        }
    }
}
