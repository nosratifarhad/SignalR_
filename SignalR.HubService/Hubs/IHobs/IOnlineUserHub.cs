﻿using System.Threading.Tasks;

namespace SignalR.HubService.Hubs.IHobs
{
    public interface IOnlineUserHub
    {
        Task AddOnlineUserAsync(string ipAddress, string browser, string country, string entrydate, string os, string url);//ClientHobModel clientHobModel)
    }

}
