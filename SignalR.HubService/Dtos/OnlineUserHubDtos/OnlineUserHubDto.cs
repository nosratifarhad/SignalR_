namespace SignalR.HubService.Dtos.OnlineUserHubDtos
{
    public class OnlineUserHubDto
    {
        public int Id { get; set; }

        public string IpAddress { get; set; }

        public string Browser { get; set; }

        public string Country { get; set; }

        public System.DateTime EntryDate { get; set; }

        public System.DateTime? OutDate { get; set; }

        public string OS { get; set; }

        public string Url { get; set; }

        public string ConnectionId { get; set; }
    }
}
