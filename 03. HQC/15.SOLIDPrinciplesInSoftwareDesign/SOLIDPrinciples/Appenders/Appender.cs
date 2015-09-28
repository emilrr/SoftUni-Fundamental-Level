namespace SOLIDPrinciples.Appenders
{
    using System;
    using SOLIDPrinciples.Interfaces;

    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout)
        {
            this.Layout = layout;
            this.ReportLevel = ReportLevel.Info;
        }

        public ILayout Layout { get; private set; }

        public ReportLevel ReportLevel { get; set; }

        public abstract void AppendMessage(DateTime dateTime, ReportLevel reportLevel, string message);

        protected string GetFormattedLogEntry(DateTime dateTime, ReportLevel reportLevel, string message)
        {
            return this.Layout.Format(dateTime, reportLevel, message);
        }
    }
}
