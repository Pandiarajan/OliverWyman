using System.Collections.Generic;

namespace TransportAnnouncementTracker.TrackerItems
{
    public interface IEventProcessor
    {
        void Process(List<ArrivalEvent> events);
    }
}
