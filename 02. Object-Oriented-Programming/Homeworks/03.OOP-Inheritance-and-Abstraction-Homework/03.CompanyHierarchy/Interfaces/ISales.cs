using System;

namespace _03.CompanyHierarchy.Interfaces
{
    interface ISales
    {
        string ProductName { get; set; }
        DateTime Date { get; set; }
        decimal Price { get; set; }
    }
}
