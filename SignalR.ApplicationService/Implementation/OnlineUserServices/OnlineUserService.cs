using SignalR.ApplicationService.Contract.IOnlineUserServices;
using SignalR.ApplicationService.ViewModels.OnlineUserVMs;
using SignalR.Infrastructure.Dtos.OnlineUserDTOs;
using SignalR.Infrastructure.Repositorys.OnlineUserRepositorys;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SignalR.ApplicationService.Implementation.OnlineUserServices
{
    public class OnlineUserService : IOnlineUserService
    {
        #region Fields
        private IOnlineUserRepository _onlineUserRepository;

        #endregion Fields

        #region ctor

        public OnlineUserService(IOnlineUserRepository onlineUserRepository)
        {
            this._onlineUserRepository = onlineUserRepository;
        }

        #endregion

        public async Task<IEnumerable<OnlineUserVM>> GetOnlineUsers()
        {
            var onlineUserDtolist = await _onlineUserRepository.GetOnlineUsersAsync();

            var onlineUserVMs = ToViewModel(onlineUserDtolist);

            return onlineUserVMs;
        }

        public string GetPresenceDate(string outDate, string entryDate, ref string presenceDate)
        {
            return "";
        }

        private IEnumerable<OnlineUserVM> ToViewModel(IEnumerable<OnlineUserDto> onlineUserDtolist)
        {
            List<OnlineUserVM> onlineUserViewModels = new List<OnlineUserVM>();

            foreach (var item in onlineUserDtolist)
            {
                ///To Do Get PresenceDate
                string presencedate = string.Empty;
                //GetPresenceDate(item.EntryDate, item.OutDate, ref presencedate);
                ///
                onlineUserViewModels.Add(new OnlineUserVM
                {
                    IpAddress = item.IpAddress,
                    Browser = item.Browser,
                    Country = item.Country,
                    EntryDate = item.EntryDate.ToString(),
                    OutDate = item.OutDate.ToString() ?? "",
                    PresenceDate = presencedate ?? "",
                    OS = item.OS,
                    Url = item.Url
                });
            }

            return (IEnumerable<OnlineUserVM>)onlineUserViewModels;

        }
    }
}
