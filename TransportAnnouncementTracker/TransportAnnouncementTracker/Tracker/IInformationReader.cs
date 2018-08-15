using System.Collections.Generic;

namespace TransportAnnouncementTracker.Tracker
{
    public interface IInformationReader
    {
        List<ArrivedEvent> GetArrivalEvents();
    }
}
