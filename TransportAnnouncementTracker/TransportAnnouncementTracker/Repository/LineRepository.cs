using System.Collections.Generic;
using TransportAnnouncementTracker.Announcement;
using TransportAnnouncementTracker.TrackerItems;

namespace TransportAnnouncementTracker.Repository
{
    public class LineRepository
    {
        private List<Line> lines = new List<Line>();
        public LineRepository()
        {
            lines.Add(new Line("bakerloo", "Bakerloo", new TextAnnouncer()));
        }
        public IEnumerable<Line> GetLines()
        {
            return lines;
        }
    }
}
