using System;

namespace _03.CompanyHierarchy.Interfaces
{
    public interface IProject
    {
        string ProjectName { get; set; }
        DateTime ProjectStartDate { get; set; }
        string Details { get; set; }
        State State { get; set; }
        void CloseProject(State state);
    }
}
