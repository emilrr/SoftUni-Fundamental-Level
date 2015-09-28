
using System;
using System.Text;

namespace _02.Customer
{
    public class Payment
    {
        public Payment(string productName, decimal price)
        {
            this.ProductName = productName;
            this.Price = price;
        }

        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public object Clone()
        {
            Payment paymentClone = this.MemberwiseClone() as Payment;
            if (paymentClone == null)
            {
                throw new ArgumentNullException("The cloned object cannot be casted as payment type!");
            }

            return paymentClone;
        }

        public override string ToString()
        {
            StringBuilder paymentToString = new StringBuilder("");
            paymentToString.AppendLine(string.Format("[ name: {0}, price: {1} ]", this.ProductName, this.Price));
            return paymentToString.ToString();
        }
    }
}
