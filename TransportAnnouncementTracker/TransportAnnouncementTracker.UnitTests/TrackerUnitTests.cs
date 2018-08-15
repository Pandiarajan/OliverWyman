using NUnit.Framework;
using Rhino.Mocks;
using System.Collections.Generic;
using System.Threading;
using TransportAnnouncementTracker.TrackerItems;

namespace TransportAnnouncementTracker.UnitTests
{
    [TestFixture]
    public class TrackerUnitTests
    {
        IEventProcessor eventProcessor;
        Tracker tracker;
        IInformationReader informationReader;

        [SetUp]
        public void SetUp()
        {
            eventProcessor = MockRepository.GenerateMock<IEventProcessor>();
            informationReader = MockRepository.GenerateMock<IInformationReader>();
            informationReader.Stub(i => i.GetArrivalEvents()).Return(new List<ArrivalEvent>());
            tracker = new Tracker(informationReader, eventProcessor);
        }

        [Test]
        public void CanStartTracker()
        {
            tracker.Start();
            tracker.Stop();
            Thread.Sleep(1100);
            informationReader.AssertWasCalled(i => i.GetArrivalEvents());
            eventProcessor.AssertWasCalled(e => e.Process(Arg<List<ArrivalEvent>>.Is.Anything));            
        }
    }
}
