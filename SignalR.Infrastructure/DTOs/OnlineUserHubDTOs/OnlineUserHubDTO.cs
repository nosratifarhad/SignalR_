using System;

namespace SignalR.Infrastructure.Dtos.OnlineUserHubDTOs
{
    public class OnlineUserHubDto
    {
        public OnlineUserHubDto(
         string ipAddress,
         string browserType,
         string country,
         string entryDate,
         string systemType,
         string route,
         string connectionId)
        {
            this.IpAddress = ipAddress;
            this.Browser = browserType;
            this.Country = country;
            this.EntryDate = DateTime.Parse(entryDate);
            this.OS = systemType;
            this.Url = route;
            this.ConnectionId = connectionId;
        }

        public string IpAddress { get; set; }

        public string Browser { get; set; }
        
        public string Country { get; set; }
        
        public DateTime EntryDate { get; set; }
        
        public string OS { get; set; }
        
        public string Url { get; set; }
        
        public string ConnectionId { get; set; }
        
        public bool IsEqualIpAddress(string ipAddress)
        {
            return this.IpAddress == ipAddress;
        }
    }
}
