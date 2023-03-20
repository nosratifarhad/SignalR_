using SignalR.Infrastructure.Dtos.OnlineUserHubDTOs;
using System;
using System.Threading.Tasks;

namespace SignalR.Infrastructure.EFRepositorys.OnlineUserHubEFRepositorys
{
    public interface IOnlineUserHubEFRepository
    {
        Task OnDisconnectedOnlineUserAsync(string connectionId,DateTime dateTime);

        Task AddOnlineUserAsync(OnlineUserHubDto onlineclient);
    }
}
