using NUnit.Framework;
using Rhino.Mocks;
using TransportAnnouncementTracker.Announcement;

namespace TransportAnnouncementTracker.UnitTests
{
    [TestFixture]
    public class TrackerUnitTests
    {
        IAnnouncer announcer;

        [SetUp]
        public void SetUp()
        {
            announcer = MockRepository.GenerateMock<IAnnouncer>();
        }
    }
}
