namespace _01.FormatedSourceCode
{
    using System;
    using System.Text;

    using Wintellect.PowerCollections;

    internal class Event : IComparable
    {
        private readonly DateTime date;

        private readonly string title;

        private readonly string location;

        public Event(DateTime date, string title, string location)
        {
            this.date = date;
            this.title = title;
            this.location = location;
        }

        public int CompareTo(object other)
        {
            Event otherEvent = other as Event;

            int compareByDate = this.date.CompareTo(otherEvent.date);
            int compareByTitle = this.title.CompareTo(otherEvent.title);
            int compareByLocation = this.location.CompareTo(otherEvent.location);

            if (compareByDate == 0)
            {
                if (compareByTitle == 0)
                {
                    return compareByLocation;
                }

                return compareByTitle;
            }

            return compareByDate;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(this.date.ToString("yyyy-MM-ddTHH:mm:ss"));
            output.Append(" | " + this.title);

            if (string.IsNullOrEmpty(this.location))
            {
                output.Append(" | " + this.location);
            }

            return output.ToString();
        }
    }
}