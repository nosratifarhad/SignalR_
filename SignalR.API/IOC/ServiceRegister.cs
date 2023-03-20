using Microsoft.Extensions.DependencyInjection;
using SignalR.ApplicationService;
using SignalR.HubService;
using SignalR.Infrastructure;

namespace SignalR.API.IOC
{
    public static class ServiceRegister
    {
        public static IServiceCollection AddServiceRegister(this IServiceCollection services)
        {
            services.AddHubServiceRegister();
            services.AddApplicationServiceRegister();
            services.AddInfrastructureServiceRegister();

            ///old not have test
            ////// OnlineUserHubRepository - OnlineUserHub
            //services.AddScoped<IOnlineUserHubRepository, OnlineUserHubRepository>()
            //    .AddScoped<IOnlineUserHub, OnlineUserHub>();

            ////// OnlineUserRepository - OnlineUserService
            //services.AddScoped<IOnlineUserRepository, OnlineUserRepository>().
            //    AddScoped<IOnlineUserService, OnlineUserService>();

            return services;
        }
    }
}
