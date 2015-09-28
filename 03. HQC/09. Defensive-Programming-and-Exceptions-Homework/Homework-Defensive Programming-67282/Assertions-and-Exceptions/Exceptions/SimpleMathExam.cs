namespace ExceptionsHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SimpleMathExam : Exam
    {
        private const int MinGrade = 2;
        private const int MaxGrade = 6;
        private int problemSolved;

        public SimpleMathExam(int problemsSolved)
        {
            if (problemsSolved < 0 || problemsSolved > 2)
            {
                throw new ArgumentOutOfRangeException("The solved problems cannot be negative or bigger than two (2)!");
            }
 
            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved
        {
            get
            {
                return this.problemSolved;
            }

            private set
            {
                if (value < 0 || value > 2)
                {
                    throw new ArgumentOutOfRangeException("The solved problems cannot be negative or bigger than two (2)!");
                }
 
                this.problemSolved = value;
            }
        }

        public override ExamResult Check()
        {
            if (this.ProblemsSolved == 0)
            {
                return new ExamResult(2, MinGrade, MaxGrade, "Bad result: nothing done.");
            }
            else if (this.ProblemsSolved == 1)
            {
                return new ExamResult(4, MinGrade, MaxGrade, "Average result: average done.");
            }
            else if (this.ProblemsSolved == 2)
            {
                return new ExamResult(6, MinGrade, MaxGrade, "Excellent result: everything done.");
            }
 
            throw new ArgumentOutOfRangeException("The value of solved problems is invalid!");
        }
    }
}