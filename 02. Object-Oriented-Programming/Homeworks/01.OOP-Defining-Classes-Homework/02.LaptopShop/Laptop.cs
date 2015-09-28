using System;
using System.Text;

namespace _02.LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int aRAM;
        private string graphicsCard;
        private int aHDD;
        private string screen;
        private decimal price;
        private Battery battery;

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }


        public Laptop(string model, decimal price, Battery battery) : this(model,price)
        {
            this.Model = model;
            this.Price = price;
            this.Battery = battery;

        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The model cannot be empty!");
                }
                this.model = value;
            }
        }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be less than 0!");
                }
                this.price = value;
            }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The manufactures cannot be empty!");
                }
                this.manufacturer = value;
            }
        }
        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The processor cannot be empty!");
                }
                this.processor = value;
            }
        }
        public int RAM
        {
            get { return this.aRAM; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The RAM cannot be negative number!");
                }
                this.aRAM = value;
            }
        }
       
        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The Graphics Card cannot be empty!");
                }
                this.graphicsCard = value;
            }
        }
        public int HDD
        {
            get { return this.aHDD; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The HDD cannot be negative number!");
                }
                this.aHDD = value;
            }
        }
        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The Screen cannot be empty!");
                }
                this.screen = value;
            }
        }
        public Battery Battery
        {
            get { return this.battery; }
            set
            {
                this.battery = value;
            }
        }

        public override string ToString()
        {
            StringBuilder strResult = new StringBuilder();
            strResult.AppendLine("Model - " + this.Model);
            if (this.Manufacturer != null)
            {
                strResult.AppendLine("Manufactures - " + this.Manufacturer);
            }
            if (this.Processor != null)
            {
                strResult.AppendLine("Processor - " + this.Processor);
            }
            if (aRAM > 0)
            {
                strResult.AppendLine("RAM - " + this.RAM + "GB");
            }
            
            if (aHDD > 0)
            {
                strResult.AppendLine("HDD - " + this.HDD + "GB");
            }
            if (this.Screen != null)
            {
                strResult.AppendLine("Screen - " + this.Screen);
            }
            if (Battery.BatteryLife > 0)
            {
                strResult.AppendLine("Battery Life- " + this.Battery.BatteryLife + "hours");
            }
            if (Battery.BatteryType != null)
            {
                strResult.AppendLine("Battery Type- " + this.Battery.BatteryType);
            }
            strResult.AppendLine("Price: " + this.Price + " lv.");
            return strResult.ToString();
        }
    }
}
