using System;
using System.Collections.Generic;

namespace _03.CompanyHierarchy.Interfaces
{
    public interface IManager
    {
        IList<Employee> Employees { get; set; }

    }
}
