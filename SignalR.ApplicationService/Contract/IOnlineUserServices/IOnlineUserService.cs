using SignalR.ApplicationService.ViewModels.OnlineUserViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SignalR.ApplicationService.Contract.IOnlineUserServices
{
    public interface IOnlineUserService
    {
        Task<IEnumerable<OnlineUserVM>> GetOnlineUsers();

    }
}
