namespace ExceptionsHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CSharpExam : Exam
    {
        private const int MinScore = 0;
        private const int MaxScore = 100;
        private int score;

        public CSharpExam(int score)
        {
            if (score < MinScore || score > MaxScore)
            {
                throw new ArgumentOutOfRangeException("Score value cannot be negative or bigger than one hundred (100)!");
            }
 
            this.Score = score;
        }

        public int Score
        {
            get
            {
                return this.score;
            }

            private set
            {
                if (value < MinScore || value > MaxScore)
                {
                    throw new ArgumentOutOfRangeException("Score value cannot be negative or bigger than one hundred (100)!");
                }
 
                this.score = value;
            }
        }

        public override ExamResult Check()
        {
            return new ExamResult(this.Score, MinScore, MaxScore, "Exam results calculated by score.");
        }
    }
}