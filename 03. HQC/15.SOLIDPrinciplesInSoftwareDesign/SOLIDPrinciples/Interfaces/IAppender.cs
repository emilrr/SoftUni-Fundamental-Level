namespace SOLIDPrinciples.Interfaces
{
    using System;

    public interface IAppender
    {
        ReportLevel ReportLevel { get; set; }

        ILayout Layout { get; }

        void AppendMessage(DateTime dateTime, ReportLevel reportLevel, string message);
    }
}
