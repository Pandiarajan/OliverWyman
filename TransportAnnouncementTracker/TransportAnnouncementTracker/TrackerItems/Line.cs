using TransportAnnouncementTracker.Announcement;

namespace TransportAnnouncementTracker.TrackerItems
{
    public class Line
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        private IAnnouncer _announcer { get; }
        private IEventProcessor _eventProcessor { get; }

        public Line(string id, string name, IAnnouncer announcer, IEventProcessor eventProcessor)
        {
            Id = id;
            Name = name;
            _announcer = announcer;
            _eventProcessor = eventProcessor;
            _eventProcessor.TrainArrived += EventProcessor_TrainArrived;
        }

        private void EventProcessor_TrainArrived(ArrivalEvent arrivalEvent)
        {
            _announcer.Send(arrivalEvent.ToString());
        }
    }
}
