using TransportAnnouncementTracker.Announcement;

namespace TransportAnnouncementTracker.Tracker
{
    public class Line
    {
        public string Name { get; private set; }
        public IAnnouncer _announcer { get; }

        public Line(string name, IAnnouncer announcer)
        {
            Name = name;
            _announcer = announcer;
        }
    }
}
