namespace SOLIDPrinciples.Appenders
{
    using System;
    using SOLIDPrinciples.Interfaces;

    internal class FileAppender : Appender
    {
        public FileAppender(ILayout layout)
            : base(layout)
        {
        }

        public string File { get; set; }

        public override void AppendMessage(DateTime dateTime, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= this.ReportLevel)
            {
                string formattedLogEntry = this.GetFormattedLogEntry(dateTime, reportLevel, message);

                System.IO.File.AppendAllText(File, formattedLogEntry);
            }
        }
    }
}
