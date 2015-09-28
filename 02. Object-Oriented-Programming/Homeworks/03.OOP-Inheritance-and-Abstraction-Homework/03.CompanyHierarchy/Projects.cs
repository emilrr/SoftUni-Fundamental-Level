using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy
{
    class Projects : IProject
    {
        private string projectName;
        private DateTime projectStartDate;
        private string details;
        private State state;

        public Projects(string projectName, DateTime projectStartDate, string details, State state)
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectStartDate;
            this.Details = details;
            this.State = state;
        }

        public string ProjectName
        {
            get { return this.projectName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("ProjectName", "Project name can not be empty");
                }
                this.projectName = value;
            }
        }

        public DateTime ProjectStartDate { get; set; }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Details", "Details can not be empty");
                }
                this.details = value;
            }
        }
        public State State { get; set; }

        public void CloseProject(State state)
        {
            this.State = State.Closed;
        }

        public override string ToString()
        {
            string result = String.Format("Project name: {0}, Start date: {1}, Details: {2}, State: {3}",
                this.ProjectName, this.ProjectStartDate, this.Details, this.State);

            return result;
        }
    }
}
