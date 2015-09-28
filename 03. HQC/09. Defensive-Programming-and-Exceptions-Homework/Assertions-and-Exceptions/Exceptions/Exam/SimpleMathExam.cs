namespace Exceptions_Homework.Exam
{
    using System;

    public class SimpleMathExam : Exam
    {
        private const int MinGrade = 2;
        private const int MaxGrade = 6;

        private const int MinProblemSolved = 0;
        private const int MaxProblemSolved = 10;

        private int problemsSolved;

        public SimpleMathExam(int problemsSolved)
        {
            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved
        {
            get
            {
                return this.problemsSolved;
            }

            private set
            {
                if (value < MinProblemSolved || value > MaxProblemSolved)
                {
                    throw new ArgumentOutOfRangeException(
                        string.Format("Solved Problems must be between {0} and {1}!", MinProblemSolved, MaxProblemSolved));
                }
                this.problemsSolved = value;
            }
        }

        public override ExamResult Check()
        {
            if (this.ProblemsSolved == MinProblemSolved)
            {
                return new ExamResult(MinGrade, MinGrade, MaxGrade, "Bad result: nothing done.");
            }

            if (this.ProblemsSolved == 1)
            {
                return new ExamResult(4, MinGrade, MaxGrade, "Average result: nothing done.");
            }

            if (this.ProblemsSolved == MaxProblemSolved)
            {
                return new ExamResult(MaxGrade, MinGrade, MaxGrade, "Average result: nothing done.");
            }

        }
    }
}
