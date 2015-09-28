using System;
namespace SOLIDPrinciples.Appenders
{
    using System;
    using SOLIDPrinciples.Interfaces;

    internal class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout)
            : base(layout)
        {
        }

        public override void AppendMessage(DateTime dateTime, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= this.ReportLevel)
            {
                string formattedLogEntry = this.GetFormattedLogEntry(dateTime, reportLevel, message);

                Console.Write(formattedLogEntry);
            }
        }
    }
}
