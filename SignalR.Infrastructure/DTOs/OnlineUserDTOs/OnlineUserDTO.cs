using System;

namespace SignalR.Infrastructure.Dtos.OnlineUserDTOs
{
    public class OnlineUserDto
    {
        public string IpAddress { get; set; }

        public string Browser { get; set; }

        public string Country { get; set; }

        public DateTime EntryDate { get; set; }

        public DateTime OutDate { get; set; }

        public string OS { get; set; }

        public string Url { get; set; }
    }
}
