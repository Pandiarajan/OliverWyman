using System;
using System.Collections.Generic;

namespace TransportAnnouncementTracker.Announcement
{
    public class TextAnnouncer : IAnnouncer
    {
        public void Send(string message)
        {
            Console.WriteLine(message);
        }

        public void Send(List<string> messageList)
        {
            messageList.ForEach(Console.WriteLine);
        }
    }
}
