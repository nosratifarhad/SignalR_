using Microsoft.AspNetCore.SignalR;
using SignalR.HubService.Hubs.IHobs;
using SignalR.Infrastructure.Dtos.OnlineUserHubDTOs;
using SignalR.Infrastructure.Repositorys.OnlineUserHubRepositorys;
using System;
using System.Threading.Tasks;

namespace SignalR.HubService.Hubs
{
    public class OnlineUserHub : Hub, IOnlineUserHub
    {
        #region Fields
        private readonly IOnlineUserHubRepository _onlineUserHubRepository;
        #endregion Fields

        #region ctor

        public OnlineUserHub(IOnlineUserHubRepository onlineUserHubRepository)
        {
            this._onlineUserHubRepository = onlineUserHubRepository;
        }

        #endregion

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await _onlineUserHubRepository.OnDisconnectedOnlineUserAsync(Context.ConnectionId, DateTime.Now);///ipAddtess
        }

        #region HubMethod

        [HubMethodName("AddOnlineUserAsync")]
        public async Task AddOnlineUserAsync(string ipAddress, string browser, string country, string entrydate, string os, string url)//OnlineUserHobModel clientHobModel)
        {
            try
            {
                OnlineUserHubDto onlineUserHubDTO = new OnlineUserHubDto(ipAddress, browser, country, entrydate, os, url, Context.ConnectionId);

                //TODO Persistence
                await _onlineUserHubRepository.AddOnlineUserAsync(onlineUserHubDTO);
                //TODO Persistence

                //await Clients.All.SendAsync("ReciveMessage", ipAddress, true, "key");
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message);
            }
        }
        #endregion HubMethod
    }

}
