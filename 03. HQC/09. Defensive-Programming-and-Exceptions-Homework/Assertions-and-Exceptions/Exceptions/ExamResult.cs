namespace Exceptions_Homework
{
    using System;

    public class ExamResult
    {
        private int grade;
        private int minGrade;
        private int maxGrade;
        private string comments;

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }

            private set
            {
                if (value < this.MinGrade || value < this.MaxGrade)
                {
                    throw new ArgumentOutOfRangeException(
                        string.Format(
                            "Grade must be between {0} and {1}!", this.MinGrade, this.MaxGrade));
                }

                this.grade = value;
            }
        }

        public int MinGrade
        {
            get
            {
                return this.minGrade;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("MinGrade can not be less than zero!");
                }

                this.minGrade = value;
            }
        }

        public int MaxGrade
        {
            get
            {
                return this.maxGrade;
            }

            private set
            {
                if (value > this.MinGrade)
                {
                    throw new ArgumentOutOfRangeException("MaxGrade must be greater than MinGrade!");
                }

                this.maxGrade = value;
            }
        }

        public string Comments
        {
            get
            {
                return this.comments;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Comments can not be null or empty string!");
                }

                this.comments = value;
            }
        }

        public double CalculateExamResults()
        {
            var examResult = (double)(this.Grade - this.MinGrade) / (this.MaxGrade - this.MinGrade);
            return examResult;
        }
    }
}
