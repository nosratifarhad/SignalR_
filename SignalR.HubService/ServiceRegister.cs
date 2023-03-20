using Microsoft.Extensions.DependencyInjection;
using SignalR.HubService.Hubs;
using SignalR.HubService.Hubs.IHobs;

namespace SignalR.HubService
{
    public static class ServiceRegister
    {
        public static IServiceCollection AddHubServiceRegister(this IServiceCollection services)
        {
            return services.AddScoped<IOnlineUserHub, OnlineUserHub>();
        }
    }
}
