using System.Collections.Generic;

namespace TransportAnnouncementTracker.Tracker
{
    public class EventProcessor
    {        
        public void Process(List<ArrivedEvent> events)
        {
            if (events == null)
            {
                throw new System.ArgumentNullException(nameof(events));
            }
        }
    }
}
