namespace SOLIDPrinciples.Layouts
{
    using System;
    using SOLIDPrinciples.Interfaces;

    public class SimpleLayout : ILayout
    {
        private const string LogSimpleFormat = "{0} - {1} - {2}";

        public string Format(DateTime date, ReportLevel reportLevel, string message)
        {
            string formattedLog = string.Format(LogSimpleFormat + Environment.NewLine, date, reportLevel, message);

            return formattedLog;
        }
    }
}
