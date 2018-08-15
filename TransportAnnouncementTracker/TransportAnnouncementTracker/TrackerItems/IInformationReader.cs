using System.Collections.Generic;
using System.Threading.Tasks;

namespace TransportAnnouncementTracker.TrackerItems
{
    public interface IInformationReader
    {
        Task<List<ArrivalEvent>> GetArrivalEvents();
    }
}
