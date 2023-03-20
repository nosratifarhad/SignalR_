using Microsoft.Extensions.DependencyInjection;
using SignalR.Infrastructure.Repositorys.OnlineUserHubRepositorys;
using SignalR.Infrastructure.Repositorys.OnlineUserRepositorys;

namespace SignalR.Infrastructure
{
    public static class ServiceRegister
    {
        public static IServiceCollection AddInfrastructureServiceRegister(this IServiceCollection services)
        {
            services.AddScoped<IOnlineUserHubRepository, OnlineUserHubRepository>();

            services.AddScoped<IOnlineUserRepository, OnlineUserRepository>();

            return services;
        }
    }
}
