namespace Exceptions_Homework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        private string firstName;
        private string lastName;
        private IList<Exam.Exam> exams;

        public Student(string firstName, string lastName, IList<Exam.Exam> exams = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Exams = exams;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be empty!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be empty!");
                }

                this.lastName = value;
            }
        }

        public IList<Exam.Exam> Exams
        {
            get
            {
                return this.exams;
            }

            private set
            {
                this.exams = value;
            }
        }

        public IList<ExamResult> CheckExamsResults()
        {           
            IList<ExamResult> examResults = new List<ExamResult>();

            for (int exam = 0; exam < this.Exams.Count; exam++)
            {
                examResults.Add(this.Exams[exam].Check());
            }

            return examResults;
        }

        public double CalculateAverageExamResultInPercents()
        {
            var examsScore = new double[this.Exams.Count];
            var examResults = this.CheckExamsResults();

            for (int examResult = 0; examResult < examResults.Count; examResult++)
            {
                examsScore[examResult] = examResults[examResult].CalculateExamResults();
            }

            return examsScore.Average();
        }
    }
}
