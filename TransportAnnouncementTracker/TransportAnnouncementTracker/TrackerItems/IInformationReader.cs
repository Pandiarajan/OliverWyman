using System.Collections.Generic;

namespace TransportAnnouncementTracker.TrackerItems
{
    public interface IInformationReader
    {
        List<ArrivalEvent> GetArrivalEvents();
    }
}
