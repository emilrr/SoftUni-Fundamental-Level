using System;
using System.Text;

namespace _02.LaptopShop
{
    class Battery
    {
        private string batteryType;
        private double batteryLife;

        public Battery(string type)
        {
            this.BatteryType = type;
        }
        public Battery(string type, double hours) : this(type)
        {
            this.BatteryLife = hours;
        }

        public string BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Invalid type for battery!");
                }
                this.batteryType = value;
            }
        }

        public double BatteryLife
        {
            get
            {
                return this.batteryLife;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid type for battery!");
                }
                this.batteryLife = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            if (this.BatteryType != null)
            {
                result.AppendLine("battery is: " + this.BatteryType);
            }
            if (this.BatteryLife > 0)
            {
                result.AppendLine("battery life is: " + this.BatteryLife + "hours");
            }
            return result.ToString();
        }
    }
}
