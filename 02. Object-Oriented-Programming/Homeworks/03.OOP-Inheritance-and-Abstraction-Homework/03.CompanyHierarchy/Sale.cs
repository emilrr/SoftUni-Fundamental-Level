using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy
{
    public class Sale:ISales
    {
        private string productName;
        private DateTime dateTime;
        private decimal price;

        public Sale(string productName, DateTime dateTime, decimal price)
        {
            this.ProductName = productName;
            this.Date = dateTime;
            this.Price = price;
        }

        public string ProductName
        {
            get { return this.productName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("ProductName", "Product name can not be empty");
                }
                this.productName = value;
            }
        }

        public DateTime Date { get; set; }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0m)
                {
                    throw new ArgumentOutOfRangeException("Price", "Price can not be negative");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            string result = string.Format("Product name: {0}, Date: {1}, Price: {2}",
               this.ProductName, this.Date, this.Price);

            return result;
        }
    }
}
