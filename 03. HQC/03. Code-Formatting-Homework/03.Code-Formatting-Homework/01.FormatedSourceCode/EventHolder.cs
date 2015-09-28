namespace _01.FormatedSourceCode
{
    using System;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class EventHolder
    {
        private readonly MultiDictionary<string, Event> eventsByTitle =
            new MultiDictionary<string, Event>(true);

        private readonly OrderedMultiDictionary<DateTime, Event> eventsByDate = 
            new OrderedMultiDictionary<DateTime, Event>();

        public void AddEvent(DateTime date, string title, string location)
        {
            Event newEvent = new Event(date, title, location);

            this.eventsByTitle.Add(title.ToLower(), newEvent);
            this.eventsByDate.Add(newEvent);

            Messages.EventAdded();
        }

        public void DeleteEvents(string titleToDelete)
        {
            string title = titleToDelete.ToLower();
            int removed = 0;

            foreach (var eventToRemove in this.eventsByTitle[title])
            {
                removed++;
                this.eventsByDate.Remove(eventToRemove);
            }

            this.eventsByTitle.Remove(title);
            Messages.EventDeleted(removed);
        }

        public void ListEvents(DateTime date, int count)
        {
            OrderedMultiDictionary<Event>.ViewEventsToShow = this.eventsByDate
                .RangeFrom(new Event(date, string.Empty, string.Empty), true);

            int showed = 0;

            foreach (var e in eventsToShow)
            {
                if (showed == count)
                {
                    break;
                }

                Messages.PrintEvent(e);
                showed++;
            }

            if (showed == 0)
            {
                Messages.NoEventsFound();
            }
        }
    }
}
