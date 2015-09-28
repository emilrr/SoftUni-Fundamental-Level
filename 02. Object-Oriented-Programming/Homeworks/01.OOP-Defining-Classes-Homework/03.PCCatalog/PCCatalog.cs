using System;
using System.Collections.Generic;
using System.Linq;

class PCCatalog
{
    static void Main()
    {
        List<Computer> catalog = new List<Computer>();
        List<Component> components1 = new List<Component>();
        components1.Add(new Component("HDD", 500.00m));
        components1.Add(new Component("CPU", 250.12m));
        Computer hp = new Computer("HP", components1);

        List<Component> components2 = new List<Component>();
        components2.Add(new Component("CPU", 400.01m));
        components2.Add(new Component("RAM", 102.00m));
        components2.Add(new Component("Graphics card", 100));
        Computer sony = new Computer("Sony", components2);


        catalog.Add(hp);
        catalog.Add(sony);

        var sortCatalog = catalog.OrderBy(computer => computer.Price);

        foreach (var computer in sortCatalog)
        {
            Console.WriteLine(computer);
        }
    }
}

