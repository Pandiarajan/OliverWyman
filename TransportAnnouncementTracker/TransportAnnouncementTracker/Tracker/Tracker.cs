using System.Threading.Tasks;

namespace TransportAnnouncementTracker.Tracker
{
    public class Tracker
    {
        private IInformationReader _informationReader { get; }
        private IEventProcessor _eventProcessor { get; }
        private bool _IsStopped = false;

        public Tracker(IInformationReader informationReader, IEventProcessor eventProcessor)
        {
            _informationReader = informationReader;
            _eventProcessor = eventProcessor;
        }     

        public async void Start()
        {
            while (!_IsStopped)
            {
                await Task.Delay(1000);
                _eventProcessor.Process(_informationReader.GetArrivalEvents());
            }
        }

        public bool IsRunning()
        {
            return !_IsStopped;
        }

        public void Stop()
        {
            _IsStopped = true;
        }

    }
}
