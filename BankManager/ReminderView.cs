using System;
using Google.Apis.Calendar.v3;

namespace BankManager
{
    public class ReminderView
    {
        public ReminderView()
        {
        }

        public ReminderView(CalendarService service, string title, string content, string location, DateTime start,
            DateTime end)
        {
            Service = service;
            Title = title;
            Content = content;
            Location = location;
            StartDate = start;
            EndDate = end;
        }

        public CalendarService Service { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}