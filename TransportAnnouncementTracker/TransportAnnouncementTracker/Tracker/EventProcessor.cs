using System.Collections.Generic;

namespace TransportAnnouncementTracker.Tracker
{
    public interface IEventProcessor
    {
        void Process(List<ArrivedEvent> events);
    }
}
