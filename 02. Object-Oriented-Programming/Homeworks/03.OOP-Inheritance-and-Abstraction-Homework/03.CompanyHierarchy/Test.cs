using System;
using System.Collections.Generic;

namespace _03.CompanyHierarchy
{
    class Test
    {
        static void Main()
        {
            List<Projects> softUniProjects = new List<Projects>()
            {
                new Projects("LDS", new DateTime(2014, 03, 01), "system for automated testing", State.Closed),
                new Projects("Web site", new DateTime(2013, 10, 15), "Acer website", State.Open)
            };

            Employee vladoG = new Developer("Georgi", "Georgiev", "85020233330", 3000, Department.Production, softUniProjects);
            Employee vladoV = new Developer("Dimitar", "Dimitrov", "8812126050", 3000, Department.Production, softUniProjects);

            List<Sale> sales = new List<Sale>()
            {
                new Sale("First level", new DateTime(2014, 05, 01), 380),
                new Sale("Second level", new DateTime(2014, 09, 05), 380)
            };

            Employee petya = new SalesEmployee("Dimitrinka", "Dimitrova", "7512134455", 1500, Department.Marketing, sales);


            Person petar = new Manager("Petar", "Petrov", "6010101212", 10000, Department.Marketing, new List<Employee>() { vladoG, vladoV, petya });

            Console.WriteLine(petar);

            Person daniel = new Customer("Ognqn", "Dimitrov", "7502022022", 830);
            Console.WriteLine();
            Console.WriteLine(daniel);
        
        }
    }
}
