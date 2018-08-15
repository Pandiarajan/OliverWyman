using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace TransportAnnouncementTracker.TrackerItems
{
    public class InformationReader : IInformationReader
    {
        private string _url { get; }
        private HttpClient _httpClient { get; }

        public InformationReader(string url, HttpClient httpClient)
        {
            _url = url;
            _httpClient = httpClient;
        }

        public async Task<List<ArrivalEvent>> GetArrivalEvents()
        {
            return Transform(await _httpClient.GetStringAsync(_url));
        }

        private List<ArrivalEvent> Transform(string jsonContent)
        {
            return null; 
        }
    }
}
