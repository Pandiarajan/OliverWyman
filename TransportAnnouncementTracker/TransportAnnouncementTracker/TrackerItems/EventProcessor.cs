using System.Collections.Generic;
using System.Threading;

namespace TransportAnnouncementTracker.TrackerItems
{
    public class EventProcessor : IEventProcessor
    {
        Dictionary<long, Timer> timers = new Dictionary<long,Timer>();
        public event TrainArrived TrainArrived;
        public void Process(List<ArrivalEvent> events)
        {
            foreach (ArrivalEvent @event in events)
            {
                if (timers[@event.Id] == null)
                {
                    timers.Add(@event.Id, new Timer(TimerCallBackEvent, @event, @event.TimeToStationMs, Timeout.Infinite));
                }
            }
        }
        private void TimerCallBackEvent(object status)
        {
            ArrivalEvent arrivalEvent = (ArrivalEvent)status;
            RaiseEvent(arrivalEvent);
            timers.Remove(arrivalEvent.Id);
        }

        private void RaiseEvent(ArrivalEvent arrivalEvent)
        {
            TrainArrived?.Invoke(arrivalEvent);
        }
    }
}
