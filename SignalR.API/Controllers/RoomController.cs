using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalR.ApplicationService.Contract.IOnlineUserServices;
using SignalR.HubService.Hubs;
using SignalR.HubService.Dtos.OnlineUserHubDtos;
using SignalR.HubService.SqlTableDependencyConfig;
using System.Threading.Tasks;

namespace SignalR.API.Controllers
{
    public class RoomController : Controller
    {
        #region ctor
        private readonly IOnlineUserService _onlineUserService;
        private readonly IHubContext<OnlineUserHub> _context;
        private readonly MessageNotifications notifications;

        public RoomController(IHubContext<OnlineUserHub> context, IOnlineUserService onlineUserService)
        {
            this._onlineUserService = onlineUserService;
            this._context = context;
            notifications = new MessageNotifications(DatabaseAccess.RetrieveConnectionString());
            notifications.OnNewMessage += Rooms_OnEnteredRoom;
        }
        #endregion

        private async void Rooms_OnEnteredRoom(OnlineUserHubDto server, NotificationEventArgs e)
        {
            var onlineUserViewModels = await Task.FromResult(await _onlineUserService.GetOnlineUsers());

            await _context.Clients.All.SendAsync("RecieveDBUpdates", onlineUserViewModels);
        }

        public ActionResult OnGet()
        {
            return View();
        }
    }
}
