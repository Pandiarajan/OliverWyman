using TransportAnnouncementTracker.Repository;
using TransportAnnouncementTracker.TrackerItems;
using Unity;
using Unity.Lifetime;

namespace TransportAnnouncementTracker
{
    public class UnityConfig
    {
        public static IUnityContainer Config()
        {
            IUnityContainer unitycontainer = new UnityContainer();
            unitycontainer.RegisterType<Tracker, Tracker>(new ContainerControlledLifetimeManager());
            unitycontainer.RegisterType<IEventProcessor, EventProcessor>(new ContainerControlledLifetimeManager());
            unitycontainer.RegisterType<LineRepository, LineRepository>(new ContainerControlledLifetimeManager());
            return unitycontainer;
        }
    }
}
