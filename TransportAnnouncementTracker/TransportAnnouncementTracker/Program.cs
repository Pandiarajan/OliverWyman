using System;
using TransportAnnouncementTracker.TrackerItems;
using Unity;

namespace TransportAnnouncementTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = UnityConfig.Config();
            var tracker = container.Resolve<Tracker>();
            tracker.Start();

            Console.ReadLine();
            tracker.Stop();
        }
    }
}
