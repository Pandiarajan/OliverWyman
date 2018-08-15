using System.Threading.Tasks;
using TransportAnnouncementTracker.Repository;

namespace TransportAnnouncementTracker.TrackerItems
{
    public class Tracker
    {
        private IInformationReader _informationReader { get; }
        private IEventProcessor _eventProcessor { get; }
        private LineRepository _lineRepository { get; }

        private bool _IsStopped = false;

        public Tracker(IInformationReader informationReader, IEventProcessor eventProcessor, LineRepository lineRepository)
        {
            _informationReader = informationReader;
            _eventProcessor = eventProcessor;
            _lineRepository = lineRepository;
        }     

        public async void Start()
        {
            var lines = _lineRepository.GetLines();
            while (!_IsStopped)
            {
                await Task.Delay(1000);
                _eventProcessor.Process(await _informationReader.GetArrivalEvents());
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
