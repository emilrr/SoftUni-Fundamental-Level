using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Customer
{
    class TestCustomer
    {
        static void Main()
        {
            Payment phone = new Payment("Samsung S6", 3500m);
            Payment monitor = new Payment("Monitor Sony", 149.99m);

            Customer ivan = new Customer("Ivan", "Petrov", "Ivanov", 9305054476, "Borisova 34", "0883-43-43-12",
                "ivanVan@abv.bg", new List<Payment>() { phone, monitor }, CustomerType.Regular);

            // correct copy
            Customer ivanCopy = (Customer)ivan.Clone();
            ivanCopy.FirstName = "Ivancho";
            ivanCopy.Payments.Add(new Payment("Car audi A4", 5000m));
            Console.WriteLine(ivan);
            Console.WriteLine(ivanCopy);
            Console.WriteLine("ivanCopy == ivan : {0}", ivanCopy == ivan);
            Console.WriteLine("ivan.Equals(ivanCopy) : {0}", ivan.Equals(ivanCopy));
            Console.WriteLine("Object.ReferenceEquals(ivan, ivanCopy) : {0}", Object.ReferenceEquals(ivan, ivanCopy));
            Console.WriteLine("\n\n");

            // incorrect copy
            ivanCopy = ivan;
            ivan.FirstName = "Ivancho";
            ivanCopy.Payments.Add(new Payment("Car audi A4", 5000m));
            Console.WriteLine(ivan);
            Console.WriteLine(ivanCopy);
            Console.WriteLine("ivanCopy == ivan : {0}", ivanCopy == ivan);
            Console.WriteLine("ivan.Equals(ivanCopy) : {0}", ivan.Equals(ivanCopy));
            Console.WriteLine("Object.ReferenceEquals(ivan, ivanCopy) : {0}", Object.ReferenceEquals(ivan, ivanCopy));

        }
    }
}
