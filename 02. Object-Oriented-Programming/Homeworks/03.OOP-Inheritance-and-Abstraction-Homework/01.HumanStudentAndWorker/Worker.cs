using System;

namespace _01.HumanStudentAndWorker
{
    class Worker : Human
    {
        private decimal weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }
        public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0m)
                {
                    throw new ArgumentOutOfRangeException("weekSalary", "The salary cannot be a negative number");
                }
                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException("workHoursPerDay", "Work hours must be in the range [0...24]");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour(int daysPerWeek)
        {
            decimal result = this.WeekSalary / (decimal)(this.WorkHoursPerDay * daysPerWeek);

            return result;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Weekly salary: {0:N2}, daily work hours: {0:N2}",
                this.WeekSalary, this.WorkHoursPerDay);
        }
    }
}
