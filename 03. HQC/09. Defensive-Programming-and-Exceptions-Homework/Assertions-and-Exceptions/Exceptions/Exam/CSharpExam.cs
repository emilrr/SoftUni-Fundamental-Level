namespace Exceptions_Homework.Exam
{
    using System;

    public class CSharpExam : Exam
    {
        private const int MinGrade = 0;
        private const int MaxGrade = 100;
        private int score;

        public CSharpExam(int score)
        {
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
                if (value < MinGrade || value > MaxGrade)
                {
                    throw new ArgumentOutOfRangeException(
                        string.Format("Score must be between {0} and {1}!", MinGrade, MaxGrade));
                }

                this.score = value;
            }
        }

        public override ExamResult Check()
        {
             var resultExam = new ExamResult(this.Score, MinGrade, MaxGrade, "Exam results calculated by score.");

            return resultExam;
        }
    }
}
