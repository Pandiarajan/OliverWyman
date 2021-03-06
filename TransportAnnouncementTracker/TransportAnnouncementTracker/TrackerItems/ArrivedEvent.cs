﻿using Newtonsoft.Json;

namespace TransportAnnouncementTracker.TrackerItems
{
    public class ArrivalEvent
    {
        public long Id { get; internal set; }
        public int TimeToStationMs { get; internal set; }
        public int VehicleId { get; private set; }
        public int LineId { get; private set; }
        public string LineName { get; private set; }
        public string PlatformName { get; set; }
        public string Towards { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
