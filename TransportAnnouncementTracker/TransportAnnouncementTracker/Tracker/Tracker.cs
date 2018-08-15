using System;
using TransportAnnouncementTracker.Announcement;

namespace TransportAnnouncementTracker.Tracker
{
    public class Tracker
    {
        private readonly IAnnouncer _announcer;

        public Tracker(IAnnouncer announcer)
        {
            _announcer = announcer;
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
