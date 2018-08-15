using System.Collections.Generic;

namespace TransportAnnouncementTracker.Announcement
{
    public interface IAnnouncer
    {
        void Send(string message);
        void Send(List<string> messageList);
    }
}
