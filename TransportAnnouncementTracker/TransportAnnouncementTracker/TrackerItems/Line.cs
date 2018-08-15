using TransportAnnouncementTracker.Announcement;

namespace TransportAnnouncementTracker.TrackerItems
{
    public class Line
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public IAnnouncer _announcer { get; }

        public Line(string id, string name, IAnnouncer announcer)
        {
            Id = id;
            Name = name;
            _announcer = announcer;
        }
    }
}
