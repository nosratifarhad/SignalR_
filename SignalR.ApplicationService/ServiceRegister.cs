using Microsoft.Extensions.DependencyInjection;
using SignalR.ApplicationService.Contract.IOnlineUserServices;
using SignalR.ApplicationService.Implementation.OnlineUserServices;

namespace SignalR.ApplicationService
{
    public static class ServiceRegister
    {
        public static IServiceCollection AddApplicationServiceRegister(this IServiceCollection services)
        {
            return services.AddScoped<IOnlineUserService, OnlineUserService>();
        }
    }
}
